using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class Role : IdentityRole<int>
    {
        public Role()
        {
            RoleClaims = new HashSet<RoleClaim>();
            UserRoles = new HashSet<UserRole>();
        }
        

        public virtual ICollection<RoleClaim> RoleClaims { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
