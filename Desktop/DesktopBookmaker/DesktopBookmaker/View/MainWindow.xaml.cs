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
using System.Data.Entity;
using BaseSyle;
using DesktopBookmaker.View.EditElement;
using InterfaceView.View;
using DesktopBookmaker.View.EditWindows;

namespace DesktopBookmaker.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
		: Window
    {
		public MainWindow()
		{
			InitializeComponent();
		}

		public Matches Matches { get; set; }
        public PossibleBets PossibleBets { get; private set; }

		private void MenuCloseEvent(object sender, RoutedEventArgs e)
		{
			ButtonMenuClose.Visibility = Visibility.Collapsed;
			ButtonMenuOpen.Visibility = Visibility.Visible;
		}

		private void MenuOpenEvent(object sender, RoutedEventArgs e)
		{
			ButtonMenuOpen.Visibility = Visibility.Collapsed;
			ButtonMenuClose.Visibility = Visibility.Visible;
		}

		private void Close(object sender, RoutedEventArgs e)
        {
			Close();
        }

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			InitEditWindow();

			contentMain.Visibility = Visibility.Collapsed;

			listSelectingAnAction.SelectedIndex = 0;

			var login = new LogIn.LogIn()
			{
				Tooltip = tooltip,
				Opacity = 1,
			};

			main.Children.Add(login);

			login.CloseEvent += Close;
			login.LogInEvent += (s, ex) => 
			{
				login.Visibility = Visibility.Collapsed;
				this.logIn.Content = login.logIn.Text; 
				contentMain.Visibility = Visibility.Visible;
			};
		}

        private void InitEditWindow()
		{
			Matches = new Matches(tooltip);
			PossibleBets = new PossibleBets(tooltip);
		}

		private void ListViewItem_Selected(object sender, RoutedEventArgs e)
		{
			if (WiewEditWindow.Children.Count > 0)
				WiewEditWindow.Children.Remove(WiewEditWindow.Children[0]);

			WiewEditWindow.Children.Add(Matches);
		}

		private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
		{
			if (WiewEditWindow.Children.Count > 0)
				WiewEditWindow.Children.Remove(WiewEditWindow.Children[0]);

			WiewEditWindow.Children.Add(PossibleBets);
		}
    }
}
