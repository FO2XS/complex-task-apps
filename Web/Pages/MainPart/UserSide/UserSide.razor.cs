using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Test.Data.ModalEntity;

namespace Test.Pages.MainPart.UserSide
{
    public partial class UserSide
    {
        [Parameter] public User User { get; set; }
    }
}
