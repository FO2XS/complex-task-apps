using System;
using System.Collections.Generic;

#nullable disable

namespace Test
{
    public partial class TypeOfBet
    {
        public TypeOfBet()
        {
            PossibleBets = new HashSet<PossibleBet>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<PossibleBet> PossibleBets { get; set; }
    }
}
