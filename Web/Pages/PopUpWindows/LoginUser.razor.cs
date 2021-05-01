using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.ModalEntity;

namespace Test.Pages.PopUpWindows
{
    public partial class LoginUser
    {
        private string mail = "Test2@mail.ru";
        private string password = "Qwerty123.";
        private bool rememberMe = false;
        string error = null;
        private bool showSignInError = false;
        string key = "userInfo";



        public async Task<bool> loginUser()
        {
            var user = await userManager.FindByEmailAsync(mail);

            
            if (user is null)
            {
                ErrorMessage("Такого пользователя нет");
                return false;
            }
            if (await signInManager.CanSignInAsync(user))
            {
                var result = await signInManager.CheckPasswordSignInAsync(user, password, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    SaveLocalStorage(user);
                    SuccessMessage("Добро пожаловать");
                    
                    return true;
                }
                else
                {
                    ErrorMessage("Пароль введён некорректно");
                    return false;
                }
            }
            return false;
        }

        public async void SaveLocalStorage(User user)
        {
            await localStorage.SetItemAsync(key, user);
        }
        public async void ClearLocalStorage()
        {
            await localStorage.ClearAsync();
        }


        public void ErrorMessage(string message)
        {
            snackBar.Add(message, MudBlazor.Severity.Error);
        }
        public void SuccessMessage(string message)
        {
            snackBar.Add(message, MudBlazor.Severity.Success);
        }
    }
}
