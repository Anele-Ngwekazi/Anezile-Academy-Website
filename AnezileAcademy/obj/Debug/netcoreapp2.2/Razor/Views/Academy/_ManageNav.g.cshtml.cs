#pragma checksum "C:\Users\Anele\source\repos\AnezileAcademyWebsite\AnezileAcademy\Views\Academy\_ManageNav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15eef84881695da96a15232166e1c4fa83660515"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Academy__ManageNav), @"mvc.1.0.view", @"/Views/Academy/_ManageNav.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Academy/_ManageNav.cshtml", typeof(AspNetCore.Views_Academy__ManageNav))]
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
#line 1 "C:\Users\Anele\source\repos\AnezileAcademyWebsite\AnezileAcademy\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Anele\source\repos\AnezileAcademyWebsite\AnezileAcademy\Views\_ViewImports.cshtml"
using AnezileAcademy;

#line default
#line hidden
#line 3 "C:\Users\Anele\source\repos\AnezileAcademyWebsite\AnezileAcademy\Views\_ViewImports.cshtml"
using AnezileAcademy.Models;

#line default
#line hidden
#line 4 "C:\Users\Anele\source\repos\AnezileAcademyWebsite\AnezileAcademy\Views\_ViewImports.cshtml"
using AnezileAcademy.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\Anele\source\repos\AnezileAcademyWebsite\AnezileAcademy\Views\_ViewImports.cshtml"
using AnezileAcademy.Models.ManageViewModels;

#line default
#line hidden
#line 1 "C:\Users\Anele\source\repos\AnezileAcademyWebsite\AnezileAcademy\Views\Academy\_ManageNav.cshtml"
using AnezileAcademy.Views.Academy;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15eef84881695da96a15232166e1c4fa83660515", @"/Views/Academy/_ManageNav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb5893270d83184bb9a5d93e14754595d21ecb77", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7ff57338c320325ef553cdaf4d47e3610dffb04", @"/Views/Academy/_ViewImports.cshtml")]
    public class Views_Academy__ManageNav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Exercises", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Assignemnts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Tests", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 49, true);
            WriteLiteral("\r\n<ul class=\"nav nav-pills nav-stacked\">\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 86, "\"", 136, 1);
#line 4 "C:\Users\Anele\source\repos\AnezileAcademyWebsite\AnezileAcademy\Views\Academy\_ManageNav.cshtml"
WriteAttributeValue("", 94, ManageNavPages.IndexNavClass(ViewContext), 94, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(137, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(138, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15eef84881695da96a15232166e1c4fa836605155841", async() => {
                BeginContext(160, 7, true);
                WriteLiteral("Academy");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(171, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 5 "C:\Users\Anele\source\repos\AnezileAcademyWebsite\AnezileAcademy\Views\Academy\_ManageNav.cshtml"
     if (true)
    {

#line default
#line hidden
            BeginContext(201, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 212, "\"", 266, 1);
#line 7 "C:\Users\Anele\source\repos\AnezileAcademyWebsite\AnezileAcademy\Views\Academy\_ManageNav.cshtml"
WriteAttributeValue("", 220, ManageNavPages.ExercisesNavClass(ViewContext), 220, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(267, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(268, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15eef84881695da96a15232166e1c4fa836605157931", async() => {
                BeginContext(294, 9, true);
                WriteLiteral("Exercises");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(307, 18, true);
            WriteLiteral("</li>\r\n        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 325, "\"", 381, 1);
#line 8 "C:\Users\Anele\source\repos\AnezileAcademyWebsite\AnezileAcademy\Views\Academy\_ManageNav.cshtml"
WriteAttributeValue("", 333, ManageNavPages.AssignmentsNavClass(ViewContext), 333, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(382, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(383, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15eef84881695da96a15232166e1c4fa836605159764", async() => {
                BeginContext(411, 11, true);
                WriteLiteral("Assignemnts");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(426, 18, true);
            WriteLiteral("</li>\r\n        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 444, "\"", 494, 1);
#line 9 "C:\Users\Anele\source\repos\AnezileAcademyWebsite\AnezileAcademy\Views\Academy\_ManageNav.cshtml"
WriteAttributeValue("", 452, ManageNavPages.TestsNavClass(ViewContext), 452, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(495, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(496, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15eef84881695da96a15232166e1c4fa8366051511594", async() => {
                BeginContext(518, 5, true);
                WriteLiteral("Tests");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(527, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 10 "C:\Users\Anele\source\repos\AnezileAcademyWebsite\AnezileAcademy\Views\Academy\_ManageNav.cshtml"
    }

#line default
#line hidden
            BeginContext(541, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
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
