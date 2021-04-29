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
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;

namespace Test.Pages
{
    public partial class AuthenticationModal : ComponentBase
    {
        private string login = "Test2@mail.ru";
        private string password = "Qwerty123.";
        private bool rememberMe = false;
        string error = null;
        private bool showSignInError = false;



        public async Task AutheticationUser()
        {
            var user = await UserManager.FindByEmailAsync(login);
            if (user is null)
            {
                error = "Пользователя нет";
                return;
            }
            if (await signInManager.CanSignInAsync(user))
            {
                //var result = await signInManager.CheckPasswordSignInAsync(user, password, lockoutOnFailure: false);
                await signInManager.SignInAsync(user, false);

            }
        }

        private async Task RegisterUser()
        {
            var user = await UserManager.FindByEmailAsync(login);

            if (user != null && await UserManager.CheckPasswordAsync(user, password))
            {
                showSignInError = false;

                var token = await UserManager.GenerateUserTokenAsync(user, TokenOptions.DefaultProvider, "SignIn");

                var data = $"{user.Id}|{token}";

                var parsedQuery = System.Web.HttpUtility.ParseQueryString(new Uri(manager.Uri).Query);

                var returnUrl = parsedQuery["returnUrl"];

                if (!string.IsNullOrWhiteSpace(returnUrl))
                {
                    data += $"|{returnUrl}";
                }

                var protector = dataProtectionProvider.CreateProtector("SignIn");

                var pdata = protector.Protect(data);

                manager.NavigateTo("/?t=" + pdata, forceLoad: true);
            }
            else
            {
                showSignInError = true;
            }
        }
    }
}
