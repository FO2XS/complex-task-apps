using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class User : IdentityUser<int>
    {
        public User()
        {
            MoneyManagements = new HashSet<MoneyManagement>();
            UserBets = new HashSet<UserBet>();
            UserClaims = new HashSet<UserClaim>();
            UserLogins = new HashSet<UserLogin>();
            UserRoles = new HashSet<UserRole>();
            UserTokens = new HashSet<UserToken>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Balance { get; set; }

        public virtual ICollection<MoneyManagement> MoneyManagements { get; set; }
        public virtual ICollection<UserBet> UserBets { get; set; }
        public virtual ICollection<UserClaim> UserClaims { get; set; }
        public virtual ICollection<UserLogin> UserLogins { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserToken> UserTokens { get; set; }


    }
}
