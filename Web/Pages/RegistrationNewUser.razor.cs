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
        
        private SignInManager<User> signInManager;
        private string email;
        private string password;
        private string verifyPassword;


        public async void CreateUser()
        {
            User user = new User { UserName = email, Email = email };
            var result = await userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                Console.WriteLine("Пользователь с паролем добавлен");
                manager.NavigateTo("/");
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
