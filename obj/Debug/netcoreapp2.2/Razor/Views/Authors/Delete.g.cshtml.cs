#pragma checksum "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cebe693143d13d1445ce74a5f1d0a71ca584f90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Delete), @"mvc.1.0.view", @"/Views/Authors/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authors/Delete.cshtml", typeof(AspNetCore.Views_Authors_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cebe693143d13d1445ce74a5f1d0a71ca584f90", @"/Views/Authors/Delete.cshtml")]
    public class Views_Authors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(57, 43, true);
            WriteLiteral("\n<h4>Are you sure you would like to delete ");
            EndContext();
            BeginContext(101, 16, false);
#line 7 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Delete.cshtml"
                                     Write(Model.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(117, 30, true);
            WriteLiteral(" from the database?</h4>\n<br>\n");
            EndContext();
#line 9 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(175, 41, true);
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 12 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(218, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(223, 44, false);
#line 14 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Delete.cshtml"
Write(Html.ActionLink("Author Inventory", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(267, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(276, 47, false);
#line 15 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Delete.cshtml"
Write(Html.ActionLink("Return Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(323, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Author> Html { get; private set; }
    }
}
#pragma warning restore 1591
