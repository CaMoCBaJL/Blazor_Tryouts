#pragma checksum "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92e90c7fdd9d3dce3f1eda58e52284844f6baa59"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/news/{newsItemId}")]
    public partial class News : IndexBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
 switch (addNewsItemCondition)
{
    case 0:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"addCondition_0\">\r\n            Не все поля заполнены!\r\n        </div>");
#nullable restore
#line 11 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
        break;
    case 1:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"addCondition_1\">\r\n            Новость с таким названием уже присутсвует в базе!\r\n        </div>");
#nullable restore
#line 16 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
        break;
    case 2:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div class=\"addCondition_2\">\r\n            Добавление новости прошло успешно!\r\n        </div>");
#nullable restore
#line 21 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
        break;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
 if (newsItemId == "newNewsItem")
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "h1");
            __builder.AddMarkupContent(4, "\r\n        Введите заголовок новости");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
                                               newNewsItemTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newNewsItemTitle = __value, newNewsItemTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "h6");
            __builder.AddContent(10, 
#nullable restore
#line 30 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
         curNewsItem.ReleaseDateTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "h6");
            __builder.AddMarkupContent(13, "\r\n        Введите текст новости ");
            __builder.OpenElement(14, "textarea");
            __builder.AddAttribute(15, "cols", "10");
            __builder.AddAttribute(16, "rows", "15");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
                                                                    newNewsItemContent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value =>  newNewsItemContent = __value,  newNewsItemContent));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "h3");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "button1");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
                                          AddNewsItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "\r\n            Добавить новость\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
}

else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
     if (UserExists())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
         if (curUser.IsAdmin)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "h1");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "admin_button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
                                                       ChangeNewsItemTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, " Изменить заголовк новости");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
                              newNewsItemTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newNewsItemTitle = __value, newNewsItemTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "h6");
            __builder.AddContent(36, 
#nullable restore
#line 53 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
                 curNewsItem.ReleaseDateTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "h6");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "admin_button");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
                                                       ChangeNewsItemTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, " Изменить текст новости");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "textarea");
            __builder.AddAttribute(45, "cols", "10");
            __builder.AddAttribute(46, "rows", "15");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
                                                      newNewsItemContent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value =>  newNewsItemContent = __value,  newNewsItemContent));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "h1");
            __builder.AddContent(50, 
#nullable restore
#line 63 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
                 curNewsItem.NewsItemTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "h6");
            __builder.AddContent(53, 
#nullable restore
#line 66 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
                 curNewsItem.ReleaseDateTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "h5");
            __builder.AddContent(56, 
#nullable restore
#line 69 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
                 curNewsItem.NewsItemContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "h1");
            __builder.AddContent(58, 
#nullable restore
#line 76 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
             curNewsItem.NewsItemTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "h6");
            __builder.AddContent(61, 
#nullable restore
#line 79 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
             curNewsItem.ReleaseDateTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.OpenElement(63, "h5");
            __builder.AddContent(64, 
#nullable restore
#line 82 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
             curNewsItem.NewsItemContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\News.razor"
       
    [Parameter] public string newsItemId { get; set; }
    User curUser;
    NewsItem curNewsItem;
    IEnumerable<User> users = new List<User>();
    string newNewsItemTitle;
    string newNewsItemContent;
    byte addNewsItemCondition = 255;

    protected override void OnInitialized()
    {
        users = repository.GetAllUsers();
        if (newsItemId == "newNewsItem")
        {
            newNewsItemTitle = string.Empty;
            newNewsItemContent = "Текст новости отсутсвует.";
            curNewsItem = new NewsItem()
            {
                NewsItemContent = newNewsItemContent,
                NewsItemTitle = newNewsItemTitle,
                ReleaseDateTime = DateTime.Now
            };
        }
        else
        {
            curNewsItem = repository.GetAllNews().Where(n => n.NewsItemId == int.Parse(newsItemId)).First();
            if (UserExists())
                if (curUser.IsAdmin)
                {
                    newNewsItemTitle = curNewsItem.NewsItemTitle;
                    newNewsItemContent = curNewsItem.NewsItemContent;
                }
        }
    }

    void AddNewsItem()
    {
        if (string.IsNullOrEmpty(newNewsItemTitle) || string.IsNullOrWhiteSpace(newNewsItemTitle) || string.IsNullOrEmpty(newNewsItemContent) || string.IsNullOrWhiteSpace(newNewsItemContent) ||
            newNewsItemContent == "Текст новости отсутсвует.")
        {
            addNewsItemCondition = 0;
        }
        else
        {
            foreach (var item in repository.GetAllNews())
            {
                if (item.NewsItemTitle == newNewsItemTitle)
                {
                    addNewsItemCondition = 1;
                    return;
                }
            }
            addNewsItemCondition = 2;
            curNewsItem.NewsItemTitle = newNewsItemTitle;
            curNewsItem.NewsItemContent = newNewsItemContent;
            repository.AddNewsItem(curNewsItem);
        }
    }

    private bool UserExists()
    {
        if (!string.IsNullOrWhiteSpace(Service.userName) && !string.IsNullOrWhiteSpace(Service.password) &&
            !string.IsNullOrEmpty(Service.userName) && !string.IsNullOrEmpty(Service.password))
            for (int i = 0; i < users.Count(); i++)
            {
                if (users.ElementAt(i).L0gin == Service.userName && users.ElementAt(i).Passwrd == Service.password)
                {
                    curUser = users.ElementAt(i);
                    return true;
                }
            }
        return false;
    }

    void ChangeNewsItemTitle()
    {
        if (string.IsNullOrEmpty(newNewsItemTitle) || string.IsNullOrWhiteSpace(newNewsItemTitle))
        {
            addNewsItemCondition = 0;
        }
        else
        {
            foreach (var item in repository.GetAllNews())
            {
                if (item.NewsItemTitle == newNewsItemTitle)
                {
                    addNewsItemCondition = 1;
                    return;
                }
            }
            addNewsItemCondition = 2;
            curNewsItem.NewsItemTitle = newNewsItemTitle;
            repository.ChangeNewsItem(curNewsItem);
        }
    }

    void ChangeNewsItemContent()
    {
        if (string.IsNullOrEmpty(newNewsItemTitle) || string.IsNullOrWhiteSpace(newNewsItemTitle))
        {
            addNewsItemCondition = 0;
        }
        else
        {
            addNewsItemCondition = 2;
            curNewsItem.NewsItemContent = newNewsItemContent;
            repository.ChangeNewsItem(curNewsItem);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.Repository.IRepository repository { get; set; }
    }
}
#pragma warning restore 1591
