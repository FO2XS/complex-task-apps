#pragma checksum "C:\pepos\complex-task-apps\Web\Pages\MainPart\MainPart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7861731a09fa8a7b5adc3a12e465c64186817e81"
// <auto-generated/>
#pragma warning disable 1591
namespace Test.Pages.MainPart
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
#line 1 "C:\pepos\complex-task-apps\Web\Pages\MainPart\MainPart.razor"
using Test.Pages.MainPart.UserSide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\pepos\complex-task-apps\Web\Pages\MainPart\MainPart.razor"
using Test.Pages.MainPart.ActiveMathes;

#line default
#line hidden
#nullable disable
    public partial class MainPart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main-part");
            __builder.AddAttribute(2, "b-m7f5v0km5k");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "b-m7f5v0km5k");
            __builder.OpenElement(5, "tr");
            __builder.AddAttribute(6, "b-m7f5v0km5k");
            __builder.OpenElement(7, "td");
            __builder.AddAttribute(8, "b-m7f5v0km5k");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "active-bet");
            __builder.AddAttribute(11, "style", "margin: 0px;");
            __builder.AddAttribute(12, "b-m7f5v0km5k");
            __builder.OpenComponent<Test.Pages.MainPart.ActiveMathes.AtiveMatches>(13);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddAttribute(16, "class", "side");
            __builder.AddAttribute(17, "b-m7f5v0km5k");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "user");
            __builder.AddAttribute(20, "b-m7f5v0km5k");
            __builder.OpenComponent<Test.Pages.MainPart.UserSide.UserSide>(21);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
