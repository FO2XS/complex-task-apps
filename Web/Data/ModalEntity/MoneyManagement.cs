using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class MoneyManagement
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdOperator { get; set; }
        public bool TakeOrAdd { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }

        public virtual Operator IdOperatorNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
