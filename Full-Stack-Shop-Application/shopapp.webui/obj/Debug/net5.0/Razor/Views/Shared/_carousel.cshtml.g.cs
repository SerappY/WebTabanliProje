#pragma checksum "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_carousel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19712b54a5bfa06842653e3a5cc5c9ab42d5a695"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__carousel), @"mvc.1.0.view", @"/Views/Shared/_carousel.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19712b54a5bfa06842653e3a5cc5c9ab42d5a695", @"/Views/Shared/_carousel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf6643d11f24c1a9db4b2ce2d237e0d4499f410", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__carousel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"carousel slide border\" id=\"mySlider\" data-bs-ride=\"carousel\">\n    <div class=\"carousel-indicators\">\n        <button type=\"button\" data-bs-target=\"#mySlider\" data-bs-slide-to=\"0\" class=\"active\"></button>\n");
#nullable restore
#line 6 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_carousel.cshtml"
         for (int i = 0; i < Model.Sliders.Count() - 1; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"button\" data-bs-target=\"#mySlider\" data-bs-slide-to=\"");
#nullable restore
#line 8 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_carousel.cshtml"
                                                                           Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></button>\n");
#nullable restore
#line 9 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_carousel.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n    <div class=\"carousel-inner\">\n");
#nullable restore
#line 13 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_carousel.cshtml"
         foreach (var item in Model.Sliders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 538, "\"", 586, 2);
            WriteAttributeValue("", 546, "carousel-item", 546, 13, true);
#nullable restore
#line 15 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_carousel.cshtml"
WriteAttributeValue(" ", 559, item.Active?"active":"", 560, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-interval=\"4000\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 633, "\"", 665, 2);
            WriteAttributeValue("", 639, "/img/slider/", 639, 12, true);
#nullable restore
#line 16 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_carousel.cshtml"
WriteAttributeValue("", 651, item.ImageUrl, 651, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 666, "\"", 715, 5);
            WriteAttributeValue("", 674, "d-block", 674, 7, true);
            WriteAttributeValue(" ", 681, "w-100", 682, 6, true);
            WriteAttributeValue(" ", 687, "Image_", 688, 7, true);
#nullable restore
#line 16 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_carousel.cshtml"
WriteAttributeValue("", 694, item.Order, 694, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 705, "img-fluid", 706, 10, true);
            EndWriteAttribute();
            WriteLiteral(">\n");
            WriteLiteral("\n                <script src=\"https://code.jquery.com/jquery-3.5.1.js\"></script>\n                <script>\n                    $(document).ready(function() {\n                        ResponsiveImages(\"Image_");
#nullable restore
#line 22 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_carousel.cshtml"
                                           Write(item.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\"");
#nullable restore
#line 22 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_carousel.cshtml"
                                                         Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\n                        $(window).resize(function() {\n                            ResponsiveImages(\"Image_");
#nullable restore
#line 24 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_carousel.cshtml"
                                               Write(item.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\"");
#nullable restore
#line 24 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_carousel.cshtml"
                                                             Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\n                        });\n                    });\n                </script>\n            </div>\n");
#nullable restore
#line 29 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_carousel.cshtml"
        }        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>

    <button type=""button"" class=""carousel-control-prev"" data-bs-target=""#mySlider"" data-bs-slide=""prev"">
        <span class=""carousel-control-prev-icon carouselControlButtons""></span>
    </button>
    <button type=""button"" class=""carousel-control-next"" data-bs-target=""#mySlider"" data-bs-slide=""next"">
        <span class=""carousel-control-next-icon carouselControlButtons""></span>
    </button>
</div>   ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
