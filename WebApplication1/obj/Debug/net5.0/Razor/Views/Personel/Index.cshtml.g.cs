#pragma checksum "C:\Users\pckolog\source\repos\WebApplication1\WebApplication1\Views\Personel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4b163bb118dbd25327e8bdda10a5fe267cd12cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_Index), @"mvc.1.0.view", @"/Views/Personel/Index.cshtml")]
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
#line 1 "C:\Users\pckolog\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\pckolog\source\repos\WebApplication1\WebApplication1\Views\Personel\Index.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4b163bb118dbd25327e8bdda10a5fe267cd12cb", @"/Views/Personel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Personel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<personel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\pckolog\source\repos\WebApplication1\WebApplication1\Views\Personel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h2>Personel Listesi</h2>\r\n<br />\r\n\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Adı</th>\r\n        <th>Soyadı</th>\r\n        <th>Şehir</th>\r\n       \r\n        <th></th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\pckolog\source\repos\WebApplication1\WebApplication1\Views\Personel\Index.cshtml"
      int a = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\pckolog\source\repos\WebApplication1\WebApplication1\Views\Personel\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\pckolog\source\repos\WebApplication1\WebApplication1\Views\Personel\Index.cshtml"
   Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\pckolog\source\repos\WebApplication1\WebApplication1\Views\Personel\Index.cshtml"
   Write(x.ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\pckolog\source\repos\WebApplication1\WebApplication1\Views\Personel\Index.cshtml"
   Write(x.soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\pckolog\source\repos\WebApplication1\WebApplication1\Views\Personel\Index.cshtml"
   Write(x.sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n   \r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 558, "\"", 595, 2);
            WriteAttributeValue("", 565, "/Personel/PersonelSil/", 565, 22, true);
#nullable restore
#line 31 "C:\Users\pckolog\source\repos\WebApplication1\WebApplication1\Views\Personel\Index.cshtml"
WriteAttributeValue("", 587, x.perid, 587, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n    </td>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 660, "\"", 699, 2);
            WriteAttributeValue("", 667, "/Personel/PersonelGetir/", 667, 24, true);
#nullable restore
#line 34 "C:\Users\pckolog\source\repos\WebApplication1\WebApplication1\Views\Personel\Index.cshtml"
WriteAttributeValue("", 691, x.perid, 691, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a>\r\n    </td>\r\n  \r\n</tr>\r\n");
#nullable restore
#line 38 "C:\Users\pckolog\source\repos\WebApplication1\WebApplication1\Views\Personel\Index.cshtml"
        a++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Personel/YeniPersonel/\" class=\"btn btn-primary\">Yeni Personel</a>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<personel>> Html { get; private set; }
    }
}
#pragma warning restore 1591