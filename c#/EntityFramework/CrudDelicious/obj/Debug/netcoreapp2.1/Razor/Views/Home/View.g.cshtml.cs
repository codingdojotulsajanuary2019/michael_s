#pragma checksum "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/Home/View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ca8e24be1a4b3cae9c69ae7c26880b7560c6a41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_View), @"mvc.1.0.view", @"/Views/Home/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/View.cshtml", typeof(AspNetCore.Views_Home_View))]
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
#line 1 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/_ViewImports.cshtml"
using CrudDelicious;

#line default
#line hidden
#line 2 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/_ViewImports.cshtml"
using CrudDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ca8e24be1a4b3cae9c69ae7c26880b7560c6a41", @"/Views/Home/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3476cfc9014dc11f49172991087a9128dd431e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CrudDelicious.Models.Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 61, true);
            WriteLiteral("\n<div class=\"jumbotron text-center\">\n  <h1 class=\"display-4\">");
            EndContext();
            BeginContext(95, 10, false);
#line 4 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/Home/View.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(105, 42, true);
            WriteLiteral("</h1>\n  <h3>Chef: <span class=\"text-info\">");
            EndContext();
            BeginContext(148, 10, false);
#line 5 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/Home/View.cshtml"
                               Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(158, 38, true);
            WriteLiteral("</span></h3>\n  <hr class=\"my-4\">\n  <p>");
            EndContext();
            BeginContext(197, 17, false);
#line 7 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/Home/View.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(214, 21, true);
            WriteLiteral("</p>\n  <h5>Calories: ");
            EndContext();
            BeginContext(236, 14, false);
#line 8 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/Home/View.cshtml"
           Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(250, 23, true);
            WriteLiteral("</h5>\n  <h5>Tastiness: ");
            EndContext();
            BeginContext(274, 15, false);
#line 9 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/Home/View.cshtml"
            Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(289, 132, true);
            WriteLiteral("</h5>\n  <p class=\"lead\">\n    <a class=\"btn btn-info btn-lg\" href=\"/\" role=\"button\">All Dishes</a>\n    <a class=\"btn btn-info btn-lg\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 421, "\"", 447, 2);
            WriteAttributeValue("", 428, "/edit/", 428, 6, true);
#line 12 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/Home/View.cshtml"
WriteAttributeValue("", 434, Model.DishID, 434, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(448, 43, true);
            WriteLiteral(" role=\"button\">Edit Dish</a>\n  </p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrudDelicious.Models.Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
