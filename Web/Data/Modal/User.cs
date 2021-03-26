using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Modal
{
    public partial class User
    {
        public User()
        {
            MoneyManagements = new HashSet<MoneyManagement>();
            UsersBets = new HashSet<UsersBet>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Balance { get; set; }

        public virtual ICollection<MoneyManagement> MoneyManagements { get; set; }
        public virtual ICollection<UsersBet> UsersBets { get; set; }
    }
}
