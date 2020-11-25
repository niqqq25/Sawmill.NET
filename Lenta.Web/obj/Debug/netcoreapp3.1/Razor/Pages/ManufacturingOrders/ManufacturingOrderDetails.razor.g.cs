#pragma checksum "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e98649cb4f571949730eeed45e60b8799a9a89a9"
// <auto-generated/>
#pragma warning disable 1591
namespace Lenta.Web.Pages.ManufacturingOrders
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
#line 3 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderDetails.razor"
           [Authorize(Roles = "sandelininkas, gamintojas")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/morders/{id}")]
    public partial class ManufacturingOrderDetails : ManufacturingOrderDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderDetails.razor"
 if (Order != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, "<h1 class=\"mb-4\">Gamybos užsakymas</h1>\r\n        ");
            __builder.OpenElement(5, "form");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.AddMarkupContent(10, "<label for=\"id\">Kodas</label>\r\n                ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "id", "id");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "Value", 
#nullable restore
#line 12 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderDetails.razor"
                                                            Order.Id.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card mb-3");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-body");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.AddMarkupContent(24, "<h4 class=\"card-title\">Prekė</h4>\r\n                    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group");
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.AddMarkupContent(28, "<label>Pavadinimas</label>\r\n                        ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "Value", 
#nullable restore
#line 19 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderDetails.razor"
                                                            Order.Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-group");
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.AddMarkupContent(38, "<label>Aprašymas</label>\r\n                        ");
            __builder.OpenElement(39, "textarea");
            __builder.AddAttribute(40, "class", "form-control");
            __builder.AddAttribute(41, "Value", 
#nullable restore
#line 23 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderDetails.razor"
                                                                String.IsNullOrEmpty(Order.Product.Description) ? "-" : Order.Product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "form-group");
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.AddMarkupContent(50, "<label for=\"quantity\">Kiekis</label>\r\n                ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "id", "quantity");
            __builder.AddAttribute(53, "class", "form-control");
            __builder.AddAttribute(54, "Value", 
#nullable restore
#line 29 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderDetails.razor"
                                                                  Order.Quantity.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(55, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "form-group");
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.AddMarkupContent(61, "<label for=\"orderDate\">Užsakymo data</label>\r\n                ");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "id", "orderDate");
            __builder.AddAttribute(64, "class", "form-control");
            __builder.AddAttribute(65, "Value", 
#nullable restore
#line 33 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderDetails.razor"
                                                                   Order.OrderDate.ToString("yyyy-MM-dd HH:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(66, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "form-group");
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.AddMarkupContent(72, "<label for=\"orderStatus\">Užsakymo būsena</label>\r\n                ");
            __builder.OpenElement(73, "input");
            __builder.AddAttribute(74, "id", "orderStatus");
            __builder.AddAttribute(75, "class", "form-control");
            __builder.AddAttribute(76, "Value", 
#nullable restore
#line 37 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderDetails.razor"
                                                                     Order.Status

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(77, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 42 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591