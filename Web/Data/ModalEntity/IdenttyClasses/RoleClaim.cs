using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class RoleClaim : IdentityRoleClaim<int>
    {
       

        public virtual Role Role { get; set; }
    }
}
