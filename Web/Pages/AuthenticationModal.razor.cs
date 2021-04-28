using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Test.Data.ModalEntity;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authentication;

namespace Test.Pages
{
    public partial class AuthenticationModal
    {
        private string login;
        private string password;
        private bool rememberMe = false;
        string error = null;


        public async Task AutheticationUser()
        {
            var user = await UserManager.FindByEmailAsync(login);
            if (user is null)
            {
                error = "Пользователя нет";
                return;
            }
            
            if(await signInManager.CanSignInAsync(user))
            {
                var result = await signInManager.CheckPasswordSignInAsync(user, password, lockoutOnFailure: false);

                if (result == SignInResult.Success)
                {
                    error = "Ты смог пройти";
                }
                else
                    error = "Ошибка при авторизации";
            }
            
            
        }
    }
}
