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
        private bool _rememberMe = false;
        string _error = null;
        private bool _showSignInError = false;
        



        [CascadingParameter]
        MudDialogInstance MudDialog { get; set; }

        void Cancel() => MudDialog.Cancel();

        async void Submit()
        {
            var result = await Login();
            if (result)
            {
                MudDialog.Close(DialogResult.Ok(true));
            }
            else
            {
                ErrorMessage("Логин или пароль введены неверно");
            }

        }

        private async Task<bool> Login()
        {
            var user = await _userManager.FindByEmailAsync(_mail);

            if (user is null)
            {
                return false;
            }
            if (!await _signInManager.CanSignInAsync(user)) return false;
            var result = await _signInManager.CheckPasswordSignInAsync(user, _password, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                SaveSessionStorage(user);
                if (_rememberMe)
                {
                    SaveLocalStorage(user);
                    SuccessMessage("Пользователь запомнен");
                }
                SuccessMessage("Добро пожаловать");
                return true;
            }
            else
            {
                return false;
            }
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
