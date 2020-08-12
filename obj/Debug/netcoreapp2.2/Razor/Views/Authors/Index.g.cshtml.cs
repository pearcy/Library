#pragma checksum "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d60313b4f8607c6c98588595b831354780a525b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Index), @"mvc.1.0.view", @"/Views/Authors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authors/Index.cshtml", typeof(AspNetCore.Views_Authors_Index))]
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
#line 5 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Index.cshtml"
using Library.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d60313b4f8607c6c98588595b831354780a525b1", @"/Views/Authors/Index.cshtml")]
    public class Views_Authors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Library.Models.Author>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(87, 21, true);
            WriteLiteral("\n  <h1>Authors</h1>\n\n");
            EndContext();
#line 10 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Index.cshtml"
   if (@Model.Count == 0)
  {

#line default
#line hidden
            BeginContext(138, 40, true);
            WriteLiteral("    <h3>No Authors have been Added</h3>\n");
            EndContext();
#line 13 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(182, 5, true);
            WriteLiteral("<ul>\n");
            EndContext();
#line 15 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Index.cshtml"
   foreach (Author author in Model)
  {

#line default
#line hidden
            BeginContext(227, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(236, 80, false);
#line 17 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Index.cshtml"
   Write(Html.ActionLink($"{author.AuthorName}", "Details", new { id = author.AuthorId }));

#line default
#line hidden
            EndContext();
            BeginContext(316, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(326, 12, true);
            WriteLiteral("</ul>\n\n  <p>");
            EndContext();
            BeginContext(339, 43, false);
#line 21 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Index.cshtml"
Write(Html.ActionLink("Add New Author", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(382, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(393, 40, false);
#line 22 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(433, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Library.Models.Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
