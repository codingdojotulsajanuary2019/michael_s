#pragma checksum "/Users/Shea/Desktop/coding_dojo/c#/ASPMVC2/Dojoachi/Views/Home/Lose.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2491c8661ea003a8d1ef2c309efbf5c7900e147b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Lose), @"mvc.1.0.view", @"/Views/Home/Lose.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Lose.cshtml", typeof(AspNetCore.Views_Home_Lose))]
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
#line 1 "/Users/Shea/Desktop/coding_dojo/c#/ASPMVC2/Dojoachi/Views/_ViewImports.cshtml"
using Dojoachi;

#line default
#line hidden
#line 2 "/Users/Shea/Desktop/coding_dojo/c#/ASPMVC2/Dojoachi/Views/_ViewImports.cshtml"
using Dojoachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2491c8661ea003a8d1ef2c309efbf5c7900e147b", @"/Views/Home/Lose.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99084fe81e2d303c11e61c95ec1b40a0e0eeb938", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Lose : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 285, true);
            WriteLiteral(@"<div class=""jumbotron"">
  <h1 class=""display-4"">You Lose!</h1>
  <p class=""lead"">You Dojoachi died and you should feel bad for being a terrible owner.</p>
  <hr class=""my-4"">
  <p class=""lead"">
    <a class=""btn btn-primary btn-lg"" href=""/reset"" role=""button"">Restart</a>
  </p>
</div>");
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
