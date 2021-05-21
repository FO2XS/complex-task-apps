using DesktopBookmaker.Data;
using DesktopBookmaker.View.EditElement;
using InterfaceView;
using InterfaceView.View;
using System;
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
        public object GetUpdateInEditWindow(List<IEditControl> edits, object ob)
        {
			var event1 = (Events)ob ?? new Events();

			foreach (IEditControl item in edits)
			{
				switch (item.NameItem)
				{
					case (nameof(Data.Events.Teams)):
						event1.Teams = (Teams)item.Title;
						break;

					case (nameof(Data.Events.Teams1)):
						event1.Teams1 = (Teams)item.Title;
						break;

					case (nameof(Data.Events.Sports)):
						event1.Sports = (Sports)item.Title;
						break;

					case (nameof(Data.Events.StartDate)):
						event1.StartDate = (DateTime)item.Title;
						break;

					default:
						break;
				}
			}


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

        public async Task LoadEditWindow(ListView listView)
        {
			using (var db = new DBContext())
			{
				var teams = new List<Teams>();
				var sports = new List<Sports>();

				await Task.Run(() =>
				{
					teams = db.Teams.ToList();
					sports = db.Sports.ToList();
				});

				new List<Object>()
				{
					new EditComboBox() { Items=sports, Hint="Спорт", NameItem=nameof(Data.Events.Sports) },
					new EditComboBox() { Items=teams, Hint="Команда 1", NameItem=nameof(Data.Events.Teams) },
					new EditComboBox() { Items=teams, Hint="Команда 2", NameItem=nameof(Data.Events.Teams1) },
					new EditDateTime() { Hint="Дата", NameItem=nameof(Data.Events.StartDate) },

				}.ForEach(x => listView.Items.Add(x));
			}
		}

        public void UpdateEditWindow(List<IEditControl> edits, object ob1)
        {
			var event1 = (Events)ob1;

			if (event1 is null)
            {
				foreach (IEditControl item in edits)
				{
					switch (item.NameItem)
					{
						case (nameof(Data.Events.Teams)):
							item.Title = null;
							break;

						case (nameof(Data.Events.Teams1)):
							item.Title = null;
							break;

						case (nameof(Data.Events.Sports)):
							item.Title = null;
							break;

						case (nameof(Data.Events.StartDate)):
							item.Title = DateTime.Now;
							break;

						default:
							break;
					}
				}

				return;
            }

			foreach (IEditControl item in edits)
			{
				switch (item.NameItem)
				{
					case (nameof(Data.Events.Teams)):
						var team = new Teams();

						foreach (Teams t in ((EditComboBox)item).Items)
							if (event1.IdTeam1 == t.Id) { team = t; break; }

						item.Title = team;
						break;

					case (nameof(Data.Events.Teams1)):
						var team1 = new Teams();

						foreach (Teams t in ((EditComboBox)item).Items)
							if (event1.IdTeam2 == t.Id) { team1 = t; break; }

						item.Title = team1;
						break;

					case (nameof(Data.Events.Sports)):
						var sport = new Sports();

						foreach (Sports s in ((EditComboBox)item).Items)
							if (event1.IdSport == s.Id) { sport = s; break; }

						item.Title = sport;
						break;

					case (nameof(Data.Events.StartDate)):
						item.Title = event1.StartDate;
						break;

					default:
						break;
				}
			}
		}

        public void ViewTable(DataGrid data)
		{
			foreach (var item in data.Columns)
			{
				switch (item.Header.ToString())
				{
					case (nameof(Data.Events.Id)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(Data.Events.IdWin)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(Data.Events.IsPast)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(Data.Events.IdSport)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(Data.Events.IdTeam1)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(Data.Events.IdTeam2)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(Data.Events.PossibleBets)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(Data.Events.IdLose)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(Data.Events.ToArchive)):
						item.Visibility = Visibility.Collapsed;
						break;
					default:
						break;
				}
			}
		}
    }
}
