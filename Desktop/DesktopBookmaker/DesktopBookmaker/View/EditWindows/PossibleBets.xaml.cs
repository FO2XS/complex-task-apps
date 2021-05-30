using BaseSyle;
using DesktopBokmeyker.View.View;
using DesktopBookmaker.Data;
using DesktopBookmaker.View.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopBookmaker.View.EditWindows
{
    /// <summary>
    /// Логика взаимодействия для PossibleBets.xaml
    /// </summary>
    public partial class PossibleBets : UserControl
    {
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
        }

        private async void SearchTextBox_SearchClick(object sender, RoutedEventArgs e)
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

            View = new PossibleBetsView();
            Control = new PossibleBetsControl();

            Control.IdEvents = ((Data.Events)events.SelectedItem).Id;
            
            EditTable = new EditTable(View, Control, Tooltip);
            editAndAddMatchesTable.Children.Add(EditTable);
        }
    }
}
