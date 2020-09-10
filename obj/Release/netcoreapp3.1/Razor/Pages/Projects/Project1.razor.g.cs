#pragma checksum "C:\Users\player_one\source\repos\Portfolio\Pages\Projects\Project1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a34c6b1a49e6548811dd3ce3f3e7443f80bb125"
// <auto-generated/>
#pragma warning disable 1591
namespace Portfolio.Pages.Projects
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/projects/p1")]
    public partial class Project1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container vw-100");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "mb-3");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(6);
            __builder.AddAttribute(7, "class", "btn btn-content");
            __builder.AddAttribute(8, "href", "/projects");
            __builder.AddAttribute(9, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 5 "C:\Users\player_one\source\repos\Portfolio\Pages\Projects\Project1.razor"
                                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Go back to projects");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.AddMarkupContent(14, "<p><h3>Software installer for Windows 10 - <span class=\"polyzynger\">Polyzynger</span></h3></p>\r\n\r\n    ");
            __builder.AddMarkupContent(15, @"<div class=""my-2"">
        <h3>What?</h3>
        <span>
            Polyzynger is a simple WPF application that <b>finds</b> the latest version, <b>downloads</b> and <b>installs</b> software on Windows.
            Also, it additionally copies some resources and executes PowerShell scripts if necessary.
            To ensure that it will easily run even on an older and not updated Windows OS <b class=""polyzynger"">Polyzynger</b> uses .NET Framework 4.7.
        </span>
    </div>

    ");
            __builder.AddMarkupContent(16, "<div class=\"my-2\">\r\n        <h3>Why?</h3>\r\n        <span>\r\n            I have created it to make work in my department easier and faster.\r\n        </span>\r\n    </div>\r\n\r\n    ");
            __builder.AddMarkupContent(17, @"<div class=""my-2"">
        <h3>How?</h3>
        <span>It works in simple steps, @foreach selected application:</span>
        <ul>
            <li>
                <span>
                    (If necessary) scan demanded product's official website to check if there is a newer version. For this purpose use <b>Regex</b>.
                    If somethings new has come, estabilish new download link and check it.
                </span>
            </li>
            <li>
                <span>
                    Using <b>WebClient</b> download installer and save it in a temporary directory.
                </span>
            </li>
            <li>
                <span>
                    Silently <b>install</b> the application.
                </span>
            </li>
            <li>
                <span>
                    Delete temporary files.
                </span>
            </li>
        </ul>
    </div>

    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "my-2");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.AddMarkupContent(21, "<h3>Pictures</h3>\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.PhotoGallery>(22);
            __builder.AddAttribute(23, "Images", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 56 "C:\Users\player_one\source\repos\Portfolio\Pages\Projects\Project1.razor"
                              Images

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n    ");
            __builder.AddMarkupContent(26, "<div class=\"my-2\">\r\n        <h3>Resources</h3>\r\n        <button class=\"btn btn-content\">Download Link</button>\r\n        <button class=\"btn btn-content\">GitHub Repository</button>\r\n    </div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\player_one\source\repos\Portfolio\Pages\Projects\Project1.razor"
       
    public List<string> Images { get; set; } = new List<string>
        { "/images/polyzynger.png", "/images/polyzynger2.png" };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
