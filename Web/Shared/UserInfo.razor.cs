using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Test.Shared
{
    public partial class UserInfo
    {
        [CascadingParameter] 
        private MainLayout mainLayout { get; set; }

    }
}
