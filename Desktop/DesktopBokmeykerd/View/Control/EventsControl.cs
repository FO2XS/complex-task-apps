using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceView.Control;
using InterfaceView;
using DesktopBokmeyker.Data;
using System.Data.Entity;
using System.Windows;

namespace DesktopBokmeyker.View.Control
{
    class EventsControl
        : IControl
    {
        public void Add(object ob)
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

        public async Task AddAsync(object ob)
        {
            try
            {
                var event1 = ob as Events;

                if (event1 is null)
                    throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(Events)}");

                var event2 = new Events();

                event2.IdLose = event1.IdLose;
                event2.IdSport = event1.IdSport;
                event2.IdTeam1 = event1.IdTeam1;
                event2.IdTeam2 = event1.IdTeam2;
                event2.IdWin = event1.IdWin;
                event2.IsPast = event1.IsPast;
                event2.ToArchive = event1.ToArchive;
                event2.StartDate = event1.StartDate;

                var DB = new DBContext();

                DB.Events.Add(event2);

                await DB.SaveChangesAsync();
            }
            catch (ExceptionForUser ex)
            {
                throw;
            }
        }

        public void Edit(object ob)
        {
            try
            {
                var event1 = ob as Events;

                if (event1 is null)
                    throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(Events)}");

                var DB = new DBContext();

                var event2 = DB.Events.Find(event1.Id);

                event2.IdLose = event1.IdLose;
                event2.IdSport = event1.IdSport;
                event2.IdTeam1 = event1.IdTeam1;
                event2.IdTeam2 = event1.IdTeam2;
                event2.IdWin = event1.IdWin;
                event2.IsPast = event1.IsPast;
                event2.ToArchive = event1.ToArchive;
                event2.StartDate = event1.StartDate;

                DB.SaveChanges();
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
                var event1 = ob as Events;

                if (event1 is null)
                    throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(Events)}");

                var DB = new DBContext();

                var event2 = await DB.Events.FindAsync(event1.Id);

                event2.IdLose = event1.IdLose;
                event2.IdSport = event1.IdSport;
                event2.IdTeam1 = event1.IdTeam1;
                event2.IdTeam2 = event1.IdTeam2;
                event2.IdWin = event1.IdWin;
                event2.IsPast = event1.IsPast;
                event2.ToArchive = event1.ToArchive;
                event2.StartDate = event1.StartDate;

                /// DB.Entry<Events>(event2).State = EntityState.Modified;

                await DB.SaveChangesAsync();
            }
            catch (ExceptionForUser)
            {
                throw;
            }
        }

        public void Delete(object ob)
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

        public void Delete(int id)
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

                DB.Events.Remove(event1);

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
            using (var db = new DBContext())
            {
                var list1 = new List<Events>();

                await Task.Run(() => {
                    list1 = db.Events
                        .Include(x => x.Teams)
                        .Include(x => x.Teams1)
                        .Include(x => x.Sports)
                        .ToList();
                     });

                list1.ForEach(x => list.Add(x));
            }
        }

        public ICollection<Object> Search(Func<Object, Boolean> func)
        {
            using (var db = new DBContext())
            {
                return db.Events
                    .Include(x => x.Teams)
                    .Include(x => x.Teams1)
                    .Include(x => x.Sports)
                    .Where(func)
                    .ToList();
            }
        }

        public async Task SearchAsync(ICollection<Object> list, Func<Object, Boolean> func)
        {
            using (var db = new DBContext())
            {
                var list1 = new List<Events>();

                await Task.Run(() => {
                    list1 = db.Events
                        .Include(x => x.Teams)
                        .Include(x => x.Teams1)
                        .Include(x => x.Sports)
                        .Where(func)
                        .Select(x => (Events)x)
                        .ToList();
                });

                list1.ForEach(x => list.Add(x));
            }
        }
    }
}
