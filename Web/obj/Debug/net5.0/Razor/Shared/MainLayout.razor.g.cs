#pragma checksum "C:\pepos\complex-task-apps\Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e9d7899d1c55ebb549881c0a1f00d4556e749e5"
// <auto-generated/>
#pragma warning disable 1591
namespace Test.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" type=\"text/css\" href=\"~/css/site.css\" b-vv8m6rf2se>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "menu");
            __builder.AddAttribute(3, "b-vv8m6rf2se");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "logo-and-type-game-and-technical-support");
            __builder.AddAttribute(6, "b-vv8m6rf2se");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "logo");
            __builder.AddAttribute(9, "b-vv8m6rf2se");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(10);
            __builder.AddAttribute(11, "href", "");
            __builder.AddAttribute(12, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 8 "C:\pepos\complex-task-apps\Web\Shared\MainLayout.razor"
                                    NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "type-game");
            __builder.AddAttribute(16, "b-vv8m6rf2se");
            __builder.OpenElement(17, "select");
            __builder.AddAttribute(18, "b-vv8m6rf2se");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "selected");
            __builder.AddAttribute(21, "b-vv8m6rf2se");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
            __builder.AddAttribute(23, "href", "");
            __builder.AddAttribute(24, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 14 "C:\pepos\complex-task-apps\Web\Shared\MainLayout.razor"
                                            NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n                        CS:GO\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "b-vv8m6rf2se");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "href", "");
            __builder.AddAttribute(32, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 19 "C:\pepos\complex-task-apps\Web\Shared\MainLayout.razor"
                                            NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "\r\n                        LoL\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.AddMarkupContent(36, "<div class=\"technical-support\" b-vv8m6rf2se>\r\n        Тех. поддержка\r\n    </div>\r\n\r\n    ");
            __builder.AddMarkupContent(37, @"<div class=""custom-features"" b-vv8m6rf2se><div class=""FAQ"" b-vv8m6rf2se>FAQ</div>
        <div class=""log-in-log-up"" b-vv8m6rf2se><button class=""user-button"" b-vv8m6rf2se>log in</button>
            <button class=""user-button"" b-vv8m6rf2se>log up</button></div>
        <div b-vv8m6rf2se></div></div>
    <div b-vv8m6rf2se></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "content px-4");
            __builder.AddAttribute(41, "b-vv8m6rf2se");
            __builder.AddContent(42, 
#nullable restore
#line 43 "C:\pepos\complex-task-apps\Web\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\pepos\complex-task-apps\Web\Shared\MainLayout.razor"
      
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
