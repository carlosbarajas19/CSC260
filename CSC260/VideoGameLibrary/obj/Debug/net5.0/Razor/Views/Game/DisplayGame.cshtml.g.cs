#pragma checksum "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\DisplayGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a26350555c235fc3c458d95f679bd6463794274"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_DisplayGame), @"mvc.1.0.view", @"/Views/Game/DisplayGame.cshtml")]
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
#line 1 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\_ViewImports.cshtml"
using VideoGameLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\_ViewImports.cshtml"
using VideoGameLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a26350555c235fc3c458d95f679bd6463794274", @"/Views/Game/DisplayGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a2c432bacd9f2dd25c96536f8fcc9586e649a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_DisplayGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Game>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Game", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\DisplayGame.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>No Games provided</h1>\r\n");
#nullable restore
#line 8 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\DisplayGame.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"text-center\">");
#nullable restore
#line 12 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\DisplayGame.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <div class=\"float-left\">\r\n        <h5>Year: ");
#nullable restore
#line 14 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\DisplayGame.cshtml"
             Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5>Rating: ");
#nullable restore
#line 15 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\DisplayGame.cshtml"
               Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a26350555c235fc3c458d95f679bd64637942745574", async() => {
                WriteLiteral("\r\n            <input type=\"number\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 367, "\"", 384, 1);
#nullable restore
#line 18 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\DisplayGame.cshtml"
WriteAttributeValue("", 375, Model.ID, 375, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden=\"hidden\" />\r\n            <button class=\"w-auto\" type=\"submit\">Rent</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"game-cover float-right\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 555, "\"", 577, 1);
#nullable restore
#line 24 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\DisplayGame.cshtml"
WriteAttributeValue("", 561, Model.ImagePath, 561, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\DisplayGame.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
