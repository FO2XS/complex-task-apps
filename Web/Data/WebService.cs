using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.ModalEntity;

namespace Test.Data
{
    public class WebService
    {
        private BookmakerContext _context;
        /// <summary>
        /// Возвращает список всех матчей по указанному виду спорта.
        /// </summary>
        /// <param name="sport">Вид спорта</param>
        /// <returns>Список матчей с включенными объектами Team.</returns>
        public List<Event> GetEvents(Sport sport)
        {
            using (_context = new BookmakerContext())
            {
                return _context.Events
                    .Where(n => n.IdSport == sport.Id)
                    .Include(team1 => team1.IdTeam1Navigation)
                    .Include(team2 => team2.IdTeam2Navigation)
                    .ToList();

            }
        }

        public HashSet<Event> GetEvents(IEnumerable<int> eventsId)
        {
            using (_context = new BookmakerContext())
            {
                return _context.Events
                    .Where(e => eventsId.Contains(e.Id))
                    .ToHashSet();
            }
        }
        /// <summary>
        /// Возвращает список всех доступных ставок по данному событию.
        /// </summary>
        /// <param name="event">Матч</param>
        /// <returns>Список возможных ставок с включенным объектом TypeOfBet.</returns>
        public List<PossibleBet> GetPossibleBets(Event @event)
        {
            using (_context = new BookmakerContext())
            {
                return _context.PossibleBets
                    .Where(n => n.IdEvent == @event.Id)
                    .Where(n => n.IsAvalaible == true)
                    .Include(tob => tob.IdTobNavigation)
                    .ToList();
            }
        }
        /// <summary>
        /// Возвращает список указанных доступных ставок по данному событию.
        /// </summary>
        /// <param name="betsId">Id нужных типов ставок</param>
        /// <returns>Список возможных ставок с указанными Id</returns>
        public HashSet<PossibleBet> GetPossibleBets(IEnumerable<int> betsId)
        {
            using (_context = new BookmakerContext())
            {
                return _context.PossibleBets
                    .Where(e => betsId.Contains(e.Id))
                    .ToHashSet();
            }
        }

        public ICollection<UserBet> GetUserBets(User user)
        {
            using (_context = new BookmakerContext())
            {
                return _context.UserBets
                    .Where(e => e.IdUser == user.Id).ToList();
            }
        }
        /// <summary>
        /// В настоящее время возвращает Null. В будущем будет возвращать список горячих матчей.
        /// </summary>
        /// <param name="sport">Вид спорта</param>
        /// <returns>Возвращает null</returns>
        public List<Event> GetHotEvents(Sport sport)
        {
            return null; // Нужно в БД сделать формирование этого списка, а здесь только обращаться и получать.
        }

        /// <summary>
        /// Возвращает список начавшихся, но не завершенных матчей
        /// </summary>
        /// <param name="sport">Вид спорта</param>
        /// <returns>Список матчей с включенными объектами Team.</returns>
        public List<Event> GetCurrentEvents(Sport sport)
        {
            using (_context = new BookmakerContext())
            {
                return _context.Events
                    .Where(a => a.IdSport == sport.Id)
                    .Where(a => a.StartDate <= DateTime.Now)
                    .Where(a => a.IsPast != true)
                    .Include(team1 => team1.IdTeam1Navigation)
                    .Include(team2 => team2.IdTeam2Navigation)
                    .Include(x => x.PossibleBets)
                    .ToList();
            }


        }
        /// <summary>
        /// Возвращает список предстоящих матчей.
        /// </summary>
        /// <param name="sport">Вид спорта</param>
        /// <returns>Список матчей с включенными объектами Team.</returns>
        public List<Event> GetFutureEvents(Sport sport)
        {
            using (_context = new BookmakerContext())
            {
                return _context.Events
                    .Where(a => a.IdSport == sport.Id)
                    .Where(a => a.StartDate > DateTime.Now)
                    .Include(team1 => team1.IdTeam1Navigation)
                    .Include(team2 => team2.IdTeam2Navigation)
                    .ToList();
            }
        }

        public List<Event> GetAllFutureAndCurrentEvents()
        {
            using (_context = new BookmakerContext())
            {
                return _context.Events
                    .Where(e => e.IsPast == false)
                    .ToList();
            }
        }
        /// <summary>
        /// Возвращает список прошедших матчей.
        /// </summary>
        /// <param name="sport">Вид спорта</param>
        /// <returns>Список матчей с включенными объектами Team.</returns>
        public List<Event> GetPastEvents(Sport sport)
        {
            using (_context = new BookmakerContext())
            {
                return _context.Events
                    .Where(a => a.IdSport == sport.Id)
                    .Where(a => a.IsPast == true) // проверка на "прошлость" события осуществляется только по лог. типу. Дата не учитывается
                    .Include(team1 => team1.IdTeam1Navigation)
                    .Include(team2 => team2.IdTeam2Navigation)
                    .ToList();
            }
        }

        public string UploadUserAvatar(User user)
        {
            return null;
        }

        public HashSet<TypeOfBet> GetTypeOfBets()
        {
            using (_context = new BookmakerContext())
            {
                return _context.TypeOfBets.ToHashSet();
            }
        }

        public HashSet<Team> GetTeams()
        {
            using (_context = new BookmakerContext())
            {
                return _context.Teams.ToHashSet();
            }
        }

    }
}