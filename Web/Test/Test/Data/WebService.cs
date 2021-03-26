using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.Modal;

namespace Test.Data
{
    public class WebService
    {
        /// <summary>
        /// Возвращает список матчей по указанному виду спорта
        /// </summary>
        /// <param name="sport"></param>
        /// <returns></returns>
        public List<Event> GetEvents (Sport sport)
        {
            using (bookmaker_officeContext context = new bookmaker_officeContext())
            {
                return context.Events
                    .Where(n => n.IdSport == sport.Id)
                    .Include(team1 => team1.IdTeam1Navigation)
                    .Include(team2 => team2.IdTeam2Navigation)
                    .ToList();
                
            }
        }

        public List<PossibleBet> GetPossibleBets (Event @event)
        {
            using (bookmaker_officeContext context = new bookmaker_officeContext())
            {
                return context.PossibleBets
                    .Where(n => n.IdEvent == @event.Id)
                    .Include(tob => tob.IdTobNavigation)
                    .ToList();
            }
        }
    }
}
