#pragma checksum "C:\Users\player_one\source\repos\Portfolio\Pages\About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c03e50fc1586c061f5de6996a93dd5352b032ac"
// <auto-generated/>
#pragma warning disable 1591
namespace Portfolio.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/about")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "text-center");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"row\">\r\n        <h5>Languages I feel confident at:</h5>\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row mb-1");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Image>(7);
            __builder.AddAttribute(8, "Src", "https://image.freepik.com/free-vector/brush-stroke-flag-united-kingdom_1102-1017.jpg");
            __builder.AddAttribute(9, "Title", "English 🙂");
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Image>(11);
            __builder.AddAttribute(12, "Src", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/C_Sharp_logo.svg/1920px-C_Sharp_logo.svg.png");
            __builder.AddAttribute(13, "Title", "C#");
            __builder.AddAttribute(14, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 12 "C:\Users\player_one\source\repos\Portfolio\Pages\About.razor"
                                 0.25

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Image>(16);
            __builder.AddAttribute(17, "Src", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/HTML5_logo_and_wordmark.svg/512px-HTML5_logo_and_wordmark.svg.png");
            __builder.AddAttribute(18, "Title", "HTML");
            __builder.AddAttribute(19, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 14 "C:\Users\player_one\source\repos\Portfolio\Pages\About.razor"
                                   0.5

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Image>(21);
            __builder.AddAttribute(22, "Src", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d5/CSS3_logo_and_wordmark.svg/726px-CSS3_logo_and_wordmark.svg.png");
            __builder.AddAttribute(23, "Title", "CSS");
            __builder.AddAttribute(24, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 16 "C:\Users\player_one\source\repos\Portfolio\Pages\About.razor"
                                  0.75

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Image>(26);
            __builder.AddAttribute(27, "Src", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b2/Bootstrap_logo.svg/1200px-Bootstrap_logo.svg.png");
            __builder.AddAttribute(28, "Title", "Bootstrap");
            __builder.AddAttribute(29, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 18 "C:\Users\player_one\source\repos\Portfolio\Pages\About.razor"
                                        1.0

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Image>(31);
            __builder.AddAttribute(32, "Src", "https://cdn.db2tutorial.com/wp-content/uploads/2019/03/db2-tutorial.png");
            __builder.AddAttribute(33, "Title", "SQL");
            __builder.AddAttribute(34, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 20 "C:\Users\player_one\source\repos\Portfolio\Pages\About.razor"
                                  1.25

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n    ");
            __builder.AddMarkupContent(37, "<div class=\"row\">\r\n        <h5>Technologies I am enthusiastic about:</h5>\r\n    </div>\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "row mb-1");
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Image>(41);
            __builder.AddAttribute(42, "Src", "https://external-preview.redd.it/bS0gp46h0kZbUPSYmNqb8x3oBW4Vp9MRMzK6eb4wl7Q.jpg?auto=webp&s=3e43a464c2b169288ee8b0abd5201ca547356f79");
            __builder.AddAttribute(43, "Title", "Blazor");
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Image>(45);
            __builder.AddAttribute(46, "Src", "https://codeopinion.com/wp-content/uploads/2017/10/Bitmap-MEDIUM_Entity-Framework-Core-Logo_2colors_Square_Boxed_RGB.png");
            __builder.AddAttribute(47, "Title", "EF Core");
            __builder.AddAttribute(48, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 40 "C:\Users\player_one\source\repos\Portfolio\Pages\About.razor"
                                      0.25

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Image>(50);
            __builder.AddAttribute(51, "Src", "https://avatars0.githubusercontent.com/u/10635672?s=400&v=4");
            __builder.AddAttribute(52, "Title", "Identity Server");
            __builder.AddAttribute(53, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 42 "C:\Users\player_one\source\repos\Portfolio\Pages\About.razor"
                                              0.5

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n    ");
            __builder.AddMarkupContent(56, "<div class=\"row\">\r\n        <h5>I work using:</h5>\r\n    </div>\r\n    ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "row mb-1");
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Image>(60);
            __builder.AddAttribute(61, "Src", "https://visualstudio.microsoft.com/wp-content/uploads/2019/06/BrandVisualStudioWin2019-3.svg");
            __builder.AddAttribute(62, "Title", "Microsoft Visual Studio");
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Image>(64);
            __builder.AddAttribute(65, "Src", "https://github.githubassets.com/images/modules/logos_page/GitHub-Mark.png");
            __builder.AddAttribute(66, "Title", "GitHub");
            __builder.AddAttribute(67, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 54 "C:\Users\player_one\source\repos\Portfolio\Pages\About.razor"
                                     0.25

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Image>(69);
            __builder.AddAttribute(70, "Src", "https://www.postman.com/assets/logos/postman-logo-stacked.svg");
            __builder.AddAttribute(71, "Title", "Postman");
            __builder.AddAttribute(72, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 56 "C:\Users\player_one\source\repos\Portfolio\Pages\About.razor"
                                      0.5

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\r\n    ");
            __builder.AddMarkupContent(75, "<div class=\"row\">\r\n        <div><h5>Certifications and exams I have passed:</h5></div>\r\n    </div>\r\n    ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "row mb-1");
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Badge>(79);
            __builder.AddAttribute(80, "Href", "https://www.youracclaim.com/badges/a683933e-c79a-4cae-9dea-a71b705a57ce");
            __builder.AddAttribute(81, "Img", "https://images.youracclaim.com/size/680x680/images/4178e678-e9c8-42da-bc8c-e865d3d26db6/MTA-Software-Development-Fundamentals-2019.png");
            __builder.AddAttribute(82, "Alt", "MTA: Software Development Fundamentals - Certified 2019");
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.OpenComponent<Portfolio.Shared.Badge>(84);
            __builder.AddAttribute(85, "Href", "https://www.youracclaim.com/badges/135dc596-968c-4d40-9ca9-547ff4b98966");
            __builder.AddAttribute(86, "Img", "https://images.youracclaim.com/size/680x680/images/78e39333-d0db-4931-b231-13bdb37040cc/Programming_in_C_23-01.png");
            __builder.AddAttribute(87, "Alt", "Exam 483: Programming in C#");
            __builder.AddAttribute(88, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 68 "C:\Users\player_one\source\repos\Portfolio\Pages\About.razor"
                                                        0.25

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
