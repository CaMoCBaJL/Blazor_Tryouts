#pragma checksum "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8873a390c9b12985f947d93b629a495e723c173"
// <auto-generated/>
#pragma warning disable 1591
namespace MySiteServer.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/reg/{usrId}")]
    public partial class Registration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddAttribute(1, "align", "center");
#nullable restore
#line 5 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
     switch (regCondition)
    {
        case 0:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div class=\"addCondition_0\">\r\n                Введны не все данные!\r\n            </div>");
#nullable restore
#line 11 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
            break;
        case 1:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<div class=\"addCondition_1\">\r\n                Пользователь с таким паролем и логином уже имеется  в базе!\r\n            </div>");
#nullable restore
#line 16 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
            break;
        case 2:
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
             if (usrId == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<div class=\"addCondition_2\">\r\n                    Добавление прошло успешно!\r\n                </div>");
#nullable restore
#line 23 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<div class=\"addCondition_2\">\r\n                    Изменение информации о пользователе прошло успешно!\r\n                </div>");
#nullable restore
#line 29 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
             
            break;
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "h6");
            __builder.AddAttribute(8, "class", "big_h");
            __builder.AddMarkupContent(9, "\r\n    Введите имя пользователя \r\n    ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "class", "my_little_input_1");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
                                            userName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userName = __value, userName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
     if(usrId != "addUser")
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "button0");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
                                          ChangeUserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, " Изменить имя пользователя ");
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "h6");
            __builder.AddAttribute(20, "class", "big_h");
            __builder.AddMarkupContent(21, "\r\n    Введите логин для входа в учетную запись \r\n    ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "class", "my_little_input_1");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
                                            login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => login = __value, login));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
     if (usrId != "addUser")
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "button0");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
                                          ChangeLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, " Изменить логин ");
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.OpenElement(31, "h6");
            __builder.AddAttribute(32, "class", "big_h");
            __builder.AddMarkupContent(33, "\r\n    Введите пароль для входа в учетную запись \r\n    ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "class", "my_little_input_1");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
                                            password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
     if (usrId != "addUser")
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "button0");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
                                          ChangePassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, " Изменить пароль ");
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
 if (usrId == "addUser")
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "h6");
            __builder.AddMarkupContent(43, "\r\n    Введите пароль администратора (опционально) \r\n    ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "class", "my_little_input_1");
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
                                                (args) => IsAdmin(args)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "h6");
#nullable restore
#line 65 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
     if (usrId == "addUser")
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "button0");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
                                      UserRegistration

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, " Регистрация");
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Pages\Registration.razor"
       
    [Parameter] public string usrId { get; set; }
    string userName;
    string login;
    string password;
    bool isAdmin;
    byte regCondition;

    protected override void OnInitialized()
    {
        isAdmin = false;
        regCondition = 255;
        if(usrId != "addUser")
        {
            User user = repository.GetAllUsers().Where(usr => usr.UserId == int.Parse(usrId)).First();
            userName = user.UserName;
            login = user.L0gin;
            password = user.Passwrd;
        }
    }

    void IsAdmin(ChangeEventArgs args)
    {
        if (args.Value.ToString() == "admin" && !isAdmin)
            isAdmin = true;
    }

    void ChangeUserName()
    {
        User user = repository.GetAllUsers().Where(usr => usr.UserId == int.Parse(usrId)).First();
        user.UserName = userName;
        repository.UserInfoChanged(user);
    }

    void ChangeLogin()
    {
        foreach (var item in repository.GetAllUsers())
        {
            if (item.L0gin == login && item.Passwrd == password)
            {
                regCondition = 1;
                return;
            }
        }
        User user = repository.GetAllUsers().Where(usr => usr.UserId == int.Parse(usrId)).First();
        user.UserName = userName;
        repository.UserInfoChanged(user);
    }

    void ChangePassword()
    {
        foreach (var item in repository.GetAllUsers())
        {
            if (item.L0gin == login && item.Passwrd == password)
            {
                regCondition = 1;
                return;
            }
        }
        User user = repository.GetAllUsers().Where(usr => usr.UserId == int.Parse(usrId)).First();
        user.UserName = userName;
        repository.UserInfoChanged(user);
    }

    void UserRegistration()
    {
        if (string.IsNullOrEmpty(userName) || string.IsNullOrWhiteSpace(userName) || string.IsNullOrEmpty(login) || string.IsNullOrWhiteSpace(login) ||
            string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))
            regCondition = 0;
        else
        {
            foreach (var item in repository.GetAllUsers())
            {
                if (item.L0gin == login && item.Passwrd == password)
                {
                    regCondition = 1;
                    return;
                }
            }
            regCondition = 2;
            repository.AddUser(new User() { L0gin = login, Passwrd = password, UserCart = null, IsAdmin = isAdmin, UserName = userName });
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.Repository.IRepository repository { get; set; }
    }
}
#pragma warning restore 1591