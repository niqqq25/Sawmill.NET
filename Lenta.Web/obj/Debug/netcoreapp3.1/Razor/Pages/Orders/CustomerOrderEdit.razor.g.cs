#pragma checksum "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58476bcaa23102d2d0c07ac91580ab20df928d9f"
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
#line 3 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
           [Authorize(Roles = "klientuAptarnautojas, sandelininkas")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orders/edit/{id}")]
    public partial class CustomerOrderEdit : CustomerOrderEditBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
 if (Order != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, "<h1 class=\"mb-4\">Redaguoti užsakymą</h1>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                          OrderUpdate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                                                       HandleFormSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.AddMarkupContent(15, "<label for=\"id\">Kodas</label>\r\n                ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "id", "id");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", 
#nullable restore
#line 13 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                                                            Order.Id.ToString()

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(20, "disabled", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "card mb-3");
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "card-body");
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.AddMarkupContent(29, "<h4 class=\"card-title\">Užsakovo informacija</h4>\r\n                    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "d-flex");
                __builder2.AddMarkupContent(32, "\r\n                        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group flex-fill mr-3");
                __builder2.AddMarkupContent(35, "\r\n                            ");
                __builder2.AddMarkupContent(36, "<label for=\"customer-firstname\">Vardas</label>\r\n                            ");
                __builder2.OpenElement(37, "input");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "value", 
#nullable restore
#line 21 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                                                                Order.Customer.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(40, "id", "customer-firstname");
                __builder2.AddAttribute(41, "disabled", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group flex-fill");
                __builder2.AddMarkupContent(46, "\r\n                            ");
                __builder2.AddMarkupContent(47, "<label for=\"customer-lastname\">Pavardė</label>\r\n                            ");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "value", 
#nullable restore
#line 25 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                                                                Order.Customer.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(51, "id", "customer-lastname");
                __builder2.AddAttribute(52, "disabled", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.AddMarkupContent(59, "<label for=\"customer-phone\">Telefono numeris</label>\r\n                        ");
                __builder2.OpenElement(60, "input");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "value", 
#nullable restore
#line 30 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                                                            Order.Customer.Phone

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(63, "id", "customer-phone");
                __builder2.AddAttribute(64, "disabled", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.AddMarkupContent(69, "\r\n                        ");
                __builder2.AddMarkupContent(70, "<label for=\"customer-email\">Elektroninis paštas</label>\r\n                        ");
                __builder2.OpenElement(71, "input");
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddAttribute(73, "value", 
#nullable restore
#line 34 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                                                            Order.Customer.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(74, "id", "customer-email");
                __builder2.AddAttribute(75, "disabled", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "card mb-3");
                __builder2.AddMarkupContent(82, "\r\n                ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "card-body");
                __builder2.AddMarkupContent(85, "\r\n                    ");
                __builder2.AddMarkupContent(86, "<h4 class=\"card-title\">Prekės</h4>\r\n");
#nullable restore
#line 41 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                     foreach (var orderItem in Order.OrderItems)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(87, "                        <hr>\r\n                        ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group");
                __builder2.AddMarkupContent(90, "\r\n                            ");
                __builder2.AddMarkupContent(91, "<label>Pavadinimas</label>\r\n                            ");
                __builder2.OpenElement(92, "input");
                __builder2.AddAttribute(93, "class", "form-control");
                __builder2.AddAttribute(94, "value", 
#nullable restore
#line 46 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                                                                orderItem.Product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(95, "disabled", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                        ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-group");
                __builder2.AddMarkupContent(100, "\r\n                            ");
                __builder2.AddMarkupContent(101, "<label>Aprašymas</label>\r\n                            ");
                __builder2.OpenElement(102, "textarea");
                __builder2.AddAttribute(103, "class", "form-control");
                __builder2.AddAttribute(104, "value", 
#nullable restore
#line 50 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                                                                    String.IsNullOrEmpty(orderItem.Product.Description) ? "-" : orderItem.Product.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(105, "disabled", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                        ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "form-group");
                __builder2.AddMarkupContent(110, "\r\n                            ");
                __builder2.AddMarkupContent(111, "<label>Kiekis</label>\r\n                            ");
                __builder2.OpenElement(112, "input");
                __builder2.AddAttribute(113, "class", "form-control");
                __builder2.AddAttribute(114, "value", 
#nullable restore
#line 54 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                                                                orderItem.Quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(115, "disabled", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n");
#nullable restore
#line 56 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(118, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n            ");
                __builder2.OpenElement(121, "div");
                __builder2.AddAttribute(122, "class", "form-group");
                __builder2.AddMarkupContent(123, "\r\n                ");
                __builder2.AddMarkupContent(124, "<label for=\"orderStatus\">Užsakymo būsena</label>\r\n                ");
                __Blazor.Lenta.Web.Pages.Orders.CustomerOrderEdit.TypeInference.CreateInputSelect_0(__builder2, 125, 126, "form-control", 127, "orderStatus", 128, 
#nullable restore
#line 61 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                                                               OrderUpdate.Status

#line default
#line hidden
#nullable disable
                , 129, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OrderUpdate.Status = __value, OrderUpdate.Status)), 130, () => OrderUpdate.Status, 131, (__builder3) => {
                    __builder3.AddMarkupContent(132, "\r\n");
#nullable restore
#line 62 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                     foreach (var orderStatus in Enum.GetValues(typeof(CustomerOrderStatus)))
                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(133, "                        ");
                    __builder3.OpenElement(134, "option");
                    __builder3.AddAttribute(135, "value", 
#nullable restore
#line 64 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                                        orderStatus

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(136, 
#nullable restore
#line 64 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                                                      orderStatus

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(137, "\r\n");
#nullable restore
#line 65 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(138, "                ");
                }
                );
                __builder2.AddMarkupContent(139, "\r\n                ");
                __Blazor.Lenta.Web.Pages.Orders.CustomerOrderEdit.TypeInference.CreateValidationMessage_1(__builder2, 140, 141, 
#nullable restore
#line 67 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
                                          () => OrderUpdate.Status

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(142, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n\r\n            ");
                __builder2.AddMarkupContent(144, "<button type=\"submit\" class=\"btn btn-success\">Redaguoti</button>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(145, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n");
#nullable restore
#line 73 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Orders\CustomerOrderEdit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Lenta.Web.Pages.Orders.CustomerOrderEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
