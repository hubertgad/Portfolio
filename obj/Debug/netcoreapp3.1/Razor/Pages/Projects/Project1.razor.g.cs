#pragma checksum "C:\Users\player_one\source\repos\Portfolio\Pages\Projects\Project1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e37d1065569c0b0d601431707497fdd8369d090"
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
            __builder.AddAttribute(1, "class", "mb-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(3);
            __builder.AddAttribute(4, "class", "btn btn-content");
            __builder.AddAttribute(5, "href", "/projects");
            __builder.AddAttribute(6, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 4 "C:\Users\player_one\source\repos\Portfolio\Pages\Projects\Project1.razor"
                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(8, "Go back to projects");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.AddMarkupContent(11, "<p><h3>Software installer for Windows 10 - <span class=\"polyzynger\">Polyzynger</span></h3></p>\r\n\r\n");
            __builder.AddMarkupContent(12, @"<div class=""my-2"">
    <h3>What?</h3>
    <span>
        Polyzynger is a simple WPF application that <b>finds</b> the latest version, <b>downloads</b> and <b>installs</b> software on Windows.
        Also, it additionally copies some resources and executes PowerShell scripts if necessary.
    </span>
</div>

");
            __builder.AddMarkupContent(13, "<div class=\"my-2\">\r\n    <h3>Why?</h3>\r\n    <span>\r\n        I have created it to make work in my department easier and faster.\r\n    </span>\r\n</div>\r\n\r\n");
            __builder.AddMarkupContent(14, @"<div class=""my-2"">
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
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "my-2");
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.AddMarkupContent(18, "<h3>Pictures</h3>\r\n    ");
            __builder.OpenComponent<Portfolio.Shared.PhotoGallery>(19);
            __builder.AddAttribute(20, "Images", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 54 "C:\Users\player_one\source\repos\Portfolio\Pages\Projects\Project1.razor"
                          Images

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.AddMarkupContent(23, "<div class=\"my-2\">\r\n    <h3>Resources</h3>\r\n    <button class=\"btn btn-content\">Download Link</button>\r\n    <button class=\"btn btn-content\">GitHub Repository</button>\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\player_one\source\repos\Portfolio\Pages\Projects\Project1.razor"
       
    public List<string> Images { get; set; } = new List<string>
    { "/images/polyzynger.png", "/images/polyzynger2.png" };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
