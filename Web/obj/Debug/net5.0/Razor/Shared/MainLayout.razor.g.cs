#pragma checksum "C:\pepos\complex-task-apps\Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88fe93160db8c276eab8f5b0f79196fa94cba569"
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
#nullable restore
#line 3 "C:\pepos\complex-task-apps\Web\Shared\MainLayout.razor"
using Test.Pages;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main-main");
            __builder.AddAttribute(2, "b-vv8m6rf2se");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "menu1");
            __builder.AddAttribute(5, "b-vv8m6rf2se");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "logo-and-type-game-and-technical-support");
            __builder.AddAttribute(8, "b-vv8m6rf2se");
            __builder.AddMarkupContent(9, "<div class=\"logo\" b-vv8m6rf2se>\r\n                Лого\r\n            </div>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class");
            __builder.AddAttribute(12, "b-vv8m6rf2se");
            __builder.OpenElement(13, "select");
            __builder.AddAttribute(14, "b-vv8m6rf2se");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "selected");
            __builder.AddAttribute(17, "b-vv8m6rf2se");
            __builder.AddMarkupContent(18, "\r\n                        CS:GO\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "b-vv8m6rf2se");
            __builder.AddMarkupContent(22, "\r\n                        LoL\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.AddMarkupContent(24, "<div class=\"technical-support\" b-vv8m6rf2se>\r\n                Тех. поддержка\r\n            </div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n        ");
            __builder.AddMarkupContent(26, @"<div class=""custom-features"" b-vv8m6rf2se><div b-vv8m6rf2se>FAQ</div>
            <div b-vv8m6rf2se><button style=""display: block;"" b-vv8m6rf2se>log in</button>
                <button style=""display: block;"" b-vv8m6rf2se>log up</button></div>
            <div b-vv8m6rf2se></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "main");
            __builder.AddAttribute(30, "b-vv8m6rf2se");
            __builder.OpenComponent<Test.Pages.HotMath>(31);
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n            \r\n        ");
            __builder.OpenComponent<Test.Pages.AtiveMatches>(33);
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n        \r\n        <div b-vv8m6rf2se></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\pepos\complex-task-apps\Web\Shared\MainLayout.razor"
      

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
