// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class ProducerInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Анотон\source\repos\MySiteServer\MySiteServer\Shared\ProducerInfo.razor"
           
        [Parameter] public string prodId { get; set; }
        private IEnumerable<Good> goods = new List<Good>();
        private Producer producer;
        private List<string> imgFiles;
        private List<uint> inputValues;

        protected override void OnInitialized()
        {
            goods = repository.GetAllGoods();
            producer = repository.GetAllProducers().Where(p => p.Id == int.Parse(prodId) + 1).First();
            imgFiles = new List<string>();
            
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.Repository.IRepository repository { get; set; }
    }
}
#pragma warning restore 1591
