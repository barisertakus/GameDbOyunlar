#pragma checksum "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Degerlendirme\DegerlendirmeGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f78262de9443cefeb8ceced0a80d3b27f0e5866"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Degerlendirme_DegerlendirmeGetir), @"mvc.1.0.view", @"/Views/Degerlendirme/DegerlendirmeGetir.cshtml")]
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
#line 1 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\_ViewImports.cshtml"
using Oyunlar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\_ViewImports.cshtml"
using Oyunlar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f78262de9443cefeb8ceced0a80d3b27f0e5866", @"/Views/Degerlendirme/DegerlendirmeGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"041de13e51f63f6987e27f9dd634db26bf938d18", @"/Views/_ViewImports.cshtml")]
    public class Views_Degerlendirme_DegerlendirmeGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Oyunlar.Models.Degerlendirme>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Degerlendirme\DegerlendirmeGetir.cshtml"
  
    ViewData["Title"] = "DegerlendirmeGetir";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DegerlendirmeGetir</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Degerlendirme\DegerlendirmeGetir.cshtml"
 using (Html.BeginForm("DegerlendirmeGuncelle", "Degerlendirme", @Model.degerlendirmeID, FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>ID</b>\r\n");
#nullable restore
#line 13 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Degerlendirme\DegerlendirmeGetir.cshtml"
Write(Html.TextBoxFor(x => x.degerlendirmeID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <b>Puan</b>\r\n");
#nullable restore
#line 18 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Degerlendirme\DegerlendirmeGetir.cshtml"
Write(Html.TextBoxFor(x => x.puan, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <b>Yorum</b>\r\n");
#nullable restore
#line 22 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Degerlendirme\DegerlendirmeGetir.cshtml"
Write(Html.TextBoxFor(x => x.yorum, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-danger\">Güncelle</button>\r\n");
#nullable restore
#line 26 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Degerlendirme\DegerlendirmeGetir.cshtml"



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Oyunlar.Models.Degerlendirme> Html { get; private set; }
    }
}
#pragma warning restore 1591
