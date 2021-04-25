using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class UserLogin : IdentityUserLogin<int>
    {
       // public string LoginProvider { get; set; }
       // public string ProviderKey { get; set; }
        //public string ProviderDisplayName { get; set; }
        //public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
