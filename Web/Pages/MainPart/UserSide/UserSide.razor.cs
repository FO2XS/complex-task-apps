using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Test.Data;
using Test.Data.ModalEntity;

namespace Test.Pages.MainPart.UserSide
{
    public partial class UserSide
    {
        [Parameter] public User User { get; set; }
        private FormattingUserBets _formatting;
        private HashSet<FormatUserBets> _formatUserBets;

        protected override void OnParametersSet()
        {
            if (User is null) return;
            User.UserBets = webService.GetUserBets(User);
            _formatUserBets = _formatting.Format(User.UserBets);

        }

        protected override void OnInitialized()
        {
            _formatting = new FormattingUserBets();
        }
    }
}
