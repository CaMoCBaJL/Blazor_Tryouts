#pragma checksum "C:\Users\Анотон\source\repos\MySite\MySite\Pages\NewPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "039b2a840d041e0387db96bd0a5157d01b9ced57"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/NewPage")]
    public partial class NewPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.OpenElement(6, "h3");
            __builder.AddContent(7, "MyPage) ");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\Users\Анотон\source\repos\MySite\MySite\Pages\NewPage.razor"
                         cur

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Анотон\source\repos\MySite\MySite\Pages\NewPage.razor"
                              Random

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "KHono4ka");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Анотон\source\repos\MySite\MySite\Pages\NewPage.razor"
       
    private int cur = 0;
    void Random()
    {
        cur = new Random().Next(-1000, 1000);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591