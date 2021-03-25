using System;
using System.Collections.Generic;

#nullable disable

namespace Test
{
    public partial class Operator
    {
        public Operator()
        {
            MoneyManagements = new HashSet<MoneyManagement>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }

        public virtual ICollection<MoneyManagement> MoneyManagements { get; set; }
    }
}
