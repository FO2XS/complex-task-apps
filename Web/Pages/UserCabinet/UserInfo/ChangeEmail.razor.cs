using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Test.Shared;
using static System.String;

namespace Test.Pages.UserCabinet.UserInfo
{
    public partial class ChangeEmail
    {
        [CascadingParameter]
        private MainLayout mainLayout { get; set; }

        private string currentEmail;
        private string newEmail;
        private string repeatNewEmail;


        private async void OnClick()
        {
            try
            {
                if (mainLayout.loginUser.NormalizedEmail != currentEmail.ToUpper() || !ValidationEmail()) return;

                var token = await _manager.GenerateChangeEmailTokenAsync(mainLayout.loginUser, newEmail);

                if (token is null) return;
                var result = await _manager.ChangeEmailAsync(mainLayout.loginUser, newEmail, token);

                if (!result.Succeeded)
                {
                    _snackbar.Add("Почта не обновлена, повторите попытку позже");
                    return;
                }
                _snackbar.Add("Почта успешно обновлена");
            }
            catch
            {
                _snackbar.Add("Что-то пошло не так, повторите попытку позже");
            }

        }


        private bool ValidationEmail()
        {
            //Здесь нужно проверить корректность введенной почты
            return newEmail is not null 
                   && String.Equals(newEmail, repeatNewEmail, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
