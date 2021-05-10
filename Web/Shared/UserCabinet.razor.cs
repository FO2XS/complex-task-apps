using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.ModalEntity;
using Microsoft.AspNetCore.Components;

namespace Test.Shared
{
    public partial class UserCabinet
    {
        [CascadingParameter]
        public User User { get; set; }

    }
}
