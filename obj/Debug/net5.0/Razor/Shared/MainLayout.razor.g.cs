#pragma checksum "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b76dc8ebbd3ced8353ef2ff842f319a7076ef411801aed30766ac687a52edf1d"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using UseCases;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "header");
            __builder.AddAttribute(1, "class", "site-header sticky-top py-1");
            __builder.AddAttribute(2, "b-snfefjgk3b");
            __builder.OpenElement(3, "nav");
            __builder.AddAttribute(4, "class", "container d-flex flex-column flex-md-row justify-content-between");
            __builder.AddAttribute(5, "b-snfefjgk3b");
            __builder.AddMarkupContent(6, @"<a class=""py-2"" href=""#"" aria-label=""Product"" b-snfefjgk3b><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" fill=""none"" stroke=""currentColor"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" class=""d-block mx-auto"" role=""img"" viewBox=""0 0 24 24"" b-snfefjgk3b><title b-snfefjgk3b>Product</title><circle cx=""12"" cy=""12"" r=""10"" b-snfefjgk3b></circle><path d=""M14.31 8l5.74 9.94M9.69 8h11.48M7.38 12l5.74-9.94M9.69 16L3.95 6.06M14.31 16H2.83m13.79-4l-5.74 9.94"" b-snfefjgk3b></path></svg></a>
    ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "class", (object)("py-2 d-none d-md-inline-block"));
            __builder.AddAttribute(9, "href", (object)(""));
            __builder.AddAttribute(10, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 9 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Shared\MainLayout.razor"
                                                                  NavLinkMatch.All

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-snfefjgk3b></span> Home\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "class", (object)("py-2 d-none d-md-inline-block"));
            __builder.AddAttribute(16, "href", (object)("cashier_console"));
            __builder.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-snfefjgk3b></span> Sell\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", (object)("py-2 d-none d-md-inline-block"));
            __builder.AddAttribute(22, "href", (object)("categories"));
            __builder.AddAttribute(23, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-snfefjgk3b></span> Categories\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "class", (object)("py-2 d-none d-md-inline-block"));
            __builder.AddAttribute(28, "href", (object)("products"));
            __builder.AddAttribute(29, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-snfefjgk3b></span> Products\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(32);
            __builder.AddAttribute(33, "class", (object)("py-2 d-none d-md-inline-block"));
            __builder.AddAttribute(34, "href", (object)("transactions"));
            __builder.AddAttribute(35, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-snfefjgk3b></span> Reports\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n\r\n    ");
            __builder.OpenComponent<global::WebApp.Shared.LoginDisplay>(38);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n");
            __builder.OpenElement(40, "main");
            __builder.AddAttribute(41, "class", "content px-4");
            __builder.AddAttribute(42, "b-snfefjgk3b");
#nullable restore
#line 32 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Shared\MainLayout.razor"
__builder.AddContent(43, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
