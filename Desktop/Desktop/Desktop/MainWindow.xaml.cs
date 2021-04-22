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
using DbHendler;
using Npgsql;
using Test.Data.Modal;

namespace Desktop
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			listSelectingAnAction.SelectedIndex = 0;
		}

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

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var date = Date.SelectedDate;
			var team1 = (Teams)(Team1.SelectedItem);
			var team2 = (Teams)(Team2.SelectedItem);

			DB.Events.Add(new Events() { Id_Sport = 1, Id_Team1 = team1.Id, Id_Team2 = team2.Id, Start_Date = date });
		}

		DbContext DB { get; set; }

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			String connectionString = "Host=localhost;Port=5432;Database=bookmaker_office;Username=postgres;Password=1234";
			NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);

			Grid = editAndAddMatches;
			Grid.Visibility = Visibility.Visible;

			try
			{
				DB = new DbContext(npgSqlConnection);

				foreach (var item in DB.Teams)
				{
					Team1.Items.Add(item);
					Team2.Items.Add(item);
				}
			}
			catch (NpgsqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		Grid Grid { get; set; }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
			if (Grid is null)
				return;

			Grid.Visibility = Visibility.Hidden;
			Grid = editAndAddMatches;
			Grid.Visibility = Visibility.Visible;
		}

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
		{
			if (Grid is null)
				return;

			Grid.Visibility = Visibility.Hidden;
			Grid = editAndAddBets;
			Grid.Visibility = Visibility.Visible;
		}
    }
}
