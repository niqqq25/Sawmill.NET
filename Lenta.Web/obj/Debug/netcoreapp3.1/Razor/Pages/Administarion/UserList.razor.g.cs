#pragma checksum "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6515c3fd1c0d9813d2e0a535ba8a5426a3884c51"
// <auto-generated/>
#pragma warning disable 1591
namespace Lenta.Web.Pages.Administarion
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\_Imports.razor"
using Lenta.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\_Imports.razor"
using Lenta.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\_Imports.razor"
using Lenta.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\_Imports.razor"
using Lenta.Shared.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserList.razor"
           [Authorize(Roles = "adminas")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class UserList : UserListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row flow-offset-1");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h1 class=\"mb-4\">Darbuotojų paskyros</h1>\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"w-100 d-flex mb-2\">\r\n        <a class=\"btn btn-success btn-rounded btn-sm my-0 d-table\" style=\"color: white;\" href=\"users/create\">Sukurti</a>\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Vardas</th>\r\n                <th>Pavardė</th>\r\n                <th>El. paštas</th>\r\n                <th>Rolė</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 21 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserList.razor"
             foreach (var user in Users)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 24 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserList.razor"
                         user.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 25 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserList.razor"
                         user.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 26 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserList.razor"
                         user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 27 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserList.razor"
                         user.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", "#");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserList.razor"
                                                () => HandleUserDelete(user.Id, $"{user.FirstName} {user.LastName}")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(31, "onclick", true);
            __builder.AddMarkupContent(32, "Ištrinti");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 32 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
