using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DesktopBookmaker.Data;
using InterfaceView;
using InterfaceView.Control;

namespace DesktopBokmeyker.View.Control
{
    class TeamsControl
        : IControl
    {
        /// <summary>
        /// Отправляет запрос в базу данных на добавление переданной команды.
        /// </summary>
        /// <param name="ob">Приведенный к типу object объект Teams</param>
        /// <returns></returns>
        public async Task AddAsync(object ob)
        {
            
            try
            {
                var newTeam = ob as Teams;

                if (newTeam is null)
                    throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(Teams)}");

                var context = new DBContext();

                context.Teams.Add(newTeam);

                await context.SaveChangesAsync();
            }
            catch (ExceptionForUser)
            {
                throw;
            }
        }
        /// <summary>
        /// Отправляет запрос в базу данных на пометку выбранной команды как удаленной
        /// </summary>
        /// <param name="ob">Приведенный к типу object объект Teams</param>
        /// <returns></returns>
        public async Task DeleteAsync(object ob)
        {
            try
            {
                var team = ob as Teams;

                if (team is null)
                    throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(Teams)}");

                var DB = new DBContext();

                team = await DB.Teams.FindAsync(team.Id);

                //matches это коллекции настоящих или будущих матчей с участием выбранной команды
                var matchesOne = team.Events.Where(ev => !ev.IsPast);
                var matchesTwo = team.Events1.Where(ev => !ev.IsPast);

                if (matchesOne is null || matchesTwo is null)
                {
                    throw new ExceptionForUser(
                        "Удалить команду нельзя: имеются актуальные матчи с участием этой команды");
                }

                team.Title = "УДАЛЕНО";

                DB.Entry(team).State = EntityState.Modified;

                await DB.SaveChangesAsync();
            }
            catch (ExceptionForUser)
            {
                throw;
            }
        }
        /// <summary>
        /// Отправляет запрос в базу данных на пометку выбранной команды как удаленной
        /// </summary>
        /// <param name="id">ID команды</param>
        /// <returns></returns>
        public async Task DeleteAsync(int id)
        {
            try
            {
                if (id < 1)
                    throw new Exception($"id < 1, где id = {id}");
                var DB = new DBContext();

                var team = await DB.Teams.FindAsync(id);

                //matches это коллекции настоящих или будущих матчей с участием выбранной команды
                var matchesOne = team.Events.Where(ev => !ev.IsPast);
                var matchesTwo = team.Events1.Where(ev => !ev.IsPast);

                if (matchesOne is null || matchesTwo is null)
                {
                    throw new ExceptionForUser(
                        "Удалить команду нельзя: имеются актуальные матчи с участием этой команды");
                }

                team.Title = "УДАЛЕНО";

                DB.Entry(team).State = EntityState.Modified;

                await DB.SaveChangesAsync();
            }
            catch (ExceptionForUser)
            {
                throw;
            }
        }
        /// <summary>
        /// Отправляет запрос в базу данных на изменение информации о команде
        /// </summary>
        /// <param name="ob">Приведенный к типу object объект Teams</param>
        /// <returns></returns>
        public async Task EditAsync(object ob)
        {
            try
            {
                var team = ob as Teams;

                if (team is null)
                    throw new Exception($"Не удалось привести {nameof(ob)} к типу {nameof(Teams)}");

                var DB = new DBContext();

                team = await DB.Teams.FindAsync(team.Id);


                DB.Entry(team).State = EntityState.Modified;

                await DB.SaveChangesAsync();
            }
            catch (ExceptionForUser)
            {
                throw;
            }
        }

        public async Task GetDataAsync(ICollection<object> list)
        {
            if (list is null) list = new List<object>();

            if (list.Count > 0)
            {
                list.Clear();
            }

            using (var db = new DBContext())
            {
                var list1 = new List<Teams>();

                await Task.Run(() =>
                {
                    list1 = db.Teams
                        .Include(x => x.Events)
                        .Include(x => x.Events1)
                        .Include(x => x.Sports)
                        .ToList();
                });

                list1.ForEach(x => list.Add(x));
            }
        }

        public async Task SearchAsync(ICollection<object> list, Func<object, bool> func)
        {
            if (func is null)
                throw new ArgumentNullException(nameof(func));

            var list1 = new List<Teams>();

            using (var db = new DBContext())
            {
                await Task.Run(() =>
                {
                    list1 = db.Teams
                        .Include(x => x.Events)
                        .Include(x => x.Events1)
                        .Include(x => x.Sports)
                        .Where(func)
                        .Select(x => (Teams) x)
                        .ToList();

                    list = new List<object>();
                    list1.ForEach(x => list.Add(x));
                });
            }
        }

        public async Task SearchAsync(ICollection<object> list, List<Func<object, bool>> listFunc)
        {
            if (listFunc is null)
                throw new ArgumentNullException(nameof(listFunc));

            if (!listFunc.Any())
            {
                await GetDataAsync(list);
                return;
            }

            using (var db = new DBContext())
            {
                IEnumerable<Teams> list1;

                await Task.Run(() => {
                    list1 = db.Teams
                        .Include(x => x.Events)
                        .Include(x => x.Events1)
                        .Include(x => x.Sports)
                        .ToList();

                    listFunc.ForEach(x => list1 = list1.Where(x).Cast<Teams>());

                    list.Clear();
                    list1.ToList().ForEach(list.Add);
                });
            }
        }
    }
}
