﻿using DesktopBookmaker.View.EditElement;
using DesktopBookmaker.Data;
using InterfaceView;
using InterfaceView.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace DesktopBookmaker.View.View
{
	public class EventsView
		: IView
	{
		private List<Teams> TeamsLoL { get; set; } = new List<Teams>();
		private List<Teams> TeamsSCGO { get; set; } = new List<Teams>();

		private EditComboBox Sports { get; set; } 
		private EditComboBox Teams { get; set; } 
		private EditComboBox Teams1 { get; set; }
		private EditComboBox Tournament { get; set; }

		private EditDateTime StartDate { get; set; }

		private EditCheckBox IsAvailable { get; set; }
		private EditCheckBox IsPast { get; set; }
		private EditComboBox WinnerTeam { get; set; }

		private EditCheckBox ToArchive { get; set; }

		public EventsView()
		{
			Sports = new EditComboBox() { Hint = "Спорт", NameItem = nameof(DesktopBookmaker.Data.Events.Sports) };
			Teams = new EditComboBox() { Hint = "Команда 1", NameItem = nameof(DesktopBookmaker.Data.Events.Teams) };
			Teams1 = new EditComboBox() { Hint = "Команда 2", NameItem = nameof(DesktopBookmaker.Data.Events.Teams1) };
			Tournament = new EditComboBox() { Hint = "Турнир", NameItem = nameof(DesktopBookmaker.Data.Events.Tournaments) };
			
			StartDate = new EditDateTime() { Hint = "Дата начала", NameItem = nameof(DesktopBookmaker.Data.Events.StartDate) };
			
			IsAvailable = new EditCheckBox() { Hint = "Видимость матча", NameItem = nameof(Events.IsAvailable) };
			IsPast = new EditCheckBox() { Hint = "Завершен", NameItem = nameof(Events.IsPast) };
			WinnerTeam = new EditComboBox { Hint = "Победитель", NameItem = nameof(Events.WinnerTeam), IsNullable=true };
			ToArchive = new EditCheckBox() { Hint = "В архиве", NameItem = nameof(Events.ToArchive) };

			Sports.SelectedItemChanged += SportSelected;
            Teams.SelectedItemChanged += Teams_SelectedItemChanged; 
            Teams1.SelectedItemChanged += Teams1_SelectedItemChanged;
            IsPast.SelectedItemChanged += IsPast_SelectedItemChanged;
            ToArchive.SelectedItemChanged += ToArchive_SelectedItemChanged;
			
			initData();
		}

        private void ToArchive_SelectedItemChanged(object sender, RoutedEventArgs e)
        {
			if(ToArchive.IsCheked == true)
            {
				WinnerTeam.IsHitTestVisible = false;

				IsAvailable.IsCheked = false;
				IsAvailable.IsHitTestVisible = false;
			}
            else
			{
				IsAvailable.IsHitTestVisible = true;
				WinnerTeam.IsHitTestVisible = true;
			}
		}

        private void IsPast_SelectedItemChanged(object sender, RoutedEventArgs e)
		{
			if (IsPast.IsCheked == true)
			{
				WinnerTeam.IsHitTestVisible = true;
			}
			else
			{
				WinnerTeam.IsHitTestVisible = false;
			}
		}

        private void Teams1_SelectedItemChanged(object sender, RoutedEventArgs e)
        {
			if(Teams1.Title is null)
            {
				WinnerTeam.Title = null;
				WinnerTeam.IsHitTestVisible = false;
				IsPast.IsCheked = false;
			}
            else if (!(Teams.Title is null) && !(Teams1.Title is null))
			{
				WinnerTeam.IsHitTestVisible = true;
				LoadWinnerTeamComboBox();
			}
			else
            {
				WinnerTeam.IsHitTestVisible = false;
			}
        }

        private void Teams_SelectedItemChanged(object sender, RoutedEventArgs e)
		{
			if (Teams.Title is null)
			{
				WinnerTeam.Title = null;
				WinnerTeam.IsHitTestVisible = false;
				IsPast.IsCheked = false;
			}
			else if (!(Teams.Title is null) && !(Teams1.Title is null))
			{
				WinnerTeam.IsHitTestVisible = true;
				LoadWinnerTeamComboBox();
			}
			else
			{
				WinnerTeam.IsHitTestVisible = false;
			}
		}

		private void LoadWinnerTeamComboBox()
        {
			WinnerTeam.Items = new List<Teams>() { (Teams)Teams.Title, (Teams)Teams1.Title };
        }

        private void SportSelected(Object sender, EventArgs e)
		{
			if (Sports.Title is null)
			{
				Teams.IsHitTestVisible = false;
				Teams1.IsHitTestVisible = false;
				Teams.Title = null;
				Teams1.Title = null;
				return;
			}

			SetTeams(((Sports)Sports.Title).Id);

			Teams.IsHitTestVisible = true;
			Teams1.IsHitTestVisible = true;
		}

		private async void initData()
		{
			using (DBContext db = new DBContext())
			{

				IEnumerable sport = null;
				IEnumerable tournament = null;
				await Task.Run(()
					=>
				{
					sport = db.Sports.ToArray();
					tournament = db.Tournaments.ToArray();
				});

				Sports.Items = sport;
				Tournament.Items = tournament;

				await Task.Run(()
					=>
				{
					TeamsSCGO.AddRange(db.GetEventsBySports(1).ToArray());
					TeamsLoL.AddRange(db.GetEventsBySports(2).ToArray());
				});
			}
		}

		public void SetTeams(Int32 i)
		{
			if (i == 1)
			{
				Teams.Items = TeamsSCGO;
				Teams1.Items = TeamsSCGO;
			}
			else if (i == 2)
			{
				Teams.Items = TeamsLoL;
				Teams1.Items = TeamsLoL;
			}
			else
				throw new Exception("что-то пошло не так");
		}

		public object GetUpdateInEditWindow(List<IEditControl> edits, object ob)
		{
			var event1 = (Events)ob ?? new Events();

			event1.Sports = (Sports)Sports.Title;
			event1.Teams = (Teams)Teams.Title;
			event1.Teams1 = (Teams)Teams1.Title;

			event1.StartDate = (DateTime)StartDate.Title;

			event1.IsAvailable = ((Boolean?)IsAvailable.Title).Value;
			event1.IsPast = ((Boolean?)IsPast.Title).Value;
			event1.WinnerTeam = (Teams)WinnerTeam.Title;
			event1.ToArchive = ((Boolean?)ToArchive.Title).Value;

			if (event1.IdTeam1 == 0)
				throw new ExceptionForUser("Вы не выбрали 1 команду!");

			if (event1.IdTeam2 == 0)
				throw new ExceptionForUser("Вы не выбрали 2 команду!");

			if (event1.IdSport == 0)
				throw new ExceptionForUser("Вы не выбрали Тип спорта!");

			if (event1.IdTeam1 == event1.IdTeam2)
				throw new ExceptionForUser("Две одинаковые команды не могут сражаться друг с другом!");

			return event1;
		}

		public void UpdateEditWindow(List<IEditControl> edits, object ob1)
		{
			var event1 = (Events)ob1;

			if (ob1 is null)
			{
				Sports.Title = null;
				Teams.Title = null;
				Teams1.Title = null;

				StartDate.Title = DateTime.Now;

				IsAvailable.Title = false;
				IsPast.Title = false;
				WinnerTeam.Title = null;
				ToArchive.Title = false;
				return;
			}

			foreach (Sports item in Sports.Items)
			{
				if (event1.IdSport == item.Id)
				{
					SetTeams(item.Id);

					Sports.Title = item;

					break;
				}
			}

			foreach (Teams t in Teams.Items)
				if (event1.IdTeam1 == t.Id) 
				{ Teams.Title = t; break; }

			foreach (Teams t in Teams1.Items)
				if (event1.IdTeam2 == t.Id)
				{ Teams1.Title = t; break; }
			
			foreach (Tournaments t in Tournament.Items)
				if (event1.IdTournament == t.Id)
				{ Tournament.Title = t; break; }

			StartDate.Title = event1.StartDate;
			IsAvailable.Title = event1.IsAvailable;
			IsPast.Title = event1.IsPast;
			WinnerTeam.Title = event1.WinnerTeam;
			ToArchive.Title = event1.ToArchive;
		}

		public void ViewTable(DataGrid data)
		{
			data.SelectedValuePath = "Id";

			foreach (var item in data.Columns)
			{
				switch (item.Header.ToString())
				{
					case (nameof(DesktopBookmaker.Data.Events.Id)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(DesktopBookmaker.Data.Events.Winner)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(DesktopBookmaker.Data.Events.IdSport)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(DesktopBookmaker.Data.Events.IdTeam1)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(DesktopBookmaker.Data.Events.IdTeam2)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(DesktopBookmaker.Data.Events.PossibleBets)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(DesktopBookmaker.Data.Events.IdTournament)):
						item.Visibility = Visibility.Collapsed;
						break;

					case (nameof(DesktopBookmaker.Data.Events.Teams)):
						item.Header = "Команда 1";
						break;
					case (nameof(DesktopBookmaker.Data.Events.Teams1)):
						item.Header = "Команда 2";
						break;
					case (nameof(DesktopBookmaker.Data.Events.StartDate)):
						item.Header = "Дата начала";
						break;
					case (nameof(DesktopBookmaker.Data.Events.IsAvailable)):
						item.Header = "Видимость";
						break;
					case (nameof(DesktopBookmaker.Data.Events.ToArchive)):
						item.Header = "В архиве";
						break;
					case (nameof(DesktopBookmaker.Data.Events.Tournaments)):
						item.Header = "Турнир";
						break;
					case (nameof(DesktopBookmaker.Data.Events.Sports)):
						item.Header = "Спорт";
						break;
					case (nameof(DesktopBookmaker.Data.Events.IsPast)):
						item.Header = "Завершен";
						break;
					case (nameof(DesktopBookmaker.Data.Events.WinnerTeam)):
						item.Header = "Победитель";
						break;
					default:
						break;
				}
			} 
		}

		public void LoadEditWindow(ListView listView)
		{
			listView.Items.Add(Sports);
			listView.Items.Add(Teams);
			listView.Items.Add(Teams1);
			listView.Items.Add(Tournament);

			listView.Items.Add(StartDate);

			listView.Items.Add(IsAvailable);
			listView.Items.Add(IsPast);
			listView.Items.Add(WinnerTeam);
			listView.Items.Add(ToArchive);
		}
	}
}