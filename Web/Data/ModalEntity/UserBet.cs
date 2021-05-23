using System;
using System.Collections.Generic;
using System.Collections;

#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class UserBet
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdPosBet { get; set; }
        public bool Side { get; set; }
        public float Coef { get; set; }
        public decimal Sum { get; set; }
        public BitArray Victory { get; set; }
        public decimal? Prize { get; set; }
        public bool ToArchive { get; set; }

        public virtual PossibleBet IdPosBetNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
