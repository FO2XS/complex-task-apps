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
	public partial class MainWindow
		: Window
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


		/*
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var date = Date.SelectedDate;
			var team1 = (Teams)(Team1.SelectedItem);
			var team2 = (Teams)(Team2.SelectedItem);

			DB.Events.Add(new Events() { Id_Sport = 1, Id_Team1 = team1.Id, Id_Team2 = team2.Id, Start_Date = date });
		}
		*/

		DbContext DB { get; set; }

		IEnumerable<Match> Matches { get; set; }

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			String connectionString = "Host=localhost;Port=5432;Database=bookmaker_office;Username=postgres;Password=1234";
			NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);

			Grid = editAndAddMatches;
			Grid.Visibility = Visibility.Visible;

			try
			{
				DB = new DbContext(npgSqlConnection);

				/*
				foreach (var item in DB.Teams)
				{
					Team1.Items.Add(item);
					Team2.Items.Add(item);
				}
				*/
				data.ItemsSource = null;

				Matches = DB.Events.Select(x =>
					new Match()
					{
						Id = x.Id,
						Team1 = DB.Teams.FirstOrDefault(x1 => x1.Id == x.Id_Team1),
						Team2 = DB.Teams.FirstOrDefault(x1 => x1.Id == x.Id_Team2),
						Data = x.Start_Date.Value.ToString("Y")
					});
				data.ItemsSource = Matches;

				data.Columns[0].Visibility = Visibility.Collapsed;
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

        private void data_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
			BorderContext.Visibility = Visibility.Hidden;
			BorderContext.Visibility = Visibility.Visible;

			BorderContext.IsHitTestVisible = true;

			e.Cancel = true;
		}

        private void SearchTextBox_SearchClick(object sender, RoutedEventArgs e)
        {
			if (!String.IsNullOrWhiteSpace(searchTextBox.Text))
            {
				var str = searchTextBox.Text.Trim().ToLowerInvariant();

				data.ItemsSource = Matches.Where(x => x.Team1.Title.ToLowerInvariant().Contains(str) || x.Team2.Title.ToLowerInvariant().Contains(str));
			}

			else
				data.ItemsSource = Matches;

			if (data.Items.Count > 0)
				data.Columns[0].Visibility = Visibility.Collapsed;
		}

        private void BorderContext_MouseLeave(object sender, MouseEventArgs e)
        {
			BorderContext.IsHitTestVisible = false;
        }
		/*
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			var listEvent = new List<Events>();

			if (searchBox.Text.Trim() != "")
			{
				var list = DB
					.Teams
					.Search($"lower(title) LIKE lower('%{searchBox.Text}%')");

				foreach (var item in list)
					listEvent.AddRange(DB.Events.Search($"id_team1 = {item.Id} OR id_team2 = {item.Id}"));
			}
			else
				listEvent = DB.Events.ToList();

			data.ItemsSource = null;

			data.ItemsSource = listEvent.Select(
				x => new 
				{
					Team1 = DB.Teams.FirstOrDefault(x1 => x1.Id == x.Id_Team1).Title,
					Team2 = DB.Teams.FirstOrDefault(x1 => x1.Id == x.Id_Team2).Title,
					Date = x.Start_Date
				});
		}
		*/
	}
}
