#pragma checksum "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0e4b33b142600059a7db2c3965eff7418026c01"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/prodInfo/{prodId}")]
    public partial class ProducerInfo : IndexBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
 if(UserExistsAndAdmin())
{ 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h6");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "admin_button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                                               ChangeProducerName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, " Изменить название производителя ");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                       newProducerName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value =>  newProducerName = __value,  newProducerName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "h6");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "admin_button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                                               ChangeProducerInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, " Изменить описание производителя ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "textarea");
            __builder.AddAttribute(17, "class", "text-info");
            __builder.AddAttribute(18, "cols", "10");
            __builder.AddAttribute(19, "rows", "15");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                                                                newProducerInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value =>  newProducerInfo = __value,  newProducerInfo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "p");
            __builder.AddMarkupContent(24, "\r\n        Все товары производителя ");
            __builder.AddContent(25, 
#nullable restore
#line 16 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                                  producer.ProducerName

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 17 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
         for (int i = 0; i < goods.Count(); i++)
        {
            var j = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "h1");
#nullable restore
#line 21 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                 if (goods.ElementAt(j).GoodProducerId == int.Parse(prodId) + 1)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", "goodInfo/" + (
#nullable restore
#line 23 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                                       j

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, 
#nullable restore
#line 24 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                         goods.ElementAt(j).GoodName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "p");
            __builder.AddMarkupContent(31, "\r\n        Все товары производителя ");
            __builder.AddContent(32, 
#nullable restore
#line 35 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                                  producer.ProducerName

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 36 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
         for (int i = 0; i < goods.Count(); i++)
        {
            var j = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "h1");
#nullable restore
#line 40 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                 if (goods.ElementAt(j).GoodProducerId == int.Parse(prodId) + 1)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "href", "goodInfo/" + (
#nullable restore
#line 42 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                                       j

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, 
#nullable restore
#line 43 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                         goods.ElementAt(j).GoodName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, 
#nullable restore
#line 49 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
         producer.ProducerInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
       
    [Parameter] public string prodId { get; set; }
    IEnumerable<Good> goods = new List<Good>();
    IEnumerable<User> users = new List<User>();
    Producer producer;
    List<string> imgFiles;
    List<uint> inputValues;
    User curUser;
    string newProducerName;
    string newProducerInfo;

    protected override void OnInitialized()
    {
        users = repository.GetAllUsers();
        goods = repository.GetAllGoods();
        producer = repository.GetAllProducers().Where(p => p.Id == int.Parse(prodId) + 1).First();
        imgFiles = new List<string>();
        if (!string.IsNullOrEmpty(Service.password) && !string.IsNullOrWhiteSpace(Service.password) && !string.IsNullOrEmpty(Service.userName) && !string.IsNullOrWhiteSpace(Service.userName))
            curUser = repository.GetAllUsers().Where(u => u.L0gin == Service.userName && u.Passwrd == Service.password).First();
        newProducerName = producer.ProducerName;
        newProducerInfo = producer.ProducerInfo;
    }

    void ChangeProducerName()
    {
        if (!string.IsNullOrEmpty(newProducerName) && !string.IsNullOrWhiteSpace(newProducerName))
        {
            producer.ProducerName = newProducerName;
            repository.ProducerInfoChanged(producer);
        }
    }

    void ChangeProducerInfo()
    {
        if (!string.IsNullOrWhiteSpace(newProducerInfo) && !string.IsNullOrEmpty(newProducerInfo))
        {
            producer.ProducerInfo = newProducerInfo;
            repository.ProducerInfoChanged(producer);
        }
    }

    private bool UserExistsAndAdmin()
    {
        if (!string.IsNullOrWhiteSpace(Service.userName) && !string.IsNullOrWhiteSpace(Service.password) &&
            !string.IsNullOrEmpty(Service.userName) && !string.IsNullOrEmpty(Service.password))
            for (int i = 0; i < users.Count(); i++)
            {
                if (users.ElementAt(i).L0gin == Service.userName && users.ElementAt(i).Passwrd == Service.password)
                {
                    curUser = users.ElementAt(i);
                    if(curUser.IsAdmin)
                        return true;
                }
            }
        return false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.Repository.IRepository repository { get; set; }
    }
}
#pragma warning restore 1591
