#pragma checksum "/Users/Shea/Desktop/coding_dojo/c#/ASPMVC2/RandomPasscode/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93ba5cc46c6200a99bce5935eaf6f67822952d37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/Shea/Desktop/coding_dojo/c#/ASPMVC2/RandomPasscode/Views/_ViewImports.cshtml"
using RandomPasscode;

#line default
#line hidden
#line 2 "/Users/Shea/Desktop/coding_dojo/c#/ASPMVC2/RandomPasscode/Views/_ViewImports.cshtml"
using RandomPasscode.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93ba5cc46c6200a99bce5935eaf6f67822952d37", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42cd7b8af8768fe262a1b538d625ccb9051478f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RandomPasscode.Models.Code>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 126, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n  <h1 class=\"display-4 text-center\">Random Passcode</h1>\r\n  <p class=\"lead text-center\">(Passcode #");
            EndContext();
            BeginContext(163, 13, false);
#line 5 "/Users/Shea/Desktop/coding_dojo/c#/ASPMVC2/RandomPasscode/Views/Home/Index.cshtml"
                                    Write(ViewBag.count);

#line default
#line hidden
            EndContext();
            BeginContext(176, 96, true);
            WriteLiteral(")</p>\r\n  <div class=\"container bg-info text-white text-center col-8 border-white rounded p-2\">\r\n");
            EndContext();
#line 7 "/Users/Shea/Desktop/coding_dojo/c#/ASPMVC2/RandomPasscode/Views/Home/Index.cshtml"
        
          string display = "";
          foreach(var thing in @Model.RandomCode)
            {
                display += thing;
            }

#line default
#line hidden
            BeginContext(430, 16, true);
            WriteLiteral("            <h3>");
            EndContext();
            BeginContext(447, 7, false);
#line 13 "/Users/Shea/Desktop/coding_dojo/c#/ASPMVC2/RandomPasscode/Views/Home/Index.cshtml"
           Write(display);

#line default
#line hidden
            EndContext();
            BeginContext(454, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
            BeginContext(470, 163, true);
            WriteLiteral("  </div>\r\n  <hr class=\"my-4\">\r\n  <p class=\"lead\">\r\n    <a class=\"btn btn-info btn-lg text-center offset-5\" href=\"/\" role=\"button\">Generate Code</a>\r\n  </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RandomPasscode.Models.Code> Html { get; private set; }
    }
}
#pragma warning restore 1591