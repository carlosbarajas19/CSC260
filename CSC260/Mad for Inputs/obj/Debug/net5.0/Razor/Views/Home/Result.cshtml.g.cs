#pragma checksum "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c5cb3e1332cbb161ac0f7f241f983726adae3ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\_ViewImports.cshtml"
using Mad_for_Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\_ViewImports.cshtml"
using Mad_for_Inputs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c5cb3e1332cbb161ac0f7f241f983726adae3ef", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"832fb109e86a477a6d720edfb69d612107394e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.one) && !string.IsNullOrEmpty(ViewBag.two) && !string.IsNullOrEmpty(ViewBag.three) && !string.IsNullOrEmpty(ViewBag.four) &&
  !string.IsNullOrEmpty(ViewBag.five) && !string.IsNullOrEmpty(ViewBag.six) && !string.IsNullOrEmpty(ViewBag.seven) && !string.IsNullOrEmpty(ViewBag.eight) &&
  !string.IsNullOrEmpty(ViewBag.nine) && !string.IsNullOrEmpty(ViewBag.ten))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Driving Tips</h1>\r\n    <p>\r\n        Driving a car can be fun if you follow this <em>");
#nullable restore
#line 7 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
                                                   Write(ViewBag.one);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em> advice.\r\n    </p>\r\n    <ul>\r\n        <li>\r\n            When approaching a <em>");
#nullable restore
#line 11 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
                              Write(ViewBag.two);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em> on the right, always blow your <em>");
#nullable restore
#line 11 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
                                                                                   Write(ViewBag.three);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>.\r\n        </li>\r\n        <li>\r\n            Before making a <em>");
#nullable restore
#line 14 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
                           Write(ViewBag.four);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em> turn, always stick your <em>");
#nullable restore
#line 14 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
                                                                          Write(ViewBag.five);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em> out of the window.\r\n        </li>\r\n        <li>\r\n            Every 2000 miles, have your <em>");
#nullable restore
#line 17 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
                                       Write(ViewBag.five);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em> inspected and your <em>");
#nullable restore
#line 17 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
                                                                                 Write(ViewBag.six);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em> checked.\r\n        </li>\r\n        <li>\r\n            When approaching a school, watch out for <em>");
#nullable restore
#line 20 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
                                                    Write(ViewBag.seven);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
                                                                   Write(ViewBag.eight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>.\r\n        </li>\r\n        <li>\r\n            Above all, drive <em>");
#nullable restore
#line 23 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
                            Write(ViewBag.nine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>. The <em>");
#nullable restore
#line 23 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
                                                        Write(ViewBag.ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em> you save may be your own!\r\n        </li>\r\n    </ul>\r\n");
#nullable restore
#line 26 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5>It appears you might have missed a blank or two... or ten. Please go back and try again.</h5>\r\n");
#nullable restore
#line 30 "D:\Visual Studio Projects\CSC260\Mad for Inputs\Views\Home\Result.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
