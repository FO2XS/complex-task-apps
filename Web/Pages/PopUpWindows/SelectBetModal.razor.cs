using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Test.Data.ModalEntity;

namespace Test.Pages.PopUpWindows
{
    public partial class SelectBetModal
    {
        [CascadingParameter]
        private MudDialogInstance MudDialog { get; set; }
        [Parameter]
        public Event CurrentEvent { get; set; }
        private List<PossibleBet> Bets { get; set; }

        protected override void OnParametersSet()
        {
            if (CurrentEvent != null)
            {
                Bets = _service.GetPossibleBets(CurrentEvent);
            }
        }

        private void OpenFinishBetModal(Team team, PossibleBet bet)
        {
            var coef = CurrentEvent.IdTeam1Navigation == team ? bet.Coef1 : bet.Coef2;
            var parameters = new DialogParameters
            {
                {"SelectedTeam", team}, {"SelectedBet", bet}, {"SelectedCoef", coef}
            };
            var result = _dialogService.Show<FinishBetModal>("Заключение ставки", parameters);
        }


        
    }
}
