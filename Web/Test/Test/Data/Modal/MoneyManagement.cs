using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Modal
{
    public partial class MoneyManagement
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdOper { get; set; }
        public bool TakeOrAdd { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }

        public virtual Operator IdOperNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
