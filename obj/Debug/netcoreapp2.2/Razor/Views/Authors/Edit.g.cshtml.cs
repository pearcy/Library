#pragma checksum "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d727cc8fe9625caa59b0d3049c759c70380e02ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Edit), @"mvc.1.0.view", @"/Views/Authors/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authors/Edit.cshtml", typeof(AspNetCore.Views_Authors_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d727cc8fe9625caa59b0d3049c759c70380e02ce", @"/Views/Authors/Edit.cshtml")]
    public class Views_Authors_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(57, 10, true);
            WriteLiteral("\n<h1>Edit ");
            EndContext();
            BeginContext(68, 16, false);
#line 7 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Edit.cshtml"
    Write(Model.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(84, 14, true);
            WriteLiteral("\'s Info</h1>\n\n");
            EndContext();
#line 9 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(129, 39, false);
#line 11 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Edit.cshtml"
Write(Html.HiddenFor(model => model.AuthorId));

#line default
#line hidden
            EndContext();
            BeginContext(173, 40, false);
#line 13 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Edit.cshtml"
Write(Html.LabelFor(model => model.AuthorName));

#line default
#line hidden
            EndContext();
            BeginContext(217, 41, false);
#line 14 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Edit.cshtml"
Write(Html.EditorFor(model => model.AuthorName));

#line default
#line hidden
            EndContext();
            BeginContext(260, 39, true);
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 17 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(301, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(306, 81, false);
#line 19 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Edit.cshtml"
Write(Html.ActionLink("Return to Details Page", "Details", new { id = Model.AuthorId }));

#line default
#line hidden
            EndContext();
            BeginContext(387, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(396, 55, false);
#line 20 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Edit.cshtml"
Write(Html.ActionLink("Return to Main Page", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(451, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(461, 43, false);
#line 22 "/Users/pearcy/epicode2/11week/Library.Solution/Library/Views/Authors/Edit.cshtml"
Write(Html.ActionLink("Back to Authors", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(504, 4, true);
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
