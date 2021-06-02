using BaseSyle;
using DesktopBookmaker.Data;
using DesktopBookmaker.View.Control;
using DesktopBookmaker.View.View;
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
    /// Логика взаимодействия для Matches.xaml
    /// </summary>
    public partial class Matches 
        : UserControl
    {
        private Boolean IsLoad { get; set; }

        protected EventsView View { get; set; }
        protected EventsControl Control { get; set; }
        
        protected EditTable EditTable { get; set; }
        protected Tooltip Tooltip { get; set; }
        protected ViewSortingData ViewSortingData { get; set; }

        protected BaseSyle.CheckBox IsAvailable { get; set; }
        protected BaseSyle.CheckBox IsPast { get; set; }
        protected BaseSyle.CheckBox ToArchive { get; set; }

        private Matches()
        {
            InitializeComponent();
        }

        public Matches(Tooltip tooltip)
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
            ToArchive = new BaseSyle.CheckBox()
            {
                Hint = "В архиве",
                NameItem = nameof(Events.ToArchive),
                IsCheked = false,
            };

            ViewSortingData = new ViewSortingData(new List<BaseSyle.CheckBox>() { IsAvailable, IsPast, ToArchive })
            {
                Margin = new Thickness(10),
            };

            ViewSortingData.SelectAnItem(ToArchive);

            searchWindow.Children.Add(ViewSortingData);

            EditTable = new EditTable(View = new EventsView(), Control = new EventsControl(), Tooltip);
            editAndAddMatchesTable.Children.Add(EditTable);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void SearchTextBox_SearchClick(object sender, RoutedEventArgs e)
        {
            EditTable.GetFuncs.Clear();

            if (ViewSortingData.GetActiveItems.Contains(IsPast))
            {
                Boolean? b = IsPast.IsCheked;
                EditTable.GetFuncs.Add((x) => b == ((Events)x).IsPast);
            }

            if (ViewSortingData.GetActiveItems.Contains(IsAvailable))
            {
                Boolean? b = IsAvailable.IsCheked;
                EditTable.GetFuncs.Add(x => b == ((Events)x).IsAvailable);
            }

            if (ViewSortingData.GetActiveItems.Contains(ToArchive))
            {
                Boolean? b = ToArchive.IsCheked;
                EditTable.GetFuncs.Add(x => b == ((Events)x).ToArchive);
            }

            if (!String.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                var str = searchTextBox.Text.Trim().ToLower();

                EditTable.GetFuncs.Add(x => ((Events)x).Teams.Title.ToLower().Contains(str) || ((Events)x).Teams1.Title.ToLower().Contains(str));
            }

            EditTable.UpdateTable(true);
        }
    }
}
