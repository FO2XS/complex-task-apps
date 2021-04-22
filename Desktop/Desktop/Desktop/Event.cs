using System;
using System.Collections.Generic;

namespace Test.Data.Modal
{
    public partial class Events
    {
        public Events() { }

        public int Id { get; set; }
        public int Id_Sport { get; set; }
        public int Id_Team1 { get; set; }
        public int Id_Team2 { get; set; }
        public DateTime? Start_Date { get; set; }
        public int? Id_Win { get; set; }
        public int? Id_Lose { get; set; }
        public bool? Is_Past { get; set; }
        public bool? To_Archive { get; set; }

        public override string ToString()
        {
            return $"{Id}";
        }
    }
}
