#pragma checksum "D:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fcd0d77f5ee604700e5620b93519fad13bb2334"
// <auto-generated/>
#pragma warning disable 1591
namespace Test.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\_Imports.razor"
using Test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Университет\4 семестр\Веб-программирование\complex-task-apps\Web\Pages\Index.razor"
using Test.Pages.MainPart;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "menu1");
            __builder.AddAttribute(2, "b-1i06yy398t");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "margin: 0 auto; max-width: 1240px; ");
            __builder.AddAttribute(5, "b-1i06yy398t");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "logo-and-type-game-and-technical-support");
            __builder.AddAttribute(8, "b-1i06yy398t");
            __builder.AddMarkupContent(9, "<div class=\"logo\" b-1i06yy398t>\r\n\t\t\t\tЛого\r\n\t\t\t</div>\r\n\t\t\t");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class");
            __builder.AddAttribute(12, "b-1i06yy398t");
            __builder.OpenElement(13, "select");
            __builder.AddAttribute(14, "b-1i06yy398t");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "selected");
            __builder.AddAttribute(17, "b-1i06yy398t");
            __builder.AddMarkupContent(18, "\r\n\t\t\t\t\t\tCS:GO\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\t\t\t\t\t");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "b-1i06yy398t");
            __builder.AddMarkupContent(22, "\r\n\t\t\t\t\t\tLoL\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\t\t\t");
            __builder.AddMarkupContent(24, "<div class=\"technical-support\" b-1i06yy398t>\r\n\t\t\t\tТех. поддержка\r\n\t\t\t</div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n\t\t");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "custom-features");
            __builder.AddAttribute(28, "b-1i06yy398t");
            __builder.AddMarkupContent(29, "<div b-1i06yy398t>FAQ</div>\r\n\t\t\t");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "b-1i06yy398t");
            __builder.OpenComponent<Test.Pages.AuthenticationModal>(32);
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n                <br b-1i06yy398t>\r\n                ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-success");
            __builder.AddAttribute(36, "b-1i06yy398t");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
            __builder.AddAttribute(38, "style", "text-decoration:none; color: white;");
            __builder.AddAttribute(39, "href", "registration");
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(41, "\r\n                        Reg\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "main-main");
            __builder.AddAttribute(45, "b-1i06yy398t");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "main");
            __builder.AddAttribute(48, "b-1i06yy398t");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "hot-matches");
            __builder.AddAttribute(51, "b-1i06yy398t");
            __builder.OpenComponent<Test.Pages.HotMath>(52);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\t\t");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "main-part");
            __builder.AddAttribute(56, "b-1i06yy398t");
            __builder.OpenComponent<Test.Pages.MainPart.MainPart>(57);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
