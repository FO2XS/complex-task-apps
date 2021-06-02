using BaseSyle;
using DesktopBokmeyker.View.View;
using DesktopBookmaker.Data;
using DesktopBookmaker.View.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;



namespace DesktopBookmaker.View.EditWindows
{
    /// <summary>
    /// Логика взаимодействия для PossibleBets.xaml
    /// </summary>
    public partial class PossibleBets : UserControl
    {
        public Int32? IdEvent { get; set; }

        public Tooltip Tooltip { get; private set; }

        protected ViewSortingData ViewSortingData { get; set; }

        protected EditTable EditTable { get; set; }

        protected BaseSyle.CheckBox IsAvailable { get; set; }
        protected BaseSyle.CheckBox IsPast { get; set; }

        protected PossibleBetsView View { get; private set; }
        protected PossibleBetsControl Control { get; private set; }

        protected PossibleBets()
        {
            InitializeComponent();
        }

        public PossibleBets(Tooltip tooltip)
            : this()
        {
            Tooltip = tooltip;

            IsAvailable = new BaseSyle.CheckBox()
            {
                Hint = "Виден ли матч",
                NameItem = nameof(Events.IsAvailable)
            };
            IsPast = new BaseSyle.CheckBox()
            {
                Hint = "Матч завершен",
                NameItem = nameof(Events.IsPast)
            };

            ViewSortingData = new ViewSortingData(new List<BaseSyle.CheckBox>() { IsAvailable, IsPast })
            {
                Margin = new Thickness(10),
            };

            searchWindow.Children.Add(ViewSortingData);

            UpdateComboBox();
        }

        private void SearchTextBox_SearchClick(object sender, RoutedEventArgs e)
        {
            UpdateComboBox();

            events.IsDropDownOpen = true;
        }

        public async void UpdateComboBox()
        {
            var listFunc = new List<Func<Object, Boolean>>();

            if (ViewSortingData.GetActiveItems.Contains(IsPast))
            {
                Boolean? b = IsPast.IsCheked;
                listFunc.Add(x => b == ((Events)x).IsPast);
            }

            if (ViewSortingData.GetActiveItems.Contains(IsAvailable))
            {
                Boolean? b = IsAvailable.IsCheked;
                listFunc.Add(x => b == ((Events)x).IsAvailable);
            }

            listFunc.Add(x => false == ((Events)x).ToArchive);

            if (!String.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                var str = searchTextBox.Text.Trim().ToLower();

                listFunc.Add(x => ((Events)x).Teams.Title.ToLower().Contains(str) || ((Events)x).Teams1.Title.ToLower().Contains(str));
            }

            var listEvents = new List<Object>();

            await new EventsControl().SearchAsync(listEvents, listFunc);

            events.ItemsSource = listEvents;
        }

        private void SelectEvents(object sender, SelectionChangedEventArgs e)
        {
            if (events.SelectedItem is null)
                return;

            View = new PossibleBetsView((Data.Events)events.SelectedItem);
            Control = new PossibleBetsControl();

            Control.IdEvents = ((Data.Events)events.SelectedItem).Id;
            IdEvent = Control.IdEvents;

            if (editAndAddMatchesTable.Children.Count > 0)
                editAndAddMatchesTable.Children.RemoveAt(0);

            EditTable = new EditTable(View, Control, Tooltip);
            editAndAddMatchesTable.Children.Add(EditTable);
        }

        private void events_DropDownOpened(object sender, EventArgs e)
        {
            if (!(EditTable is null) && EditTable.IsActive)
            {
                Tooltip.Show("Завершите работу с таблицей!", BaseSyle.Library.TypeEvent.ErrorUser, "Предупреждение!");
                events.IsDropDownOpen = false;
                return;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (IdEvent is null)
            {
                if (editAndAddMatchesTable.Children.Count > 0)
                    editAndAddMatchesTable.Children.RemoveAt(0);

                EditTable = null;
            }
            else
            {
                using (DBContext db = new DBContext())
                {
                    if(db.Events.FirstOrDefault(x => x.Id == IdEvent.Value) is null)
                    {
                        if (editAndAddMatchesTable.Children.Count > 0)
                            editAndAddMatchesTable.Children.RemoveAt(0);

                        EditTable = null;

                        Tooltip.Show("Таблица обнавилась, т.к. событие удалено", BaseSyle.Library.TypeEvent.ErrorUser);
                    }
                }
            }
        }
    }
}
