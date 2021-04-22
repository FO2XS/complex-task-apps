using System;
using System.Collections.Generic;

namespace Test.Data.Modal
{
    public partial class Teams
    {
        public Teams() { }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? Raiting { get; set; }
        public float? percent_win { get; set; }
        public string Squadlist { get; set; }
        public string Logo { get; set; }

        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
