#pragma checksum "C:\pepos\complex-task-apps\Web\Pages\AuthenticationModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36da2c8c088ab5c44ac4c0d80010ae0053a07098"
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
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\pepos\complex-task-apps\Web\Pages\AuthenticationModal.razor"
using Test.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\pepos\complex-task-apps\Web\Pages\AuthenticationModal.razor"
using Test.Data.Modal;

#line default
#line hidden
#nullable disable
    public partial class AuthenticationModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<button type=\"button\" class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"#exampleModal\"> log in</button>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"modal fade\" id=\"exampleModal\" tabindex=\"-1\" aria-hidden=\"true\"><div class=\"modal-dialog\"><div class=\"modal-content\" style=\"font-family: Trebuchet MS; color: black; background-color: #F6F6F6;\"><div class=\"modal-header\"><h5 class=\"modal-title\">Логин</h5>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button></div>\r\n      <div class=\"modal-body\"><div class=\"container\"><div class=\"row\"><div class=\"col\"><h5><p class=\"text-center\">Email</p></h5></div></div>\r\n          <div class=\"row\"><div class=\"col\"><input type=\"email\" class=\"form-control\" placeholder=\"Например@mail.ru\"></div></div>\r\n          <div class=\"row\"><div class=\"col\"><br></div></div>\r\n          <div class=\"row\"><div class=\"col\"><h5><p class=\"text-center\">Пароль</p></h5></div></div>\r\n          <div class=\"row\"><div class=\"col\"><input type=\"password\" class=\"form-control\" placeholder=\"qwerty123\"></div></div>\r\n          <div class=\"row\"><div class=\"col\"><div class=\"form-check\"><input class=\"form-check-input\" type=\"checkbox\" value id=\"rememberMe\">\r\n                 <label class=\"form-check-label\" for=\"rememberMe\">\r\n                    Запомнить меня\r\n                 </label></div></div>\r\n            <div class=\"col\"><p class=\"text-right\"><a href>Забыли пароль?</a></p></div></div></div></div>\r\n      <div class=\"modal-footer\"><button type=\"button\" class=\"btn btn-success\">Войти</button>\r\n        <button type=\"button\" class=\"btn btn-dark\" data-dismiss=\"modal\">Закрыть</button></div></div></div></div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WebService service { get; set; }
    }
}
#pragma warning restore 1591
