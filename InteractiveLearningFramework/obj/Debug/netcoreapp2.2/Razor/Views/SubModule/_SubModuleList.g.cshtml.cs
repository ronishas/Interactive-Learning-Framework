#pragma checksum "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\SubModule\_SubModuleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e004a4535ce6f557ef3f9f9eb3bf9ce1c8d7f779"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SubModule__SubModuleList), @"mvc.1.0.view", @"/Views/SubModule/_SubModuleList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SubModule/_SubModuleList.cshtml", typeof(AspNetCore.Views_SubModule__SubModuleList))]
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
#line 1 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\_ViewImports.cshtml"
using InteractiveLearningFramework;

#line default
#line hidden
#line 2 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\_ViewImports.cshtml"
using InteractiveLearningFramework.Models;

#line default
#line hidden
#line 3 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\_ViewImports.cshtml"
using InteractiveLearningFramework.ViewModels;

#line default
#line hidden
#line 4 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\_ViewImports.cshtml"
using InteractiveLearningFramework.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\_ViewImports.cshtml"
using InteractiveLearningFramework.Models.ManageViewModels;

#line default
#line hidden
#line 6 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\_ViewImports.cshtml"
using InteractiveLearningFramework.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e004a4535ce6f557ef3f9f9eb3bf9ce1c8d7f779", @"/Views/SubModule/_SubModuleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ac79eb029c6d767b2353da98c3f2ef7a75d3c2d", @"/Views/_ViewImports.cshtml")]
    public class Views_SubModule__SubModuleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InteractiveLearningFramework.ViewModels.CourseModuleVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SubModule", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 239, true);
            WriteLiteral("\r\n<div class=\"accordion\" id=\"accordionExample\">\r\n    <div class=\"card bg-light mb-3\">\r\n        <div class=\"card-title\" id=\"headingFour\">\r\n            <button class=\"btn btn-link\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse_");
            EndContext();
            BeginContext(303, 14, false);
#line 6 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\SubModule\_SubModuleList.cshtml"
                                                                                                Write(Model.ModuleId);

#line default
#line hidden
            EndContext();
            BeginContext(317, 22, true);
            WriteLiteral("\" aria-expanded=\"true\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 339, "\"", 379, 2);
            WriteAttributeValue("", 355, "collapse_", 355, 9, true);
#line 6 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\SubModule\_SubModuleList.cshtml"
WriteAttributeValue("", 364, Model.ModuleId, 364, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(380, 61, true);
            WriteLiteral(">\r\n                <i class=\"fa icon\" aria-hidden=\"true\"></i>");
            EndContext();
            BeginContext(442, 11, false);
#line 7 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\SubModule\_SubModuleList.cshtml"
                                                     Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(453, 55, true);
            WriteLiteral("\r\n            </button>\r\n        </div>\r\n\r\n        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 508, "\"", 537, 2);
            WriteAttributeValue("", 513, "collapse_", 513, 9, true);
#line 11 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\SubModule\_SubModuleList.cshtml"
WriteAttributeValue("", 522, Model.ModuleId, 522, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(538, 128, true);
            WriteLiteral(" class=\"collapse show\" aria-labelledby=\"headingFour\" data-parent=\"#accordionExample\">\r\n            <div class=\"card-body\">\r\n\r\n\r\n");
            EndContext();
#line 15 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\SubModule\_SubModuleList.cshtml"
                  
                    foreach (var model in Model.SubModuleList)
                    {

                        

#line default
#line hidden
            BeginContext(800, 41, false);
#line 19 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\SubModule\_SubModuleList.cshtml"
                   Write(Html.Partial("_SubModuleItemList", model));

#line default
#line hidden
            EndContext();
#line 19 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\SubModule\_SubModuleList.cshtml"
                                                                  
                    }
                

#line default
#line hidden
            BeginContext(885, 22, true);
            WriteLiteral("\r\n\r\n\r\n                ");
            EndContext();
            BeginContext(907, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e004a4535ce6f557ef3f9f9eb3bf9ce1c8d7f7798403", async() => {
                BeginContext(1009, 14, true);
                WriteLiteral("Add Sub Module");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\project\CourseManagement-master\InteractiveLearningFramework\Views\SubModule\_SubModuleList.cshtml"
                                                                    WriteLiteral(Model.ModuleId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1027, 58, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InteractiveLearningFramework.ViewModels.CourseModuleVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
