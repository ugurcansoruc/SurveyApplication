#pragma checksum "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdae76fb7810c166e77770cd9ab4cb7aa4490c9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Surveys), @"mvc.1.0.view", @"/Views/User/Surveys.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdae76fb7810c166e77770cd9ab4cb7aa4490c9a", @"/Views/User/Surveys.cshtml")]
    public class Views_User_Surveys : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SurveyApplication.SurveyDb.MvcWebUI.Models.AnswerListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "QuestionAnswer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
  
    Layout = "~/Views/_UserLayout.cshtml";
    int counter = 0;
    bool check = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <div class=\"col-md-2\">\r\n        ");
#nullable restore
#line 12 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
   Write(await Component.InvokeAsync("SurveyList2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n        <hr />\r\n");
#nullable restore
#line 17 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
         foreach (var question in Model.Questions)
        {
            check = false;
            var test = "";
            counter += 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>");
#nullable restore
#line 22 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
           Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 22 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                     Write(question.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <br />\r\n");
#nullable restore
#line 25 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
             foreach (var answer in Model.Answers)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                 if (answer.QuestionId == question.Id)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Soruyu yanıtladınız.</p>\r\n                    <p>\r\n                        Vermiş olduğunuz yanıt:\r\n");
#nullable restore
#line 32 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                         foreach (var option in Model.QuestionOptions)
                        {
                            if (answer.Choice == option.Id)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <b>");
#nullable restore
#line 36 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                              Write(option.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 37 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\r\n");
#nullable restore
#line 40 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                    test = "hidden";
                    check = true;
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
             foreach (var answer in Model.Answers)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                 if (answer.QuestionId != question.Id && @check == false)
                {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                         foreach (var option in Model.QuestionOptions)
                        {
                            if (question.Id == option.QuestionId)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input class=\"form-check-input\" type=\"radio\" disabled>\r\n                                <label class=\"form-check-label\">\r\n                                    ");
#nullable restore
#line 55 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                               Write(option.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                                </label>\r\n");
#nullable restore
#line 57 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                         
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div ");
#nullable restore
#line 62 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
            Write(test);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdae76fb7810c166e77770cd9ab4cb7aa4490c9a10456", async() => {
                WriteLiteral("Yanıtla");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-surveyId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                                                                                                                WriteLiteral(question.SurveyId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["surveyId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-surveyId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["surveyId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
                                                                                                                                                          WriteLiteral(question.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questionId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-questionId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questionId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <hr />\r\n");
#nullable restore
#line 66 "C:\Users\ugurc\Source\Repos\SurveyApplication\SurveyApplication\SurveyApplication.SurveyDb.MvcWebUI\Views\User\Surveys.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"col-md-2\"></div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SurveyApplication.SurveyDb.MvcWebUI.Models.AnswerListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
