#pragma checksum "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b247ddbe13eb54a9bbfb5eabdd7fc73820c9e2a"
// <auto-generated/>
#pragma warning disable 1591
namespace MySiteServer.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\_Imports.razor"
using MySiteServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\_Imports.razor"
using MySiteServer.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/usr/{usrId}")]
    public partial class UserInfoPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddContent(0, 
#nullable restore
#line 4 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
 users.ElementAt(int.Parse(usrId)).UserName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(1, " Admin(");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
                                                   users.ElementAt(int.Parse(usrId)).IsAdmin

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, ")\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
 if(!users.ElementAt(int.Parse(usrId)).IsAdmin)

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
 if (string.IsNullOrEmpty(users.ElementAt(int.Parse(usrId)).UserCart))
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<h1> Корзина пуста</h1>");
#nullable restore
#line 10 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<div class=\"user_cart_style\"><h2>Покупки:</h2></div>");
#nullable restore
#line 16 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
    foreach (var item in users.ElementAt(int.Parse(usrId)).UserCart.Split())
    {
        (int id, int count) goodInfo;
        goodInfo.id = int.Parse(item.Split('*')[0]);
        goodInfo.count = int.Parse(item.Split('*')[1]);


#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "p");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", " user_cart_style");
            __builder.OpenElement(9, "h3");
            __builder.AddContent(10, 
#nullable restore
#line 25 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
                     producers.ElementAt(goods.ElementAt(goodInfo.id).GoodProducerId - 1).ProducerName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " - ");
            __builder.AddContent(12, 
#nullable restore
#line 25 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
                                                                                                          goods.ElementAt(goodInfo.id).GoodName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " x ");
            __builder.AddContent(14, 
#nullable restore
#line 25 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
                                                                                                                                                   goodInfo.count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, " |\r\n                    ");
            __builder.OpenElement(16, "b");
            __builder.AddContent(17, 
#nullable restore
#line 26 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
                          FinalPrice(goods.ElementAt(goodInfo.id).GoodPrice * goodInfo.count)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        <p></p>");
#nullable restore
#line 31 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "h1");
            __builder.OpenElement(20, "b");
            __builder.AddMarkupContent(21, "  Итого: ");
            __builder.AddContent(22, 
#nullable restore
#line 33 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
                     sum

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\UserInfoPage.razor"
       
    [Parameter] public string usrId { get; set; }
    public IEnumerable<User> users = new List<User>();
    public IEnumerable<Good> goods = new List<Good>();
    public IEnumerable<Producer> producers = new List<Producer>();
    private double sum;

    protected override void OnInitialized()
    {
        users = repository.GetAllUsers();
        producers = repository.GetAllProducers();
        goods = repository.GetAllGoods();
    }
    private double FinalPrice(double newTerm)
    {
        sum += newTerm;
        return newTerm;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.Repository.IRepository repository { get; set; }
    }
}
#pragma warning restore 1591
