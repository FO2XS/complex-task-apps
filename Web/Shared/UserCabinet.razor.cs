using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.ModalEntity;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using MudBlazor;
using Test.Pages.PopUpWindows;

namespace Test.Shared
{
    public partial class UserCabinet
    {
        [CascadingParameter]
        public User User { get; set; }
        
    }
}
