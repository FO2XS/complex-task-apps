// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Test.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "d:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\Shared\MainLayout.razor"
using Test.Pages;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "d:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\Shared\MainLayout.razor"
      

	private Boolean isServerSide = false;
	protected override async System.Threading.Tasks.Task OnInitializedAsync()
	{
		try
		{
			await BootstrapCSS.SetBootstrapCss("4.3.1");
		}
		catch (Exception)
		{
			isServerSide = true;
		}
	}
	protected override async System.Threading.Tasks.Task OnAfterRenderAsync(Boolean firstRun)
	{
		if (isServerSide && firstRun)
			await BootstrapCSS.SetBootstrapCss();
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBootstrapCss BootstrapCSS { get; set; }
    }
}
#pragma warning restore 1591
