#pragma checksum "C:\Users\Анотон\source\repos\MySite\MySite\Pages\Account.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e363022aa8960c9a24304563f5453ac420c058ad"
// <auto-generated/>
#pragma warning disable 1591
namespace MySite.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Анотон\source\repos\MySite\MySite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Анотон\source\repos\MySite\MySite\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Анотон\source\repos\MySite\MySite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Анотон\source\repos\MySite\MySite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Анотон\source\repos\MySite\MySite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Анотон\source\repos\MySite\MySite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Анотон\source\repos\MySite\MySite\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Анотон\source\repos\MySite\MySite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Анотон\source\repos\MySite\MySite\_Imports.razor"
using MySite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Анотон\source\repos\MySite\MySite\_Imports.razor"
using MySite.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/acc")]
    public partial class Account : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Account</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Введите имя пользователя:\r\n    ");
            __builder.OpenElement(3, "h2");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Анотон\source\repos\MySite\MySite\Pages\Account.razor"
                                              HasUserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\Анотон\source\repos\MySite\MySite\Pages\Account.razor"
                       UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserName = __value, UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddMarkupContent(10, "\r\n    Введите пароль:\r\n    ");
            __builder.OpenElement(11, "h2");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Анотон\source\repos\MySite\MySite\Pages\Account.razor"
                                          HasUserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Анотон\source\repos\MySite\MySite\Pages\Account.razor"
                      Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Анотон\source\repos\MySite\MySite\Pages\Account.razor"
       
    User u = new User();

    [Parameter]
    public string UserName { get; set; }

    [Parameter]
    public string Password { get; set; }

    private void HasUserName()
    {
        u.ShowUser();
        u.Password = Password;
        u.UserName = UserName;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591