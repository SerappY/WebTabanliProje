#pragma checksum "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\Components\Category\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "367404bed8175266a83028fb0119badf6567375d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Category_default), @"mvc.1.0.view", @"/Views/Shared/Components/Category/default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"367404bed8175266a83028fb0119badf6567375d", @"/Views/Shared/Components/Category/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf6643d11f24c1a9db4b2ce2d237e0d4499f410", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Category_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<ul class=\"list-group\">\n    <a href=\"/category\"");
            BeginWriteAttribute("class", " class=\"", 70, "\"", 197, 2);
            WriteAttributeValue("", 78, "list-group-item", 78, 15, true);
#nullable restore
#line 4 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\Components\Category\default.cshtml"
WriteAttributeValue(" ", 93, ViewBag.CategoryAction == "CategoryList" && ViewBag.CategoryUrl == null?"bg-secondary text-white":"", 94, 103, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tüm Kategoriler</a>\n");
#nullable restore
#line 5 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\Components\Category\default.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 272, "\"", 302, 2);
            WriteAttributeValue("", 279, "/category/", 279, 10, true);
#nullable restore
#line 7 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\Components\Category\default.cshtml"
WriteAttributeValue("", 289, category.Url, 289, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 303, "\"", 408, 4);
            WriteAttributeValue("", 311, "list-group-item", 311, 15, true);
            WriteAttributeValue(" ", 326, "d-flex", 327, 7, true);
            WriteAttributeValue(" ", 333, "justify-content-between", 334, 24, true);
#nullable restore
#line 7 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\Components\Category\default.cshtml"
WriteAttributeValue(" ", 357, category.Url == ViewBag.CategoryUrl?"active":"", 358, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <span>");
#nullable restore
#line 8 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\Components\Category\default.cshtml"
             Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            <span class=\"badge bg-primary categoryBadge\">");
#nullable restore
#line 9 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\Components\Category\default.cshtml"
                                                    Write(TempData["CategoryCount"+category.CategoryId]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>            \n        </a>        \n");
#nullable restore
#line 11 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\Components\Category\default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
