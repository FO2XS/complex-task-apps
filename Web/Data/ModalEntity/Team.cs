using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class Team
    {
        public Team()
        {
            EventIdTeam1Navigations = new HashSet<Event>();
            EventIdTeam2Navigations = new HashSet<Event>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? Raiting { get; set; }
        public float? PercentWin { get; set; }
        public string SquadList { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<Event> EventIdTeam1Navigations { get; set; }
        public virtual ICollection<Event> EventIdTeam2Navigations { get; set; }
    }
}
