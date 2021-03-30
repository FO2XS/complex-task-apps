// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Test.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\pepos\complex-task-apps\Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\pepos\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\pepos\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\pepos\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\pepos\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\pepos\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\pepos\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\pepos\complex-task-apps\Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\pepos\complex-task-apps\Web\_Imports.razor"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\pepos\complex-task-apps\Web\_Imports.razor"
using Test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\pepos\complex-task-apps\Web\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\pepos\complex-task-apps\Web\Pages\AtiveMatches.razor"
using Data.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\pepos\complex-task-apps\Web\Pages\AtiveMatches.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\pepos\complex-task-apps\Web\Pages\AtiveMatches.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class AtiveMatches : ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\pepos\complex-task-apps\Web\Pages\AtiveMatches.razor"
       
    private BSModal VerticallyCentered { get; set; }
    private List<Event> Events { get; set; } = null;
    private Event SelectedMatch { get; set; }
    protected override void OnInitialized()
    {
        Events = new bookmaker_officeContext().Events
            .Where(a => a.IdSport == 1)
            .Where(a => a.StartDate <= DateTime.Now)
            .Where(a => a.IsPast != true)
            .Include(team1 => team1.IdTeam1Navigation)
            .Include(team2 => team2.IdTeam2Navigation)
            .Include(x => x.PossibleBets)
            .ToList();
    }

    private String GetCoef1(ICollection<PossibleBet> ts)
    {
        var tob = ts.FirstOrDefault(x => x.IdTob == 1);
        return tob is null ? "null" : tob.Coef1.ToString();
    }
    private String GetCoef2(ICollection<PossibleBet> ts)
    {
        var tob = ts.FirstOrDefault(x => x.IdTob == 1);
        return tob is null ? "null" : tob.Coef2.ToString();
    }

    public void BetsForTeam(Event @event)
    {
        if (@event is null)
            return;

        SelectedMatch = @event;

        VerticallyCentered.Toggle();
    }

    public void Close() 
		=> VerticallyCentered.Toggle();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
