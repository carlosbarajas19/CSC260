#pragma checksum "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\GamePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cab2b2692385af8cb51b31d4c2f034bd0b8b6074"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_GamePartialView), @"mvc.1.0.view", @"/Views/Game/GamePartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cab2b2692385af8cb51b31d4c2f034bd0b8b6074", @"/Views/Game/GamePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a2c432bacd9f2dd25c96536f8fcc9586e649a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_GamePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Game>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\GamePartialView.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>No game provided</h1>\r\n");
#nullable restore
#line 6 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\GamePartialView.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n\r\n    <h3 class=\"text-center\">");
#nullable restore
#line 11 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\GamePartialView.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <div class=\"game-cover\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 180, "\"", 202, 1);
#nullable restore
#line 13 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\GamePartialView.cshtml"
WriteAttributeValue("", 186, Model.ImagePath, 186, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"float-left\">\r\n        <h5>Year: ");
#nullable restore
#line 16 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\GamePartialView.cshtml"
             Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5>Rating: ");
#nullable restore
#line 17 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\GamePartialView.cshtml"
               Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5>Platform: ");
#nullable restore
#line 18 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\GamePartialView.cshtml"
                 Write(Model.Platform.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5>Genre: ");
#nullable restore
#line 19 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\GamePartialView.cshtml"
              Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        \r\n    </div>\r\n\r\n\r\n</div>\r\n");
#nullable restore
#line 25 "C:\Users\cbarajas\source\repos\CSC260\CSC260\VideoGameLibrary\Views\Game\GamePartialView.cshtml"
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
