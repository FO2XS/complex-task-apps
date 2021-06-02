using DesktopBookmaker.Data;
using DesktopBookmaker.View.EditElement;
using InterfaceView;
using InterfaceView.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DesktopBokmeyker.View.View
{
	public class PossibleBetsView
		: IView
	{
		protected Events Events { get; set; }
		protected EditComboBox TypeOfBets { get; set; }

		protected EditDecimal Coef1 { get; set; }
		protected EditDecimal Coef2 { get; set; }

		protected EditDecimal Min { get; set; }
		protected EditDecimal Max { get; set; }

		protected EditCheckBox IsAvalaible { get; set; }
		protected EditCheckBox IsPast { get; set; }
		protected EditComboBox WinnerTeam { get; set; }
		protected EditCheckBox ToArchive { get; set; }

		public PossibleBetsView(Events events)
		{
			TypeOfBets = new EditComboBox() { Hint="Тип ставки", NameItem=nameof(PossibleBets.TypeOfBets) };

			Coef1 = new EditDecimal() { Hint="Коеф. 1", NameItem=nameof(PossibleBets.Coef1), Func= x => x > 1.01m && x < 10.01m && (x > 1.99m ? (Decimal)Coef2.Title < 2m : true) };
			Coef2 = new EditDecimal() { Hint="Коеф. 2", NameItem=nameof(PossibleBets.Coef2), Func= x => x > 1.01m && x < 10.01m && (x > 1.99m ? (Decimal)Coef1.Title < 2m : true) };

			Min = new EditDecimal() { Hint="Минимальная ставка", NameItem=nameof(PossibleBets.Min), Func= x => x > 1m && x < (Decimal)Max.Title };
			Max = new EditDecimal() { Hint="Максимальная ставка", NameItem=nameof(PossibleBets.Max), Func= x => x > (Decimal)Min.Title && x < 999999 };

			IsAvalaible = new EditCheckBox() { Hint="Видимость ставки", NameItem=nameof(PossibleBets.IsAvalaible) };
			IsPast = new EditCheckBox() { Hint="Рассчитана", NameItem=nameof(PossibleBets.IsPast) };
			WinnerTeam = new EditComboBox { Hint="Победитель", NameItem=nameof(PossibleBets.WinnerTeam), IsNullable = true };
			ToArchive = new EditCheckBox() { Hint="В архиве", NameItem=nameof(PossibleBets.ToArchive) };

			IsPast.SelectedItemChanged += IsPast_SelectedItemChanged;
			ToArchive.SelectedItemChanged += ToArchive_SelectedItemChanged;

			Events = events;

			LoadWinnerTeam();

			initData();
		}

		private void ToArchive_SelectedItemChanged(object sender, RoutedEventArgs e)
		{
			if (ToArchive.IsCheked == true)
			{
				IsPast.IsCheked = true;
				IsPast.IsHitTestVisible = false;

				TypeOfBets.IsHitTestVisible = false;

				Coef1.IsHitTestVisible = false;
				Coef2.IsHitTestVisible = false;

				Min.IsHitTestVisible = false;
				Max.IsHitTestVisible = false;

				IsAvalaible.IsCheked = false;
				IsAvalaible.IsHitTestVisible = false;

				IsPast.IsCheked = true;
				IsPast.IsHitTestVisible = false;
				
				WinnerTeam.IsHitTestVisible = false;
			}
			else
			{
				IsPast.IsHitTestVisible = true;

				TypeOfBets.IsHitTestVisible = true;

				Coef1.IsHitTestVisible = true;
				Coef2.IsHitTestVisible = true;

				Min.IsHitTestVisible = true;
				Max.IsHitTestVisible = true;

				IsAvalaible.IsHitTestVisible = true;

				IsPast.IsHitTestVisible = true;

				WinnerTeam.IsHitTestVisible = true;
			}
		}

		private void IsPast_SelectedItemChanged(object sender, RoutedEventArgs e)
		{
			if (IsPast.IsCheked == true)
			{
				IsAvalaible.Title = true;
				IsAvalaible.IsHitTestVisible = true;
				
				ToArchive.IsHitTestVisible = true;
				WinnerTeam.IsHitTestVisible = true;
				WinnerTeam.IsChecked = false;
			}
			else
			{
				ToArchive.IsCheked = false;
				ToArchive.IsHitTestVisible = false;

				WinnerTeam.IsHitTestVisible = false;
				WinnerTeam.Title = null;
			}
		}

		private async void initData()
		{
			using (DBContext db = new DBContext())
			{
				var list = new List<TypeOfBets>();

				await Task.Run(() => list = db.TypeOfBets.ToList());

				TypeOfBets.Items = list;
			}
		}

		public object GetUpdateInEditWindow(List<IEditControl> edits, object ob)
		{
			var possibleBets = (PossibleBets)ob ?? new PossibleBets();

			possibleBets.TypeOfBets = (TypeOfBets)TypeOfBets.Title;

			possibleBets.IdEvent = Events.Id;

			possibleBets.Coef1 = (Single)(Decimal)Coef1.Title;
			possibleBets.Coef2 = (Single)(Decimal)Coef2.Title;

			possibleBets.Min = (Decimal)Min.Title;
			possibleBets.Max = (Decimal)Max.Title;

			possibleBets.IsAvalaible = ((Boolean?)IsAvalaible.Title).Value;
			possibleBets.IsPast = ((Boolean?)IsPast.Title).Value;
			possibleBets.WinnerTeam = (Teams)WinnerTeam.Title;
			possibleBets.ToArchive = ((Boolean?)ToArchive.Title).Value;

			if (TypeOfBets is null)
				throw new ExceptionForUser("Вы не выбрали тип ставки!");

			return possibleBets;
		}

		public void LoadEditWindow(ListView listView)
		{
			listView.Items.Add(TypeOfBets);

			listView.Items.Add(Coef1);
			listView.Items.Add(Coef2);

			listView.Items.Add(Min);
			listView.Items.Add(Max);

			listView.Items.Add(IsAvalaible);
			listView.Items.Add(IsPast);
			listView.Items.Add(WinnerTeam);
			listView.Items.Add(ToArchive);
		}

		public void LoadWinnerTeam()
		{
			WinnerTeam.Items = new List<Teams>() { Events.Teams, Events.Teams1 };
		}

		public void UpdateEditWindow(List<IEditControl> edits, object ob)
		{
			var possibleBets = (PossibleBets)ob;

			UpdateEditControl();

			if(ob is null)
			{
				IsPast.Visibility = Visibility.Collapsed;
				WinnerTeam.Visibility = Visibility.Collapsed;
				ToArchive.Visibility = Visibility.Collapsed;

				TypeOfBets.Title = null;

				Coef1.Title = 1.87;
				Coef2.Title = 1.87;

				Min.Title = 1;
				Max.Title = 10000;

				IsAvalaible.Title = true;
				IsPast.Title = false;
				WinnerTeam.Title = null;
				ToArchive.Title = false;
				return;
			}

			if (possibleBets.IsPast)
			{
				TypeOfBets.IsEnabled = false;

				Coef1.IsEnabled = false;
				Coef2.IsEnabled = false;

				Min.IsEnabled = false;
				Max.IsEnabled = false;

				IsAvalaible.IsEnabled = false;
				WinnerTeam.IsEnabled = false;
				IsPast.IsEnabled = false;
			}

			WinnerTeam.IsHitTestVisible = false;

			foreach (TypeOfBets t in TypeOfBets.Items)
				if (possibleBets.IdTob == t.Id)
				{ TypeOfBets.Title = t; break; }

			Coef1.Title = possibleBets.Coef1;
			Coef2.Title = possibleBets.Coef2;

			Min.Title = possibleBets.Min;
			Max.Title = possibleBets.Max;

			IsAvalaible.Title = possibleBets.IsAvalaible;

			if (possibleBets.Winner == true)
				WinnerTeam.Title = Events.Teams;

			else if (possibleBets.Winner == false)
				WinnerTeam.Title = Events.Teams1;

			else 
				WinnerTeam.Title = null;

			ToArchive.Title = possibleBets.ToArchive;

			IsPast.Title = possibleBets.IsPast;
		}

		private void UpdateEditControl()
		{
			TypeOfBets.Visibility = Visibility.Visible;

			Coef1.Visibility = Visibility.Visible;
			Coef2.Visibility = Visibility.Visible;

			Min.Visibility = Visibility.Visible;
			Max.Visibility = Visibility.Visible;

			IsAvalaible.Visibility = Visibility.Visible;
			IsPast.Visibility = Visibility.Visible;
			WinnerTeam.Visibility = Visibility.Visible;
			ToArchive.Visibility = Visibility.Visible;

			TypeOfBets.Visibility = Visibility.Visible;

			TypeOfBets.IsEnabled = true;

			Coef1.IsEnabled =  true;
			Coef2.IsEnabled = true;

			Min.IsEnabled =  true;
			Max.IsEnabled =  true;

			IsAvalaible.IsEnabled = true;
			IsPast.IsEnabled = true;
			WinnerTeam.IsEnabled = true;
			ToArchive.IsEnabled = true;
		}

		public void ViewTable(DataGrid data)
		{
			data.SelectedValuePath = "Id";

			foreach (var item in data.Columns)
			{
				switch (item.Header.ToString())
				{
					case (nameof(PossibleBets.Id)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(PossibleBets.IdEvent)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(PossibleBets.IdTob)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(PossibleBets.Margin)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(PossibleBets.Max)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(PossibleBets.Min)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(PossibleBets.Coef1)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(PossibleBets.Coef2)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(PossibleBets.Winner)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(PossibleBets.UserBets)):
						item.Visibility = Visibility.Collapsed;
						break;
					case (nameof(PossibleBets.Events)):
						item.Visibility = Visibility.Collapsed;
						break;

					case (nameof(PossibleBets.MaxMin)):
						item.Header = "Мин-Макс";
						break;
					case (nameof(PossibleBets.Coef)):
						item.Header = "Коеф1-Коеф2";
						break;

					case (nameof(PossibleBets.IsPast)):
						item.Header = "Завершен";
						break;
					case (nameof(PossibleBets.WinnerTeam)):
						item.Header = "Победитель";
						break;
					case (nameof(PossibleBets.IsAvalaible)):
						item.Header = "Видимость";
						break;
					case (nameof(PossibleBets.ToArchive)):
						item.Header = "В архиве";
						break;
					default:
						break;
				}
			}
		}
	}
}
