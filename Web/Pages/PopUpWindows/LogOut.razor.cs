using Microsoft.AspNetCore.Components;
using MudBlazor;
using Test.Data.ModalEntity;

namespace Test.Pages.PopUpWindows
{
    public partial class LogOut
    {
        [CascadingParameter]
        MudDialogInstance MudDialog { get; set; }

        private void Cancel() => MudDialog.Cancel();

        private void Submit()
        {
                ClearLocalStorage();
                ClearSessionStorage();
                _snackBar.Add("Выход осуществлен", Severity.Success);
                MudDialog.Close(DialogResult.Ok(true));
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
