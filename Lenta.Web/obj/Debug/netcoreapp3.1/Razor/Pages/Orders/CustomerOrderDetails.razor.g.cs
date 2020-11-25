#pragma checksum "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e724232a5b2756506b7788865da7e51b7caa7dd7"
// <auto-generated/>
#pragma warning disable 1591
namespace Lenta.Web.Pages.Orders
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
#line 3 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
           [Authorize(Roles = "klientuAptarnautojas, sandelininkas")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orders/{id}")]
    public partial class CustomerOrderDetails : CustomerOrderDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
 if (!IsLoading)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, "<h1 class=\"mb-4\">Užsakymo informacija</h1>\r\n        ");
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
#line 12 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
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
            __builder.AddMarkupContent(24, "<h4 class=\"card-title\">Užsakovo informacija</h4>\r\n                    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "d-flex");
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group flex-fill mr-3");
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.AddMarkupContent(31, "<label for=\"customer-firstname\">Vardas</label>\r\n                            ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "value", 
#nullable restore
#line 20 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
                                                                Order.Customer.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "id", "customer-firstname");
            __builder.AddAttribute(36, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group flex-fill");
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.AddMarkupContent(42, "<label for=\"customer-lastname\">Pavardė</label>\r\n                            ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "value", 
#nullable restore
#line 24 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
                                                                Order.Customer.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "id", "customer-lastname");
            __builder.AddAttribute(47, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group");
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.AddMarkupContent(54, "<label for=\"customer-phone\">Telefono numeris</label>\r\n                        ");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "value", 
#nullable restore
#line 29 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
                                                            Order.Customer.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(58, "id", "customer-phone");
            __builder.AddAttribute(59, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "form-group");
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.AddMarkupContent(65, "<label for=\"customer-email\">Elektroninis paštas</label>\r\n                        ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "class", "form-control");
            __builder.AddAttribute(68, "value", 
#nullable restore
#line 33 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
                                                            Order.Customer.Email

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(69, "id", "customer-email");
            __builder.AddAttribute(70, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "card mb-3");
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "card-body");
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.AddMarkupContent(81, "<h4 class=\"card-title\">Prekės</h4>\r\n");
#nullable restore
#line 40 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
                     foreach (var orderItem in Order.OrderItems)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(82, "                        <hr>\r\n                        ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "form-group");
            __builder.AddMarkupContent(85, "\r\n                            ");
            __builder.AddMarkupContent(86, "<label>Pavadinimas</label>\r\n                            ");
            __builder.OpenElement(87, "input");
            __builder.AddAttribute(88, "class", "form-control");
            __builder.AddAttribute(89, "value", 
#nullable restore
#line 45 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
                                                                orderItem.Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(90, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                        ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "form-group");
            __builder.AddMarkupContent(95, "\r\n                            ");
            __builder.AddMarkupContent(96, "<label>Aprašymas</label>\r\n                            ");
            __builder.OpenElement(97, "textarea");
            __builder.AddAttribute(98, "class", "form-control");
            __builder.AddAttribute(99, "value", 
#nullable restore
#line 49 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
                                                                    String.IsNullOrEmpty(orderItem.Product.Description) ? "-" : orderItem.Product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(100, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "form-group");
            __builder.AddMarkupContent(105, "\r\n                            ");
            __builder.AddMarkupContent(106, "<label>Kiekis</label>\r\n                            ");
            __builder.OpenElement(107, "input");
            __builder.AddAttribute(108, "class", "form-control");
            __builder.AddAttribute(109, "value", 
#nullable restore
#line 53 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
                                                                orderItem.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(110, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n");
#nullable restore
#line 55 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(113, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n            ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "form-group");
            __builder.AddMarkupContent(118, "\r\n                ");
            __builder.AddMarkupContent(119, "<label for=\"orderStatus\">Užsakymo data</label>\r\n                ");
            __builder.OpenElement(120, "input");
            __builder.AddAttribute(121, "id", "orderStatus");
            __builder.AddAttribute(122, "class", "form-control");
            __builder.AddAttribute(123, "value", 
#nullable restore
#line 60 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
                                                                     Order.OrderDate.ToString("yyyy-MM-dd HH:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(124, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n            ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "form-group");
            __builder.AddMarkupContent(129, "\r\n                ");
            __builder.AddMarkupContent(130, "<label for=\"orderStatus\">Užsakymo būsena</label>\r\n                ");
            __builder.OpenElement(131, "input");
            __builder.AddAttribute(132, "id", "orderStatus");
            __builder.AddAttribute(133, "class", "form-control");
            __builder.AddAttribute(134, "value", 
#nullable restore
#line 64 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
                                                                     Order.Status

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(135, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n");
#nullable restore
#line 68 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
