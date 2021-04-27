using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class UserClaim : IdentityUserClaim<int>
    {
       

        public virtual User User { get; set; }
    }
}
