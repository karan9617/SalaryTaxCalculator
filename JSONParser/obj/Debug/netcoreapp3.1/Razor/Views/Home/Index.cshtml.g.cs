#pragma checksum "/Users/karanvishwakarma/Projects/JSONParser/JSONParser/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e2e42ab3a3ae6c10764f745c759279bb43433f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/karanvishwakarma/Projects/JSONParser/JSONParser/Views/_ViewImports.cshtml"
using JSONParser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/karanvishwakarma/Projects/JSONParser/JSONParser/Views/_ViewImports.cshtml"
using JSONParser.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e2e42ab3a3ae6c10764f745c759279bb43433f2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19fc2181fc6222d4fbd6ade7295088f5f908d1db", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/karanvishwakarma/Projects/JSONParser/JSONParser/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">JSONParser</h1>\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n</div>\n\n\n\n");
#nullable restore
#line 12 "/Users/karanvishwakarma/Projects/JSONParser/JSONParser/Views/Home/Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post, new { @enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label class=\"form-label\" for=\"file\">Upload JSON File</label>\n    <input type=\"file\" class=\"form-control\" name=\"JsonFile\" id=\"JsonFile\" />\n");
            WriteLiteral("    <br>\n");
            WriteLiteral("    <input type=\"submit\" class=\"btn btn-primary\" value=\"Upload File\" />\n");
            WriteLiteral("    <br>\n    <br>\n");
#nullable restore
#line 23 "/Users/karanvishwakarma/Projects/JSONParser/JSONParser/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 25 "/Users/karanvishwakarma/Projects/JSONParser/JSONParser/Views/Home/Index.cshtml"
 if(Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Users/karanvishwakarma/Projects/JSONParser/JSONParser/Views/Home/Index.cshtml"
                 foreach(KeyValuePair<string,int> entry in @Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <table>\n                       <tr>\n                           <td>");
#nullable restore
#line 30 "/Users/karanvishwakarma/Projects/JSONParser/JSONParser/Views/Home/Index.cshtml"
                          Write(entry.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                           <td>");
#nullable restore
#line 31 "/Users/karanvishwakarma/Projects/JSONParser/JSONParser/Views/Home/Index.cshtml"
                          Write(entry.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                       </tr>\n                   </table>\n");
#nullable restore
#line 34 "/Users/karanvishwakarma/Projects/JSONParser/JSONParser/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/karanvishwakarma/Projects/JSONParser/JSONParser/Views/Home/Index.cshtml"
                 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591