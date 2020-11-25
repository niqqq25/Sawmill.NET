#pragma checksum "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f095dbc307265d073016e8804814cf7fd67488a1"
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
#line 3 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
           [Authorize(Roles = "adminas")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/users/create")]
    public partial class UserCreate : UserCreateBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Sukurti darbuotojo paskyrą</h1>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                  User

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                        HandleUserCreate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "d-flex");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group flex-fill mr-3");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.AddMarkupContent(14, "<label for=\"user-firstname\">Vardas</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "id", "user-firstname");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                                         User.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.FirstName = __value, User.FirstName))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __Blazor.Lenta.Web.Pages.Administarion.UserCreate.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 12 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                      () => User.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group flex-fill");
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.AddMarkupContent(29, "<label for=\"user-lastname\">Pavardė</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "id", "user-lastname");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                                         User.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.LastName = __value, User.LastName))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __Blazor.Lenta.Web.Pages.Administarion.UserCreate.TypeInference.CreateValidationMessage_1(__builder2, 37, 38, 
#nullable restore
#line 17 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                      () => User.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.AddMarkupContent(45, "<label for=\"user-email\">Elektroninis paštas</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "id", "user-email");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                                     User.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.Email = __value, User.Email))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __Blazor.Lenta.Web.Pages.Administarion.UserCreate.TypeInference.CreateValidationMessage_2(__builder2, 53, 54, 
#nullable restore
#line 23 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                  () => User.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(55, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.AddMarkupContent(60, "<label for=\"user-password\">Slaptažodis</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "type", "password");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "id", "user-password");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                                                     User.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.Password = __value, User.Password))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n        ");
                __Blazor.Lenta.Web.Pages.Administarion.UserCreate.TypeInference.CreateValidationMessage_3(__builder2, 69, 70, 
#nullable restore
#line 28 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                  () => User.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n    ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group");
                __builder2.AddMarkupContent(75, "\r\n        ");
                __builder2.AddMarkupContent(76, "<label for=\"user-password-confirm\">Pakartokite slaptažodį</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(77);
                __builder2.AddAttribute(78, "type", "password");
                __builder2.AddAttribute(79, "class", "form-control");
                __builder2.AddAttribute(80, "id", "user-password-confirm");
                __builder2.AddAttribute(81, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                                                     User.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.ConfirmPassword = __value, User.ConfirmPassword))));
                __builder2.AddAttribute(83, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __Blazor.Lenta.Web.Pages.Administarion.UserCreate.TypeInference.CreateValidationMessage_4(__builder2, 85, 86, 
#nullable restore
#line 33 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                  () => User.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(87, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n    ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group");
                __builder2.AddMarkupContent(91, "\r\n        ");
                __builder2.AddMarkupContent(92, "<label for=\"role\">Pareigos</label>\r\n        ");
                __Blazor.Lenta.Web.Pages.Administarion.UserCreate.TypeInference.CreateInputSelect_5(__builder2, 93, 94, "form-control", 95, "role", 96, 
#nullable restore
#line 37 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                                       User.Role

#line default
#line hidden
#nullable disable
                , 97, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.Role = __value, User.Role)), 98, () => User.Role, 99, (__builder3) => {
                    __builder3.AddMarkupContent(100, "\r\n            ");
                    __builder3.AddMarkupContent(101, "<option value>-</option>\r\n");
#nullable restore
#line 39 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
             foreach (var role in Roles)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(102, "                ");
                    __builder3.OpenElement(103, "option");
                    __builder3.AddAttribute(104, "value", 
#nullable restore
#line 41 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                role.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(105, 
#nullable restore
#line 41 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                            role.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\r\n");
#nullable restore
#line 42 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(107, "        ");
                }
                );
                __builder2.AddMarkupContent(108, "\r\n        ");
                __Blazor.Lenta.Web.Pages.Administarion.UserCreate.TypeInference.CreateValidationMessage_6(__builder2, 109, 110, 
#nullable restore
#line 44 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Administarion\UserCreate.razor"
                                  () =>User.Role

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(111, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n    ");
                __builder2.AddMarkupContent(113, "<button type=\"submit\" class=\"btn btn-success\">Sukurti</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Lenta.Web.Pages.Administarion.UserCreate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
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
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
