#pragma checksum "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\Academy\_parentstudentlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e842b228b3db2fcd046126e75cb2b3bffaa9cdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Academy__parentstudentlist), @"mvc.1.0.view", @"/Views/Academy/_parentstudentlist.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Academy/_parentstudentlist.cshtml", typeof(AspNetCore.Views_Academy__parentstudentlist))]
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
#line 1 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\_ViewImports.cshtml"
using AnezileAcademy;

#line default
#line hidden
#line 3 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\_ViewImports.cshtml"
using AnezileAcademy.Models;

#line default
#line hidden
#line 4 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\_ViewImports.cshtml"
using AnezileAcademy.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\_ViewImports.cshtml"
using AnezileAcademy.Models.ManageViewModels;

#line default
#line hidden
#line 1 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\Academy\_ViewImports.cshtml"
using AnezileAcademy.Views.Academy;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e842b228b3db2fcd046126e75cb2b3bffaa9cdc", @"/Views/Academy/_parentstudentlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb5893270d83184bb9a5d93e14754595d21ecb77", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7ff57338c320325ef553cdaf4d47e3610dffb04", @"/Views/Academy/_ViewImports.cshtml")]
    public class Views_Academy__parentstudentlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\Academy\_parentstudentlist.cshtml"
  
    ViewData["Title"] = "Teacher list";

#line default
#line hidden
            BeginContext(100, 4, true);
            WriteLiteral("<h4>");
            EndContext();
            BeginContext(105, 17, false);
#line 6 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\Academy\_parentstudentlist.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 11, true);
            WriteLiteral("</h4>\r\n<h4>");
            EndContext();
            BeginContext(134, 17, false);
#line 7 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\Academy\_parentstudentlist.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(151, 112, true);
            WriteLiteral("</h4>\r\n<table>\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Last Name</th>\r\n        <th>Space</th>\r\n    </tr>\r\n");
            EndContext();
#line 14 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\Academy\_parentstudentlist.cshtml"
     foreach (var user in (await UserManager.GetUsersInRoleAsync("Student")))
    {

#line default
#line hidden
            BeginContext(349, 16, true);
            WriteLiteral("        <tr><td>");
            EndContext();
            BeginContext(366, 14, false);
#line 16 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\Academy\_parentstudentlist.cshtml"
           Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(380, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(382, 13, false);
#line 16 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\Academy\_parentstudentlist.cshtml"
                           Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(395, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 17 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\Academy\_parentstudentlist.cshtml"
    }

#line default
#line hidden
            BeginContext(414, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(444, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(451, 52, false);
#line 21 "C:\Development\Anezile-Academy-Website\AnezileAcademy\Views\Academy\_parentstudentlist.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(503, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591