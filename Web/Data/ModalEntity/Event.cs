using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class Event
    {
        public Event()
        {
            PossibleBets = new HashSet<PossibleBet>();
        }

        public int Id { get; set; }
        public int IdSport { get; set; }
        public int? IdTournament { get; set; }
        public int IdTeam1 { get; set; }
        public int IdTeam2 { get; set; }
        public DateTime StartDate { get; set; }
        public bool? Winner { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsPast { get; set; }
        public bool ToArchive { get; set; }

        public virtual Sport IdSportNavigation { get; set; }
        public virtual Tournament IdTournamentNavigation { get; set; }
        public virtual Team IdTeam1Navigation { get; set; }
        public virtual Team IdTeam2Navigation { get; set; }
        public virtual ICollection<PossibleBet> PossibleBets { get; set; }
    }
}
