#pragma checksum "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b255f457f287560f559f99aba63a516e5adeb08"
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
#line 1 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/_ViewImports.cshtml"
using CrudDelicious;

#line default
#line hidden
#line 2 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/_ViewImports.cshtml"
using CrudDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b255f457f287560f559f99aba63a516e5adeb08", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3476cfc9014dc11f49172991087a9128dd431e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CrudDelicious.Models.AllDishes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 324, true);
            WriteLiteral(@"<div class=""jumbotron text-center"">
  <h1 class=""display-4"">Welcome to CRUDelicious</h1>
  <hr class=""my-4"">
  <p class=""lead"">
    <a class=""btn btn-info btn-lg"" href=""/new"" role=""button"">Add A Dish</a>
  </p>
</div>
<div class=""jumbotron text-center"">
  <h3>Check out some recent dishes</h3>
  <hr class=""my-4"">
");
            EndContext();
#line 12 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/Home/Index.cshtml"
    
    foreach(var dish in @Model.alldishes)
    {

#line default
#line hidden
            BeginContext(420, 26, true);
            WriteLiteral("      <div>\r\n        <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 446, "\"", 471, 2);
            WriteAttributeValue("", 453, "/view/", 453, 6, true);
#line 16 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/Home/Index.cshtml"
WriteAttributeValue("", 459, dish.DishID, 459, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(472, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(474, 9, false);
#line 16 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/Home/Index.cshtml"
                                   Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(483, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(492, 9, false);
#line 16 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/Home/Index.cshtml"
                                                     Write(dish.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(501, 20, true);
            WriteLiteral("</p>\r\n      </div>\r\n");
            EndContext();
#line 18 "/Users/Shea/Desktop/coding_dojo/c#/EntityFramework/CrudDelicious/Views/Home/Index.cshtml"
    }
  

#line default
#line hidden
            BeginContext(533, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrudDelicious.Models.AllDishes> Html { get; private set; }
    }
}
#pragma warning restore 1591
