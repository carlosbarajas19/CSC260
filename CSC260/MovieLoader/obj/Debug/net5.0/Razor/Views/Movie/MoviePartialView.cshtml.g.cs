#pragma checksum "C:\Users\cbarajas\source\repos\CSC260\CSC260\MovieLoader\Views\Movie\MoviePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46719775350ad04745d3913434a0126e76f7d19d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_MoviePartialView), @"mvc.1.0.view", @"/Views/Movie/MoviePartialView.cshtml")]
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
#line 1 "C:\Users\cbarajas\source\repos\CSC260\CSC260\MovieLoader\Views\_ViewImports.cshtml"
using MovieLoader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cbarajas\source\repos\CSC260\CSC260\MovieLoader\Views\_ViewImports.cshtml"
using MovieLoader.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46719775350ad04745d3913434a0126e76f7d19d", @"/Views/Movie/MoviePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"290302c0acff1d332226de4c48014cf6a22ee782", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_MoviePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("MoviePartialView\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\cbarajas\source\repos\CSC260\CSC260\MovieLoader\Views\Movie\MoviePartialView.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>No movie provided</h1>\r\n");
#nullable restore
#line 8 "C:\Users\cbarajas\source\repos\CSC260\CSC260\MovieLoader\Views\Movie\MoviePartialView.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h3>");
#nullable restore
#line 12 "C:\Users\cbarajas\source\repos\CSC260\CSC260\MovieLoader\Views\Movie\MoviePartialView.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h4>Year: ");
#nullable restore
#line 13 "C:\Users\cbarajas\source\repos\CSC260\CSC260\MovieLoader\Views\Movie\MoviePartialView.cshtml"
             Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h5>Rating: ");
#nullable restore
#line 14 "C:\Users\cbarajas\source\repos\CSC260\CSC260\MovieLoader\Views\Movie\MoviePartialView.cshtml"
               Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\cbarajas\source\repos\CSC260\CSC260\MovieLoader\Views\Movie\MoviePartialView.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591