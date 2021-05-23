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
            using var context = new BookmakerContext();
            return context.Events
                .Where(n => n.IdSport == sport.Id)
                .Include(team1 => team1.IdTeam1Navigation)
                .Include(team2 => team2.IdTeam2Navigation)
                .Include(x => x.PossibleBets)
                .Include(tour => tour.IdTournamentNavigation)
                .ToHashSet();
        }

        public static IEnumerable<Event> SelectEvents(this IEnumerable<Event> collection, Func<Event, bool> wFunc)
        {
            return collection.Where(wFunc).ToHashSet();
        }

        public static IEnumerable<Sport> GetSports()
        {
            using var context = new BookmakerContext();

            return context.Sports.ToHashSet();
        }
    }
}
