using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class UserRole :IdentityUserRole<int>
    {
        //public int UserId { get; set; }
        //public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
