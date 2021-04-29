using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Modal;

namespace Desktop
{
    public class Match
    {
        public int Id { get; set; }
        public Teams Team1 { get; set; }
        public Teams Team2 { get; set; }

        public String Data { get; set; }
    }
}
