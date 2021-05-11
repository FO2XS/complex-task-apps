using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Test.Data.ModalEntity;

namespace Test.Pages.PopUpWindows
{
    public partial class FinishBetModal
    {
        [CascadingParameter]
        private MudDialogInstance MudDialog { get; set; }
        [Parameter]
        public Team SelectedTeam { get; set; }
        [Parameter]
        public PossibleBet SelectedBet { get; set; }
        [Parameter]
        public float SelectedCoef { get; set; }

        private decimal? _sum;


        private decimal? CalculatePrize(decimal? sum, float coef)
        {
            return sum * Convert.ToDecimal(coef);
        }


        private void MakeBet()
        {

        }
    }
}
