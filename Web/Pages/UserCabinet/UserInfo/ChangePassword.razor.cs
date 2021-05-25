using Microsoft.AspNetCore.Components;
using Test.Shared;

namespace Test.Pages.UserCabinet.UserInfo
{
    public partial class ChangePassword
    {
        [CascadingParameter]
        private MainLayout mainLayout { get; set; }

        private string currentPassword;
        private string newPassword;
        private string repeatNewPassword;



        public async void OnClick()
        {
            try
            {
                if (newPassword == repeatNewPassword)
                {
                    var result = await _manager.ChangePasswordAsync(mainLayout.loginUser, currentPassword, newPassword);

                    if (result.Succeeded)
                    {
                        _snackbar.Add("Пароль успешно изменен");
                    }
                    else
                    {
                        _snackbar.Add("Старый пароль введен неверно либо новый пароль не удовлетворяет условиям");
                    }
                }
                else
                {
                    _snackbar.Add("Новый пароль и его повторение не совпадают");
                }
            }
            catch
            {
                _snackbar.Add("Что-то пошло не так, повторите попытку позже");
            }
        }
    }
}
