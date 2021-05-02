using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Test.Data.ModalEntity;
using Microsoft.AspNetCore.Components;
namespace Test.Pages
{
    public partial class RegistrationNewUser
    {
        
        private SignInManager<User> _signInManager;
        private string _email;
        private string _password;
        private string _verifyPassword;


        public async void CreateUser()
        {
            User user = new User { UserName = _email, Email = _email };
            var result = await _userManager.CreateAsync(user, _password);

            if (result.Succeeded)
            {
                Console.WriteLine("Пользователь с паролем добавлен");
                _manager.NavigateTo("/");
            }
            else
            {
                foreach(var error in result.Errors)
                {
                    Console.WriteLine(error.Description);
                }
            }
        }
    }
}
