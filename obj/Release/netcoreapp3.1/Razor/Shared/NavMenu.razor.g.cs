#pragma checksum "C:\Users\player_one\source\repos\Portfolio\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0121da95eb447f5c6d766b567de74dee8b02860"
// <auto-generated/>
#pragma warning disable 1591
namespace Portfolio.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\player_one\source\repos\Portfolio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\player_one\source\repos\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\player_one\source\repos\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\player_one\source\repos\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\player_one\source\repos\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\player_one\source\repos\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\player_one\source\repos\Portfolio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\player_one\source\repos\Portfolio\_Imports.razor"
using Portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\player_one\source\repos\Portfolio\_Imports.razor"
using Portfolio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\player_one\source\repos\Portfolio\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\player_one\source\repos\Portfolio\_Imports.razor"
using Portfolio.Email;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar-expand-md navbar-dark bg-black sticky-top");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.AddMarkupContent(3, @"<div class=""navbar-toggler bg-black text-white border-0 rounded-0 text-center"" type=""button"" data-toggle=""collapse"" data-target=""#navmenu"" aria-controls=""#navmenu"" aria-expanded=""false"" aria-label=""Navigation toogler"">
        <span class=""navbar-toggler-icon""></span> Menu
    </div>

    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "collapse navbar-collapse custom-navmenu pt-1");
            __builder.AddAttribute(6, "id", "navmenu");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "navbar-nav m-md-auto");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "nav-item");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "class", "nav-link btn-menu mr-md-2");
            __builder.AddAttribute(16, "href", "");
            __builder.AddAttribute(17, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\player_one\source\repos\Portfolio\Shared\NavMenu.razor"
                                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(19, "Intro");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "class", "nav-item");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(25);
            __builder.AddAttribute(26, "class", "nav-link btn-menu mr-md-2");
            __builder.AddAttribute(27, "href", "expertise");
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(29, "Expertise");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "nav-item");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
            __builder.AddAttribute(36, "class", "nav-link btn-menu mr-md-2");
            __builder.AddAttribute(37, "href", "projects");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(39, "Projects");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "li");
            __builder.AddAttribute(43, "class", "nav-item");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
            __builder.AddAttribute(46, "class", "nav-link btn-menu mr-md-2");
            __builder.AddAttribute(47, "href", "contact");
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(49, "Contact");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
