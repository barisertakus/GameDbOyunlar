#pragma checksum "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6addfa8a88df0063dd2c665759a18df43ae8cbbb"
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
#line 1 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\_ViewImports.cshtml"
using Oyunlar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
using Oyunlar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6addfa8a88df0063dd2c665759a18df43ae8cbbb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"041de13e51f63f6987e27f9dd634db26bf938d18", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Oyun>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Hero Section Begin -->
<section class=""hero"">
    <div class=""container"">
        <div class=""hero__slider owl-carousel"">
            <div class=""hero__items set-bg"" data-setbg=""../img/games/slide-forza-horizon-4.jpg"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""hero__text"">
                            <h2>Forza Horizon 4</h2>
                            <p>30 gun icerisinde erisim..</p>
                            <a href=""#""><span>More Details</span> <i class=""fa fa-angle-right""></i></a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""hero__items set-bg"" data-setbg=""../img/games/slide-witcher3.jpg"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""hero__text"">
                            <h2>The Witcher 3</h2>
                            <p>30 gun icerisinde erisim..</p>
   ");
            WriteLiteral(@"                         <a href=""#""><span>More Details</span> <i class=""fa fa-angle-right""></i></a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""hero__items set-bg"" data-setbg=""../img/games/slide-red-dead-redemption2.jpg"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""hero__text"">
                            <h2>Red Dead Redemption 2</h2>
                            <p>30 gun icerisinde erisim..</p>
                            <a href=""#""><span>More Details</span> <i class=""fa fa-angle-right""></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Hero Section End -->
<!-- Product Section Begin -->
<section class=""product spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""tre");
            WriteLiteral(@"nding__product"">
                    <div class=""row"">
                        <div class=""col-lg-8 col-md-8 col-sm-8"">
                            <div class=""section-title"">
                                <h4>Trending Now</h4>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-4 col-sm-4"">
                            <div class=""btn__all"">
                                <a href=""#"" class=""primary-btn"">View All <span class=""arrow_right""></span></a>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
");
#nullable restore
#line 68 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-lg-4 col-md-6 col-sm-6"">
                                <div class=""product__item"">
                                    <div class=""product__item__pic set-bg""
                                         data-setbg=""");
#nullable restore
#line 73 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                                                Write(item.resim);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                        <div class=""ep"">9 / 10</div>
                                        <div class=""comment""><i class=""fa fa-comments""></i> 11</div>
                                        <div class=""view""><i class=""fa fa-eye""></i> 9141</div>
                                    </div>
                                    <div class=""product__item__text"">
                                        <ul>
                                            <li>Active</li>
                                            <li>Movie</li>
                                        </ul>
                                        <h5><a");
            BeginWriteAttribute("href", " href=\"", 3804, "\"", 3839, 2);
            WriteAttributeValue("", 3811, "/Home/OyunDetay/", 3811, 16, true);
#nullable restore
#line 83 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
WriteAttributeValue("", 3827, item.oyunID, 3827, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 83 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                                                                              Write(item.oyunAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 87 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>
                </div>
                <div class=""popular__product"">
                    <div class=""row"">
                        <div class=""col-lg-8 col-md-8 col-sm-8"">
                            <div class=""section-title"">
                                <h4>Popular Shows</h4>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-4 col-sm-4"">
                            <div class=""btn__all"">
                                <a href=""#"" class=""primary-btn"">View All <span class=""arrow_right""></span></a>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
");
#nullable restore
#line 106 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-4 col-md-6 col-sm-6\">\r\n                                <div class=\"product__item\">\r\n                                    <div class=\"product__item__pic set-bg\" data-setbg=\"");
#nullable restore
#line 110 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                                                                                  Write(item.resim);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                        <div class=\"ep\">");
#nullable restore
#line 111 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                                                   Write(item.puan);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" / 10</div>
                                        <div class=""comment""><i class=""fa fa-comments""></i> 11</div>
                                        <div class=""view""><i class=""fa fa-eye""></i> 9141</div>
                                    </div>
                                    <div class=""product__item__text"">
                                        <ul>
                                            <li>Active</li>
                                            <li>Movie</li>
                                        </ul>
                                        <h5><a");
            BeginWriteAttribute("href", " href=\"", 5733, "\"", 5768, 2);
            WriteAttributeValue("", 5740, "/Home/OyunDetay/", 5740, 16, true);
#nullable restore
#line 120 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
WriteAttributeValue("", 5756, item.oyunID, 5756, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 120 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                                                                              Write(item.oyunAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>></h5>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 124 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>
                </div>


            </div>
            <div class=""col-lg-4 col-md-6 col-sm-8"">
                <div class=""product__sidebar"">
                    <div class=""product__sidebar__view"">
                        <div class=""section-title"">
                            <h5>Top Views</h5>
                        </div>
                        <ul class=""filter__controls"">
                            <li class=""active"" data-filter=""*"">Day</li>
                            <li data-filter="".week"">Week</li>
                            <li data-filter="".month"">Month</li>
                            <li data-filter="".years"">Years</li>
                        </ul>
");
#nullable restore
#line 144 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"filter__gallery\">\r\n                                <div class=\"product__sidebar__view__item set-bg mix day years\"\r\n                                     data-setbg=\"");
#nullable restore
#line 148 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                                            Write(item.resim);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <div class=\"ep\">");
#nullable restore
#line 149 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                                               Write(item.puan);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 10</div>\r\n                                    <div class=\"view\"><i class=\"fa fa-eye\"></i> 9141</div>\r\n                                    <h5><a");
            BeginWriteAttribute("href", " href=\"", 7176, "\"", 7211, 2);
            WriteAttributeValue("", 7183, "/Home/OyunDetay/", 7183, 16, true);
#nullable restore
#line 151 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
WriteAttributeValue("", 7199, item.oyunID, 7199, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 151 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                                                                           Write(item.oyunAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 154 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <div class=""product__sidebar__comment"">
                        <div class=""section-title"">
                            <h5>New Comment</h5>
                        </div>
                        <div class=""product__sidebar__comment__item"">
                            <div class=""product__sidebar__comment__item__pic"">
                                <img src=""../img/games/slide-thimbleweed-park.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7800, "\"", 7806, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""product__sidebar__comment__item__text"">
                                <ul>
                                    <li>Active</li>
                                    <li>Movie</li>
                                </ul>
                                <h5><a href=""#"">The Seven Deadly Sins: Wrath of the Gods</a></h5>
                                <span><i class=""fa fa-eye""></i> 19.141 Viewes</span>
                            </div>
                        </div>
                        <div class=""product__sidebar__comment__item"">
                            <div class=""product__sidebar__comment__item__pic"">
                                <img src=""../img/games/slide-sid-meier-civilization-vi.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8604, "\"", 8610, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""product__sidebar__comment__item__text"">
                                <ul>
                                    <li>Active</li>
                                    <li>Movie</li>
                                </ul>
                                <h5><a href=""#"">Shirogane Tamashii hen Kouhan sen</a></h5>
                                <span><i class=""fa fa-eye""></i> 19.141 Viewes</span>
                            </div>
                        </div>
                        <div class=""product__sidebar__comment__item"">
                            <div class=""product__sidebar__comment__item__pic"">
                                <img src=""../img/games/slide-fortnite.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9384, "\"", 9390, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""product__sidebar__comment__item__text"">
                                <ul>
                                    <li>Active</li>
                                    <li>Movie</li>
                                </ul>
                                <h5><a href=""#"">Kizumonogatari III: Reiket su-hen</a></h5>
                                <span><i class=""fa fa-eye""></i> 19.141 Viewes</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Product Section End -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Oyun>> Html { get; private set; }
    }
}
#pragma warning restore 1591