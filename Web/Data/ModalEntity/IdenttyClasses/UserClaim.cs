using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class UserClaim : IdentityUserClaim<int>
    {
        //public int Id { get; set; }
       // public int UserId { get; set; }
        //public string ClaimType { get; set; }
        //public string ClaimValue { get; set; }

        public virtual User User { get; set; }
    }
}
