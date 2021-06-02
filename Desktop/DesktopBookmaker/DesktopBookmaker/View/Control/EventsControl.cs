using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceView.Control;
using InterfaceView;
using System.Data.Entity;
using DesktopBookmaker.Data;

namespace DesktopBookmaker.View.Control
{
    public class EventsControl
        : IControl
    {
        public void Add(Object ob)
        {
            try
            {
                var event1 = ob as Events;

                if (event1 is null)
                    throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(Events)}");

                var DB = new DBContext();

                DB.Events.Add(event1);

                DB.SaveChanges();
            }
            catch (ExceptionForUser)
            {
                throw;
            }
        }

        public async Task AddAsync(Object ob)
        {
            try
            {
                var event1 = ob as Events;

                if (event1 is null)
                    throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(Events)}");

                var event2 = new Events
                {
                    IdSport = event1.IdSport,
                    IdTeam1 = event1.IdTeam1,
                    IdTeam2 = event1.IdTeam2,
                    Winner = event1.Winner,
                    IsPast = event1.IsPast,
                    ToArchive = event1.ToArchive,
                    StartDate = event1.StartDate,
                    IdTournament = event1.IdTournament
                };

                var DB = new DBContext();

                DB.Events.Add(event2);

                await DB.SaveChangesAsync();

                DB.Entry(event2);
                event1.Id = event2.Id;
            }
            catch (ExceptionForUser ex)
            {
                throw;
            }
        }

        public void Edit(Object ob)
        {
            try
            {
                var event1 = ob as Events;

                if (event1 is null)
                    throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(Events)}");

                var DB = new DBContext();

                var event2 = DB.Events.Find(event1.Id);

                event2.IdSport = event1.IdSport;
                event2.IdTeam1 = event1.IdTeam1;
                event2.IdTeam2 = event1.IdTeam2;
                event2.Winner = event1.Winner;
                event2.IsPast = event1.IsPast;
                event2.ToArchive = event1.ToArchive;
                event2.StartDate = event1.StartDate;
                event2.IsAvailable = event1.IsAvailable;

                DB.SaveChanges();
            }
            catch (ExceptionForUser)
            {
                throw;
            }
        }

        public async Task EditAsync(Object ob)
        {
            try
            {
                var event1 = ob as Events;

                if (event1 is null)
                    throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(Events)}");

                var DB = new DBContext();

                var d = DB.Tournaments.ToArray();

                var event2 = await DB.Events.FindAsync(event1.Id);

                event2.IdSport = event1.IdSport;
                event2.IdTeam1 = event1.IdTeam1;
                event2.IdTeam2 = event1.IdTeam2;
                event2.Winner = event1.Winner;
                event2.IsPast = event1.IsPast;
                event2.ToArchive = event1.ToArchive;
                event2.StartDate = event1.StartDate;
                event2.IsAvailable = event1.IsAvailable;
                event2.IdTournament = event1.IdTournament;

                /// DB.Entry<Events>(event2).State = EntityState.Modified;

                await DB.SaveChangesAsync();
            }
            catch (ExceptionForUser)
            {
                throw;
            }
        }

        public void Delete(Object ob)
        {
            try
            {
                var event1 = ob as Events;

                if (event1 is null)
                    throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(Events)}");

                var DB = new DBContext();

                DB.Events.Remove(event1);

                DB.SaveChanges();
            }
            catch (ExceptionForUser)
            {
                throw;
            }
        }

        public void Delete(Int32 id)
        {
            try
            {
                if (id < 0)
                    throw new Exception($"id < 0, где id = {id}");

                var DB = new DBContext();

                DB.Events.Remove(new Events() { Id = id });

                DB.SaveChanges();
            }
            catch (ExceptionForUser)
            {
                throw;
            }
        }

        public async Task DeleteAsync(object ob)
        {
            try
            {
                var event1 = ob as Events;

                if (event1 is null)
                    throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(Events)}");

                var DB = new DBContext();

                var ev = await DB.Events.FindAsync(event1.Id);

                if (ev.IsPast)
                    throw new ExceptionForUser("Нельзя удалить событие, т.к. расчитаны ставки на матч!", "Ошибка удаления");

                Int32 d = ev.PossibleBets.Count();

                for (int i = 0; i < d; i++)
                {
                    var possibleBets = ev.PossibleBets.First();

                    if (possibleBets.UserBets.Count() > 0)
                        throw new ExceptionForUser("Нельзя удалить событие, на котором есть пользовательские ставки!", "Ошибка удаления");

                    DB.PossibleBets.Remove(possibleBets);
                }

                DB.Events.Remove(ev);

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
                if (id < 0)
                    throw new Exception($"id < 0, где id = {id}");

                var DB = new DBContext();

                DB.Events.Remove(new Events() { Id = id });

                await DB.SaveChangesAsync();
            }
            catch (ExceptionForUser)
            {
                throw;
            }
        }

        public ICollection<Object> GetData()
        {
            using (var db = new DBContext())
            {
                var list = db.Events
                    .Include(x => x.Teams)
                    .Include(x => x.Teams1)
                    .Include(x => x.Sports)
                    .ToArray();

                return list;
            }
        }

        public async Task GetDataAsync(ICollection<Object> list)
        {
            if (list is null )
                list = new List<Object>();

            if (list.Count > 0)
                list.Clear();

            using (var db = new DBContext())
            {
                var list1 = new List<Events>();

                await Task.Run(() => {
                    list1 = db.Events
                        .Include(x => x.Teams)
                        .Include(x => x.Teams1)
                        .Include(x => x.Sports)
                        .Include(x => x.Tournaments)
                        .ToList();
                     });

                list1.ForEach(x => list.Add(x));
            }
        }

        public ICollection<Object> Search(Func<Object, Boolean> func)
        {
            using (var db = new DBContext())
            {
                return db.Events.Include(x => x.Teams)
                    .Include(x => x.Teams1)
                    .Include(x => x.Sports)
                    .Include(x => x.Tournaments)
                    .Where(func)
                    .ToList();
            }
        }

        public async Task SearchAsync(ICollection<Object> list, Func<Object, Boolean> func)
        {
            if (list is null)
                throw new ArgumentNullException(nameof(list));

            if (func is null)
                throw new ArgumentNullException(nameof(func));

            using (var db = new DBContext())
            {
                var list1 = new List<Events>();

                await Task.Run(() => {
                    list1 = db.Events
                        .Include(x => x.Teams)
                        .Include(x => x.Teams1)
                        .Include(x => x.Sports)
                        .Include(x => x.Tournaments)
                        .Where(func)
                        .Select(x => (Events)x)
                        .ToList();

                    list.Clear();
                    list1.ForEach(x => list.Add(x));
                });
            }
        }

        public async Task SearchAsync(ICollection<object> list, List<Func<object, bool>> listFunc)
        {
            if (list is null)
                throw new ArgumentNullException(nameof(list));

            if (listFunc is null)
                throw new ArgumentNullException(nameof(listFunc));

            if (listFunc.Count() < 1)
            {
                await GetDataAsync(list);
                return;
            }

            using (var db = new DBContext())
            {
                IEnumerable<Events> list1 = null;

                await Task.Run(() => {
                    list1 = db.Events
                        .Include(x => x.Teams)
                        .Include(x => x.Teams1)
                        .Include(x => x.Sports)
                        .Include(x => x.Tournaments)
                        .ToList();

                    listFunc.ForEach(x => list1 = list1.Where(x).Cast<Events>());

                    list.Clear();
                    list1.ToList().ForEach(x => list.Add(x));
                });
            }
        }
    }
}
