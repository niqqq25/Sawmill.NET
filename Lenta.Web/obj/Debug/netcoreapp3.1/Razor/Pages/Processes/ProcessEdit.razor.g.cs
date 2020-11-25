#pragma checksum "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Processes\ProcessEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17b7891b18e5efaca7fd96db2b8c7a317f3b2a8c"
// <auto-generated/>
#pragma warning disable 1591
namespace Lenta.Web.Pages.Processes
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
#line 3 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Processes\ProcessEdit.razor"
           [Authorize(Roles = "gamintojas")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/processes/edit/{id}")]
    public partial class ProcessEdit : ProcessEditBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Processes\ProcessEdit.razor"
 if (Process != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, "<h1 class=\"mb-4\">Redaguoti gamybos procesą</h1>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Processes\ProcessEdit.razor"
                          Process

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Processes\ProcessEdit.razor"
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
                __builder2.AddMarkupContent(12, "<div class=\"form-group\">\r\n                <label for=\"name\">Pavadinimas</label>\r\n                <input id=\"name\" class=\"form-control\" value=\"Process.Name\" disabled>\r\n            </div>\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.AddMarkupContent(16, "<label for=\"description\">Aprašymas</label>\r\n                ");
                __builder2.OpenElement(17, "textarea");
                __builder2.AddAttribute(18, "id", "description");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "value", 
#nullable restore
#line 17 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Processes\ProcessEdit.razor"
                                                                         String.IsNullOrEmpty(Process.Description) ? "-" : Process.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(21, "disabled", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.AddMarkupContent(27, "<label for=\"processStatus\">Proceso būsena</label>\r\n                ");
                __Blazor.Lenta.Web.Pages.Processes.ProcessEdit.TypeInference.CreateInputSelect_0(__builder2, 28, 29, "form-control", 30, "processStatus", 31, 
#nullable restore
#line 21 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Processes\ProcessEdit.razor"
                                                               Process.Status

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Process.Status = __value, Process.Status)), 33, () => Process.Status, 34, (__builder3) => {
                    __builder3.AddMarkupContent(35, "\r\n");
#nullable restore
#line 22 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Processes\ProcessEdit.razor"
                     foreach (var processStatus in Enum.GetValues(typeof(ManufacturingProcessStatus)))
                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(36, "                        ");
                    __builder3.OpenElement(37, "option");
                    __builder3.AddAttribute(38, "value", 
#nullable restore
#line 24 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Processes\ProcessEdit.razor"
                                        processStatus

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(39, 
#nullable restore
#line 24 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Processes\ProcessEdit.razor"
                                                        processStatus

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\r\n");
#nullable restore
#line 25 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Processes\ProcessEdit.razor"
                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(41, "                ");
                }
                );
                __builder2.AddMarkupContent(42, "\r\n                ");
                __Blazor.Lenta.Web.Pages.Processes.ProcessEdit.TypeInference.CreateValidationMessage_1(__builder2, 43, 44, 
#nullable restore
#line 27 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Processes\ProcessEdit.razor"
                                          () => Process.Status

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n            ");
                __builder2.AddMarkupContent(47, "<button type=\"submit\" class=\"btn btn-success\">Redaguoti</button>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 33 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Processes\ProcessEdit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Lenta.Web.Pages.Processes.ProcessEdit
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