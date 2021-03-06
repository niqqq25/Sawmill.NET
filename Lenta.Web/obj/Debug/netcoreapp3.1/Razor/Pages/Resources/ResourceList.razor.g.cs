#pragma checksum "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b090f7905e3fd3284aa650c46d0594f6bd61fbc9"
// <auto-generated/>
#pragma warning disable 1591
namespace Lenta.Web.Pages.Resources
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
#line 3 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
           [Authorize(Roles = "sandelininkas, klientuAptarnautojas")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/resources")]
    public partial class ResourceList : ResourceListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
 if (IsLoading == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row flow-offset-1");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, "<h1 class=\"mb-4\">Žaliavų katalogas</h1>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "w-100 d-flex justify-content-between mb-2");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Roles", "sandelininkas");
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n                    ");
                __builder2.AddMarkupContent(14, "<a class=\"btn btn-success btn-rounded btn-sm my-0 d-table\" style=\"color: white;\" href=\"resources/create\">Sukurti</a>\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "table-filter");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "filter-group ml-3");
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.AddMarkupContent(23, "<label>Pavadinimas</label>\r\n                    ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "class", "form-control form-control-sm ml-2");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                                                                                        SearchQuery

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchQuery = __value, SearchQuery));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "class", "btn btn-sm btn-primary ml-3");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                                                                                    HandleSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "\r\n                    <i class=\"fa fa-search\"></i>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.AddMarkupContent(42, "<thead>\r\n                <tr>\r\n                    <th>Pavadinimas</th>\r\n                    <th>Aprašymas</th>\r\n                    <th>Kiekis</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(43, "tbody");
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 35 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                 foreach (var resource in PagedResponse.Data)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                    ");
            __builder.OpenElement(46, "tr");
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 38 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                             resource.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "td");
            __builder.AddMarkupContent(52, "\r\n                            ");
            __builder.OpenElement(53, "pre");
            __builder.AddContent(54, 
#nullable restore
#line 40 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                                   String.IsNullOrEmpty(resource.Description) ? "-" : resource.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                        ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 42 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                              resource.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, " ");
            __builder.AddContent(60, 
#nullable restore
#line 42 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                                                   resource.QuantityType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "td");
            __builder.AddMarkupContent(63, "\r\n                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(64);
            __builder.AddAttribute(65, "Roles", "sandelininkas");
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(67, "\r\n                                ");
                __builder2.OpenElement(68, "a");
                __builder2.AddAttribute(69, "href", 
#nullable restore
#line 45 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                                           $"/resources/edit/{resource.Id}"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(70, "Redaguoti");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                                ");
                __builder2.AddMarkupContent(72, "<span>|</span>\r\n                                ");
                __builder2.OpenElement(73, "a");
                __builder2.AddAttribute(74, "href", "#");
                __builder2.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                                                        () => HandleResourceDelete(resource.Id, resource.Name)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddEventPreventDefaultAttribute(76, "onclick", true);
                __builder2.AddMarkupContent(77, "Ištrinti");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 51 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "w-100 d-flex justify-content-between");
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.OpenElement(88, "p");
            __builder.AddAttribute(89, "class", "text-secondary");
            __builder.AddMarkupContent(90, "\r\n                Rodomi\r\n                ");
            __builder.OpenElement(91, "b");
            __builder.AddContent(92, 
#nullable restore
#line 57 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                    PagedResponse.Data.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                įrašai iš\r\n                ");
            __builder.OpenElement(94, "b");
            __builder.AddContent(95, 
#nullable restore
#line 59 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                    PagedResponse.TotalRecords

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n            ");
            __builder.OpenElement(98, "ul");
            __builder.AddAttribute(99, "class", "pagination");
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.OpenElement(101, "li");
            __builder.AddAttribute(102, "class", "page-item" + " " + (
#nullable restore
#line 62 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                                       PagedResponse.PreviousPage != null ? "" : "disabled"

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.AddMarkupContent(103, "\r\n                    ");
            __builder.OpenElement(104, "a");
            __builder.AddAttribute(105, "class", "page-link");
            __builder.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                                                     () => HandlePageChange(PagedResponse.PageNumber - 1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(107, "Ankstesnis");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                ");
            __builder.OpenElement(110, "li");
            __builder.AddAttribute(111, "class", "page-item disabled");
            __builder.OpenElement(112, "a");
            __builder.AddAttribute(113, "class", "page-link");
            __builder.AddAttribute(114, "href", "#");
            __builder.AddContent(115, 
#nullable restore
#line 65 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                                                                              PagedResponse.PageNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                ");
            __builder.OpenElement(117, "li");
            __builder.AddAttribute(118, "class", "page-item" + " " + (
#nullable restore
#line 66 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                                       PagedResponse.NextPage != null ? "" : "disabled"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(119, "\r\n                    ");
            __builder.OpenElement(120, "a");
            __builder.AddAttribute(121, "class", "page-link");
            __builder.AddAttribute(122, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
                                                     () => HandlePageChange(PagedResponse.PageNumber + 1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(123, "Kitas");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n");
#nullable restore
#line 73 "C:\Users\Andrius\source\repos\Lenta\Lenta.Web\Pages\Resources\ResourceList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
