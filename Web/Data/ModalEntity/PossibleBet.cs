using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class PossibleBet
    {
        public PossibleBet()
        {
            UserBets = new HashSet<UserBet>();
        }

        public int Id { get; set; }
        public int IdEvent { get; set; }
        public int IdTob { get; set; }
        public float Coef1 { get; set; }
        public float Coef2 { get; set; }
        public decimal Min { get; set; }
        public decimal? Max { get; set; }
        public bool IsAvalaible { get; set; }
        public float? Margin { get; set; }
        public bool IsPast { get; set; }
        public bool ToArchive { get; set; }
        public bool? Winner { get; set; }

        public virtual Event IdEventNavigation { get; set; }
        public virtual TypeOfBet IdTobNavigation { get; set; }
        public virtual ICollection<UserBet> UserBets { get; set; }
    }
}
