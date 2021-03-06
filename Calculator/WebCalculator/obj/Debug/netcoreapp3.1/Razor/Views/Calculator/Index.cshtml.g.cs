#pragma checksum "D:\Tests\Calculator\Calculator\WebCalculator\Views\Calculator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d89c14a6c66423cdc8ef5d500d5e69ab916f40a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Index), @"mvc.1.0.view", @"/Views/Calculator/Index.cshtml")]
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
#line 1 "D:\Tests\Calculator\Calculator\WebCalculator\Views\_ViewImports.cshtml"
using WebCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tests\Calculator\Calculator\WebCalculator\Views\_ViewImports.cshtml"
using WebCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d89c14a6c66423cdc8ef5d500d5e69ab916f40a4", @"/Views/Calculator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea914b35850a00275709f524f4b0ae27c2788f89", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CalculatorService/CalculatorService.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Calculator.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Tests\Calculator\Calculator\WebCalculator\Views\Calculator\Index.cshtml"
  
    ViewData["Title"] = "Calculator";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    html {
        font-size: 62.5%;
        box-sizing: border-box;
    }

    *,
    *::before,
    *::after {
        margin: 0;
        padding: 0;
        box-sizing: inherit;
    }

    .calculator {
        border: 1px solid #ccc;
        border-radius: 5px;
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        width: 400px;
    }

    .calculator-screen {
        width: 100%;
        height: 80px;
        border: none;
        background-color: #252525;
        color: #fff;
        text-align: right;
        padding-right: 20px;
        padding-left: 10px;
        font-size: 4rem;
    }

    button {
        height: 60px;
        font-size: 2rem !important;
    }

    .equal-sign {
        height: 98%;
        grid-area: 2 / 4 / 6 / 5;
    }

    .calculator-keys {
        display: grid;
        grid-template-columns: repeat(4, 1fr);
        grid-gap: 20px;
        padding: 20px;
   ");
            WriteLiteral(" }\r\n</style>\r\n<section>\r\n    <div class=\"container my-4\">\r\n        <div class=\"calculator card\">\r\n");
            WriteLiteral("            <div id=\"divDisplay\">\r\n                <input type=\"text\" id=\"display\" class=\"calculator-screen z-depth-1\"");
            BeginWriteAttribute("value", " value=\"", 1393, "\"", 1401, 0);
            EndWriteAttribute();
            WriteLiteral(@" disabled />
            </div>
            <div class=""calculator-keys"">

                <button type=""button"" onclick=""addOperator(this)"" class=""operator btn btn-info"" value=""+"">+</button>
                <button type=""button"" onclick=""addOperator(this)"" class=""operator btn btn-info"" value=""-"">-</button>
                <button type=""button"" onclick=""addOperator(this)"" class=""operator btn btn-info"" value=""*"">&times;</button>
                <button type=""button"" onclick=""addOperator(this)"" class=""operator btn btn-info"" value=""/"">&divide;</button>

                <button type=""button"" value=""7"" onclick=""addToDisplay(this)"" class=""btn btn-light waves-effect"">7</button>
                <button type=""button"" value=""8"" onclick=""addToDisplay(this)"" class=""btn btn-light waves-effect"">8</button>
                <button type=""button"" value=""9"" onclick=""addToDisplay(this)"" class=""btn btn-light waves-effect"">9</button>


                <button type=""button"" value=""4"" onclick=""addToDisplay(this)"" class");
            WriteLiteral(@"=""btn btn-light waves-effect"">4</button>
                <button type=""button"" value=""5"" onclick=""addToDisplay(this)"" class=""btn btn-light waves-effect"">5</button>
                <button type=""button"" value=""6"" onclick=""addToDisplay(this)"" class=""btn btn-light waves-effect"">6</button>


                <button type=""button"" value=""1"" onclick=""addToDisplay(this)"" class=""btn btn-light waves-effect"">1</button>
                <button type=""button"" value=""2"" onclick=""addToDisplay(this)"" class=""btn btn-light waves-effect"">2</button>
                <button type=""button"" value=""3"" onclick=""addToDisplay(this)"" class=""btn btn-light waves-effect"">3</button>


                <button type=""button"" value=""0"" onclick=""addToDisplay(this)"" class=""btn btn-light waves-effect"">0</button>
                <button type=""button"" value=""."" onclick=""addToDisplay(this)"" class=""decimal function btn btn-secondary"">.</button>
                <button type=""button"" value=""all-clear"" onclick=""initial()"" class=""all-clear funct");
            WriteLiteral("ion btn btn-danger btn-sm\">AC</button>\r\n\r\n                <button type=\"button\" value=\"=\" onclick=\"calculate();\" class=\"equal-sign operator btn btn-default\">=</button>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d89c14a6c66423cdc8ef5d500d5e69ab916f40a48126", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d89c14a6c66423cdc8ef5d500d5e69ab916f40a49225", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
