#pragma checksum "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca070b7140d7f6abf066bec0f78fe514bcedf4be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_AllSkills), @"mvc.1.0.view", @"/Views/Skill/AllSkills.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Skill/AllSkills.cshtml", typeof(AspNetCore.Views_Skill_AllSkills))]
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
#line 1 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\_ViewImports.cshtml"
using SkillTracker.Web;

#line default
#line hidden
#line 2 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\_ViewImports.cshtml"
using SkillTracker.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca070b7140d7f6abf066bec0f78fe514bcedf4be", @"/Views/Skill/AllSkills.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"658683c35201882e49be2989cbc26aa4dd6ea3d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Skill_AllSkills : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SkillTracker.Entities.Skill>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
  
    ViewData["Title"] = "AllSkills";

#line default
#line hidden
            BeginContext(96, 33, true);
            WriteLiteral("\r\n<h2>AllSkills</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "169478fc365a4c2f8a7b78f43d5d26f5", async() => {
                BeginContext(173, 12, true);
                WriteLiteral("Back to home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(189, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(282, 43, false);
#line 16 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayNameFor(model => model.SkillId));

#line default
#line hidden
            EndContext();
            BeginContext(325, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(381, 45, false);
#line 19 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayNameFor(model => model.SkillName));

#line default
#line hidden
            EndContext();
            BeginContext(426, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(482, 46, false);
#line 22 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayNameFor(model => model.SkillLevel));

#line default
#line hidden
            EndContext();
            BeginContext(528, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(584, 49, false);
#line 25 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayNameFor(model => model.SkillCategory));

#line default
#line hidden
            EndContext();
            BeginContext(633, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(689, 45, false);
#line 28 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayNameFor(model => model.SkillType));

#line default
#line hidden
            EndContext();
            BeginContext(734, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(790, 42, false);
#line 31 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayNameFor(model => model.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(832, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(888, 56, false);
#line 34 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayNameFor(model => model.SkillTotalExperiance));

#line default
#line hidden
            EndContext();
            BeginContext(944, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1062, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1111, 42, false);
#line 43 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayFor(modelItem => item.SkillId));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1209, 44, false);
#line 46 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayFor(modelItem => item.SkillName));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1309, 45, false);
#line 49 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayFor(modelItem => item.SkillLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1410, 48, false);
#line 52 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayFor(modelItem => item.SkillCategory));

#line default
#line hidden
            EndContext();
            BeginContext(1458, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1514, 44, false);
#line 55 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayFor(modelItem => item.SkillType));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1614, 41, false);
#line 58 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayFor(modelItem => item.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1711, 55, false);
#line 61 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.DisplayFor(modelItem => item.SkillTotalExperiance));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1822, 43, false);
#line 64 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
           Write(Html.ActionLink("Edit", "update", "skill" ));

#line default
#line hidden
            EndContext();
            BeginContext(1865, 17, true);
            WriteLiteral("\r\n               ");
            EndContext();
            BeginContext(1883, 44, false);
#line 65 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
          Write(Html.ActionLink("Delete", "delete", "skill"));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 68 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeSolution\SkillTracker\SkillTracker\SkillTracker.Web\Views\Skill\AllSkills.cshtml"
}

#line default
#line hidden
            BeginContext(1966, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SkillTracker.Entities.Skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591