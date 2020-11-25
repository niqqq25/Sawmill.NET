#pragma checksum "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1024d509a6bfef35c0ddd8675d849f27815efc37"
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
#line 3 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderCreate.razor"
           [Authorize(Roles = "sandelininkas")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/morders/create")]
    public partial class ManufacturingOrderCreate : ManufacturingOrderCreateBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderCreate.razor"
 if (!IsLoading)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, "<h1 class=\"mb-4\">Sukurti gamybos užsakymą</h1>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderCreate.razor"
                          Order

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderCreate.razor"
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
                __builder2.AddMarkupContent(15, "<label for=\"name\">Produkto pavadinimas</label>\r\n                ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "id", "name");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "value", 
#nullable restore
#line 13 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderCreate.razor"
                                                              Product.Name

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
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.AddMarkupContent(26, "<label for=\"description\">Produkto aprašymas</label>\r\n                ");
                __builder2.OpenElement(27, "textarea");
                __builder2.AddAttribute(28, "id", "description");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "value", 
#nullable restore
#line 17 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderCreate.razor"
                                                                        Product.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(31, "disabled", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.AddMarkupContent(37, "<label for=\"quantity\">Kiekis</label>\r\n                ");
                __Blazor.Lenta.Web.Pages.ManufacturingOrders.ManufacturingOrderCreate.TypeInference.CreateInputNumber_0(__builder2, 38, 39, "quantity", 40, "form-control", 41, 
#nullable restore
#line 21 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderCreate.razor"
                                                                             Order.Quantity

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Order.Quantity = __value, Order.Quantity)), 43, () => Order.Quantity);
                __builder2.AddMarkupContent(44, "\r\n                ");
                __Blazor.Lenta.Web.Pages.ManufacturingOrders.ManufacturingOrderCreate.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 22 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderCreate.razor"
                                          () => Order.Quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n            ");
                __builder2.AddMarkupContent(49, "<button type=\"submit\" class=\"btn btn-success\">Sukurti</button>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 28 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\ManufacturingOrders\ManufacturingOrderCreate.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Lenta.Web.Pages.ManufacturingOrders.ManufacturingOrderCreate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
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
