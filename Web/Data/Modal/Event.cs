using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Modal
{
    public partial class Event
    {
        public Event()
        {
            PossibleBets = new HashSet<PossibleBet>();
        }

        public int Id { get; set; }
        public int IdSport { get; set; }
        public int IdTeam1 { get; set; }
        public int IdTeam2 { get; set; }
        public DateTime? StartDate { get; set; }
        public int? IdWin { get; set; }
        public int? IdLose { get; set; }
        public bool? IsPast { get; set; }
        public bool? ToArchive { get; set; }

        public virtual Sport IdSportNavigation { get; set; }
        public virtual Team IdTeam1Navigation { get; set; }
        public virtual Team IdTeam2Navigation { get; set; }
        public virtual ICollection<PossibleBet> PossibleBets { get; set; }
    }
}
