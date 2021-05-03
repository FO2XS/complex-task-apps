using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Test.Data.ModalEntity;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Test.Pages.PopUpWindows;

namespace Test.Pages
{
    public partial class RegistrationNewUser
    {
        
        private SignInManager<User> _signInManager;
        private string _email;
        private string _password;
        private string _verifyPassword;


        private async void CreateUser()
        {
            var user = new User { UserName = _email, Email = _email };
            var result = await _userManager.CreateAsync(user, _password);

            if (result.Succeeded)
            {
                var options = new DialogParameters {["Content"] = "Авторизируйтесь на главной странице",["ContentAcceptButton"] = "Перейти"};
                var dialog = _dialogService.Show<CustomPopUp>("Завершение регистрации", options);
                var result2 = await dialog.Result;
                if (!result2.Cancelled)
                {
                    _manager.NavigateTo("/");
                }
            }
            else
            {
                _snackBar.Add("Ошибка при регистрации, введите другие данные");
            }
        }
    }
}
