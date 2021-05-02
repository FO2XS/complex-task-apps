using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Test.Pages.PopUpWindows
{
    public partial class LogOut
    {
        [CascadingParameter]
        MudDialogInstance MudDialog { get; set; }


        private void Cancel() => MudDialog.Cancel();

        private bool Submit()
        {
            try
            {
                ClearLocalStorage();
                ClearSessionStorage();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private async void ClearLocalStorage()
        {
            await _localStorage.ClearAsync();
        }

        private async void ClearSessionStorage()
        {
            await _sessionStorage.ClearAsync();
        }
    }
}
