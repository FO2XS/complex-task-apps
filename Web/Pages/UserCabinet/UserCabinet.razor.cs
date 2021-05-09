using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Test.Data;
using Test.Data.ModalEntity;

namespace Test.Pages.UserCabinet
{
    public partial class UserCabinet
    {
        [CascadingParameter] 
        public User User { get; set; }

        
        private ICollection<UserBet> Bets { get; set; }
        
        protected override Task OnParametersSetAsync()
        {
            if (User is not null)
            {
                User.UserBets = webService.GetUserBets(User);
            }
            return base.OnParametersSetAsync();
        }
        

        private void AddBalance()
        {

        }

        private void WithdrawBalance()
        {

        }

        private void ChangePassword()
        {

        }

        private void ChangeEmail()
        {

        }

        private void ChangeNameOrSurname()
        {

        }

        private void DeleteAccount()
        {

        }

        private void LogOut()
        {

        }



    }
}
