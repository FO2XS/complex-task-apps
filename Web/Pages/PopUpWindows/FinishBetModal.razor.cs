using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Test.Data;
using Test.Data.ModalEntity;

namespace Test.Pages.PopUpWindows
{
    public partial class FinishBetModal
    {
        [CascadingParameter]
        private MudDialogInstance MudDialog { get; set; }
        private User refreshUser;
        [Parameter]
        public Team SelectedTeam { get; set; }
        [Parameter]
        public PossibleBet SelectedBet { get; set; }
        [Parameter]
        public float SelectedCoef { get; set; }
        [Parameter]
        public bool Side { get; set; }
        private decimal? _sum;

        protected override async void OnInitialized()
        {
            //Получаем свежие данные с серва
            refreshUser = await _sessionStorage.GetItemAsync<User>(StorageKeys.SessionKey);
            if(refreshUser is null) return;
            refreshUser = UserService.GetUser(refreshUser.Id);
            StateHasChanged();
        }

        private decimal? CalculatePrize(decimal? sum, float coef)
        {
            return sum * Convert.ToDecimal(coef);
        }

        private void MakeBet()
        {
            
            SelectedBet = BetsService.GetPossibleBet(SelectedBet.Id);
            //


            if (SelectedBet.IsAvalaible is not true)
            {
                _snackBar.Add("Данная ставка в настоящее время недоступна");
                return;
            }

            if (_sum is null)
            {
                _snackBar.Add("Введите сумму");
                return;
            }
            else if (_sum < SelectedBet.Min)
            {
                _snackBar.Add("Введенная сумма меньше минимальной ставки");
                return;
            }
            else if (_sum > SelectedBet.Max)
            {
                _snackBar.Add("Введенная сумма больше максимальной допустимой ставки");
                return;
            }
            if (refreshUser.Balance < _sum)
            {
                _snackBar.Add("На кошельке не достаточно средств");
                return;
            }

            var result = BetsService.AddUserBet(refreshUser, SelectedBet, Side, SelectedCoef, (decimal)_sum);

            if (result)
            {
                MudDialog.Close(DialogResult.Ok(true));
            }
        }
    }
}
