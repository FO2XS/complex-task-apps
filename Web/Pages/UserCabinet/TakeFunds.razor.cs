﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Test.Data;
using Test.Data.ModalEntity;
using Test.Shared;

namespace Test.Pages.UserCabinet
{
    public partial class TakeFunds
    {
        [CascadingParameter]
        private MainLayout MainLayout { get; set; }

        private decimal _plusMoney = 0;
        private string _bankcard;


        public async void AddClick()
        {
            if (_plusMoney <= 0 || _bankcard is null)
            {
                _snackBar.Add("Введите данные");
                return;
            }
            var operation = MoneyManagement.AddNewOperation(MainLayout.loginUser, true, _plusMoney, _bankcard);
            if (operation is null)
            {
                _snackBar.Add("Перевод осуществить невозможно, проверьте введенные данные");
                return;
            }
            UserService.AddMoneyToUser(MainLayout.loginUser, operation);

            MainLayout.AddLoginUser(await UserService.GetUserAsync(MainLayout.loginUser.Id));

            _snackBar.Add("Деньги успешно выведены");
        }
    }
}
