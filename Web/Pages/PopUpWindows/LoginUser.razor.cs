using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.ModalEntity;
using Test.Data;

namespace Test.Pages.PopUpWindows
{
    public partial class LoginUser
    {
        private string _mail = "Test2@mail.ru";
        private string _password = "Qwerty123.";
        private bool _rememberMe;
        



        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }

        private void Cancel() => MudDialog.Cancel();

        private async void Submit()
        {
            var result = await Login();
            if (result is not null)
            {
                MudDialog.Close(DialogResult.Ok(result));
            }
            else
            {
                ErrorMessage("Логин или пароль введены неверно");
            }
        }

        private async Task<User> Login()
        {
            var user = await _userManager.FindByEmailAsync(_mail);

            if (user is null) return null;
            if (!await _signInManager.CanSignInAsync(user)) return null;

            var result = await _signInManager.CheckPasswordSignInAsync(user, _password, false);

            if (!result.Succeeded) return null;

            if (_rememberMe)
            {
                SaveLocalStorage(user);
                SuccessMessage("Пользователь запомнен");
            }
            SaveSessionStorage(user);
            SuccessMessage("Добро пожаловать");
            return user;
        }

        private async void SaveLocalStorage(User user)
        {
            await _localStorage.SetItemAsync(StorageKeys.LocalKey, user);
        }


        private async void SaveSessionStorage(User user)
        {
            await _sessionStorage.SetItemAsync(StorageKeys.SessionKey, user);
        }

        private void ErrorMessage(string message)
        {
            _snackBar.Add(message, MudBlazor.Severity.Error);
        }

        private void SuccessMessage(string message)
        {
            _snackBar.Add(message, MudBlazor.Severity.Success);
        }
    }
}
