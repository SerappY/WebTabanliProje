#pragma checksum "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6215d3a8559412f2806cd6a03ef3c77aed531c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_UserAccount), @"mvc.1.0.view", @"/Views/Account/UserAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6215d3a8559412f2806cd6a03ef3c77aed531c2", @"/Views/Account/UserAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf6643d11f24c1a9db4b2ce2d237e0d4499f410", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_UserAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserAccountConfirmEmail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"container mb-5 pb-5\">\n    <h2>Hesap Detaylar??</h2>    \n    <hr>\n\n");
#nullable restore
#line 7 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
     if (TempData["message"] != null)
    {
        var message = JsonConvert.DeserializeObject<AlertMessage>(TempData["message"] as String);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
   Write(await Html.PartialAsync("_alert", message));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                                                   ;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 13 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
     if (Model.User.EmailConfirmed == false)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""alert alert-danger alert-dismissible fade show"">
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""19"" height=""19"" fill=""currentColor"" class=""bi bi-exclamation-circle-fill text-danger mb-1"" viewBox=""0 0 16 16"">
                <path d=""M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zM8 4a.905.905 0 0 0-.9.995l.35 3.507a.552.552 0 0 0 1.1 0l.35-3.507A.905.905 0 0 0 8 4zm.002 6a1 1 0 1 0 0 2 1 1 0 0 0 0-2z""/>
            </svg>
            <h5 class=""d-inline"">Dikkat ! Hesab??n??z onayl?? de??il</h5>
            <p class=""mt-2"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6215d3a8559412f2806cd6a03ef3c77aed531c27717", async() => {
                WriteLiteral("\n                    Email hesab??n??z onayl?? de??il, Hesab??n??z?? onaylamak i??in                 \n                    <button type=\"submit\" class=\"btn btn-link p-0 mb-1\">Buraya</button>\n                    t??klay??n??z\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n            </p>\n            <button class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\n        </div>\n");
#nullable restore
#line 29 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
    }    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 31 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
     if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-md-6 pt-4\">\n");
#nullable restore
#line 35 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                 if (TempData["message"] != null)
                {
                    var message = JsonConvert.DeserializeObject<AlertMessage>(TempData["message"] as String);
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
               Write(await Html.PartialAsync("_alert", message));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                                                               ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""mt-4 mb-3"">
                    <a href=""/"" class=""btn btn-secondary me-1""><i class=""fas fa-arrow-circle-left""></i> Geriye D??n</a>
                    <a href=""/account/login"" class=""btn btn-primary me-2""><i class=""fas fa-sign-in-alt""></i> Giri?? Yap</a>
                </div>                
            </div>

            <div class=""col-md-6"">
                <img src=""/img/svg/404.svg"" alt=""404 Not Found"" class=""w-100"">
            </div>
        </div>
");
#nullable restore
#line 50 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"

    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row mt-4 userInformation border rounded-3"">
            <div class=""col-md-4 userColumn bg-primary rounded-3 pb-3 pb-md-5"">
                <div class=""informationImage"">
                    <img src=""/img/icon/user_account_icon.png"" alt=""User Image"">
                </div>
                <h6 class=""text-white pb-md-5"">");
#nullable restore
#line 57 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                                           Write($"{Model.User.FirstName} {Model.User.LastName}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6> ");
            WriteLiteral("\n            </div>\n            <div class=\"col-md-8 py-2\">\n                <div class=\"row informationBody\">\n                    <div class=\"col-sm-4 mb-3 mb-sm-0\">\n                        <h5>Ad Soyad</h5>\n                        <span>");
#nullable restore
#line 63 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                          Write($"{Model.User.FirstName} {Model.User.LastName}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </div>\n                    <div class=\"col-sm-4 mb-3 mb-sm-0\">\n                        <h5>Kullan??c?? Ad??</h5>\n                        <span>");
#nullable restore
#line 67 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                         Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </div>\n                    <div class=\"col-sm-4\">\n                        <h5>??yelik Tarihi</h5>\n                        <span>");
#nullable restore
#line 71 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                         Write(Model.User.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                </div>
                <hr>
                <div class=""row informationfooter pb-4"">
                    <div class=""col-sm-4 mb-3 mb-sm-0"">
                        <h5>Email</h5>
                        <span>");
#nullable restore
#line 78 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                         Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </div>\n                    <div class=\"col-sm-4 mb-3 mb-sm-0 text-sm-center\">\n                        <h5>Email Onay??</h5>\n                        <span>                            \n");
#nullable restore
#line 83 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                             if (Model.User.EmailConfirmed)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Onayl?? <i class=\"bi bi-check-circle-fill text-success myBootstrapIcon\"></i></span>\n");
#nullable restore
#line 86 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                            } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Onayl?? De??il <i class=\"bi bi-x-circle-fill text-danger myBootstrapIcon\"></i></span>\n");
#nullable restore
#line 88 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </span>\n                    </div>\n                    <div class=\"col-sm-4\">\n                        <h5>Roller</h5>\n");
#nullable restore
#line 93 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                         foreach (var item in Model.UserRoles)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge bg-primary\">");
#nullable restore
#line 95 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                                                      Write(item.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 96 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 101 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Account\UserAccount.cshtml"
    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
