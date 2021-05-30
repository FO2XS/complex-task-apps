using DesktopBookmaker.Data;
using InterfaceView;
using InterfaceView.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows;

namespace DesktopBookmaker.View.Control
{
	public class PossibleBetsControl
		: IControl
	{
		public Int32 IdEvents { get; set; }

		public async Task AddAsync(object ob)
		{
			try
			{
				var possibleBets = ob as PossibleBets;

				if (possibleBets is null)
					throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(PossibleBets)}");

				var possibleBets2 = new PossibleBets
				{
					IdTob = possibleBets.IdTob,
					IdEvent = possibleBets.IdEvent,
					Min = possibleBets.Min,
					Max = possibleBets.Max,
					Margin = possibleBets.Margin,
					Coef1 = possibleBets.Coef1,
					Coef2 = possibleBets.Coef2,
					IsAvalaible = possibleBets.IsAvalaible,
					IsPast = possibleBets.IsPast,
					ToArchive = possibleBets.ToArchive,
					Winner = possibleBets.Winner,
				};

				var DB = new DBContext();

				DB.PossibleBets.Add(possibleBets2);

				await DB.SaveChangesAsync();
			}
			catch (ExceptionForUser ex)
			{
				throw;
			}
		}

		public async Task DeleteAsync(object ob)
		{
			try
			{
				var possibleBets = ob as PossibleBets;

				if (possibleBets is null)
					throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(PossibleBets)}");

				var DB = new DBContext();

				var ev = await DB.PossibleBets.FindAsync(possibleBets.Id);

				if (ev.UserBets.Count > 0)
					throw new ExceptionForUser("Нельзя удалить событие, на котором есть пользовательские ставки! Вместо этого попробуйте установить значение\"Событие прошло\"");

				DB.PossibleBets.Remove(ev);

				await DB.SaveChangesAsync();
			}
			catch (ExceptionForUser)
			{
				throw;
			}
		}

		public async Task DeleteAsync(int id)
		{
			try
			{
				var DB = new DBContext();

				var ev = await DB.PossibleBets.FindAsync(id);

				if (ev.UserBets.Count > 0)
					throw new ExceptionForUser("Нельзя удалить событие, на котором есть пользовательские ставки! Вместо этого попробуйте установить значение\"Событие прошло\"");

				DB.PossibleBets.Remove(ev);

				await DB.SaveChangesAsync();
			}
			catch (ExceptionForUser)
			{
				throw;
			}
		}

		public async Task EditAsync(object ob)
		{
			try
			{
				var possibleBets = ob as PossibleBets;

				if (possibleBets is null)
					throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(PossibleBets)}");

				var DB = new DBContext();

				var possibleBets2 = await DB.PossibleBets
					.Include(x => x.UserBets)
					.FirstOrDefaultAsync(x => x.Id == possibleBets.Id);

				possibleBets2.IdTob = possibleBets.IdTob;
				possibleBets2.IdEvent = possibleBets.IdEvent;
				possibleBets2.Min = possibleBets.Min;
				possibleBets2.Max = possibleBets.Max;
				possibleBets2.Margin = possibleBets.Margin;
				possibleBets2.Coef1 = possibleBets.Coef1;
				possibleBets2.Coef2 = possibleBets.Coef2;
				possibleBets2.IsAvalaible = possibleBets.IsAvalaible;
				possibleBets2.IsPast = possibleBets.IsPast;
				possibleBets2.ToArchive = possibleBets.ToArchive;
				possibleBets2.Winner = possibleBets.Winner;

				if (possibleBets2.IsPast)
				{
					Int32? w = null;

					if(possibleBets2.Winner is null && MessageBox.Show("Рассчитать ставки для события типа 'Ничья'?", "Неопределенность!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
						w = 2;
					else if(possibleBets2.Winner is null && MessageBox.Show("Рассчитать ставки для ОТМЕНЕННОГО события?", "Неопределенность!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
						w = 3;
					else if (!(possibleBets2.Winner is null) && possibleBets2.Winner.Value)
						w = 0;
					else if (!(possibleBets2.Winner is null) && !possibleBets2.Winner.Value)
						w = 1;

					if (w is null)
						throw new ExceptionForUser("Не выбрано событие для расчета ставок!");

					foreach (var item in possibleBets.UserBets)
					{
						var UB = await DB.UserBets.FirstOrDefaultAsync(x => x.Id == item.Id);

						UB.Victory = (Int16)w.Value;
						if (w == 0 || w == 1)
                        {
							if (UB.Side)
								UB.Prize = w == 0 ? (UB.Sum * (Decimal)UB.Coef) : 0;
							else
								UB.Prize = w == 1 ? (UB.Sum * (Decimal)UB.Coef) : 0;
                        }
						else if (w == 2)
							UB.Prize = UB.Sum;
						else if (w == 3)
							UB.Prize = UB.Sum;
					}
				}

				/// DB.Entry<Events>(event2).State = EntityState.Modified;

				await DB.SaveChangesAsync();
			}
			catch (ExceptionForUser)
			{
				throw;
			}
		}

		public async Task GetDataAsync(ICollection<object> list)
		{
			if (list is null)
				list = new List<Object>();

			if (list.Count > 0)
				list.Clear();

			using (var db = new DBContext())
			{
				var list1 = new List<PossibleBets>();

				await Task.Run(() => {
					list1 = db.PossibleBets
						.Include(x => x.UserBets)
						.Include(x => x.Events)
						.Include(x => x.TypeOfBets)
						.Where(x => (x).IdEvent == IdEvents)
						.ToList();

                    foreach (var item in list1)
                    {
						item.Events.Teams = db.Teams.Find(item.Events.IdTeam1);
						item.Events.Teams1 = db.Teams.Find(item.Events.IdTeam2);
					}
				});

				list1.ForEach(x => list.Add(x));
			}
		}

		public async Task SearchAsync(ICollection<object> list, Func<object, bool> func)
		{
			if (func is null)
				throw new ArgumentNullException(nameof(func));

			using (var db = new DBContext())
			{
				var list1 = new List<PossibleBets>();

				await Task.Run(() => {
					list1 = db.PossibleBets
						.Include(x => x.UserBets)
						.Include(x => x.Events)
						.Include(x => x.TypeOfBets)
						.Where(func)
						.Cast<PossibleBets>()
						.ToList();

					list.Clear();
					list1.ForEach(x => list.Add(x));

					list = list.Where(x => ((PossibleBets)x).IdEvent == IdEvents).ToList();

					foreach (PossibleBets item in list)
					{
						item.Events.Teams = db.Teams.Find(item.Events.IdTeam1);
						item.Events.Teams1 = db.Teams.Find(item.Events.IdTeam2);
					}
				});
			}
		}

		public async Task SearchAsync(ICollection<object> list, List<Func<object, bool>> listFunc)
		{
			if (listFunc is null)
				throw new ArgumentNullException(nameof(listFunc));

			if (listFunc.Count() < 1)
			{
				await GetDataAsync(list);
				return;
			}

			using (var db = new DBContext())
			{
				IEnumerable<PossibleBets> list1 = null;

				await Task.Run(() => {
					list1 = db.PossibleBets
						.Include(x => x.UserBets)
						.Include(x => x.Events)
						.Include(x => x.TypeOfBets)
						.ToList();

					listFunc.ForEach(x => list1 = list1.Where(x).Cast<PossibleBets>());

					list.Clear();
					list1.ToList().ForEach(x => list.Add(x));
					list.Where(x => ((PossibleBets)x).IdEvent == IdEvents);
					
					foreach (PossibleBets item in list)
					{
						item.Events.Teams = db.Teams.Find(item.Events.IdTeam1);
						item.Events.Teams1 = db.Teams.Find(item.Events.IdTeam2);
					}
				});
			}
		}
	}
}
