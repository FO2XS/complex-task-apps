using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Test.Pages.PopUpWindows
{
    public partial class CustomPopUp
    {
        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }

        [Parameter] public string Content { get; set; }
        [Parameter] public string ContentAcceptButton { get; set; } = "Принять";


        private void Accept()
        {
            MudDialog.Close(DialogResult.Ok(true));
        }
    }
}
