using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test.Data.ModalEntity;

namespace Test.Data
{
    public static class EventService
    {

        public static HashSet<Event> GetEvents(Sport sport)
        {
            using var _context = new BookmakerContext();
            return _context.Events
                .Where(n => n.IdSport == sport.Id)
                .Include(team1 => team1.IdTeam1Navigation)
                .Include(team2 => team2.IdTeam2Navigation)
                .Include(x => x.PossibleBets)
                .ToHashSet();
        }

        public static IEnumerable<Event> SelectEvents(this IEnumerable<Event> collection, Func<Event, bool> wFunc)
        {
            return collection.Where(wFunc).ToHashSet();
        }
    }
}
