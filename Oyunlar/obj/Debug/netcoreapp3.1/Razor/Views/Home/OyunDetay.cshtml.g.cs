#pragma checksum "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\OyunDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58ad66bf68106763571c810ba242d944430bc214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OyunDetay), @"mvc.1.0.view", @"/Views/Home/OyunDetay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58ad66bf68106763571c810ba242d944430bc214", @"/Views/Home/OyunDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"041de13e51f63f6987e27f9dd634db26bf938d18", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OyunDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Oyunlar.Models.OyunYorum>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TumOyunlar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\OyunDetay.cshtml"
  
    ViewData["Title"] = "OyunDetay";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Breadcrumb Begin -->\r\n<div class=\"breadcrumb-option\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"breadcrumb__links\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58ad66bf68106763571c810ba242d944430bc2144681", async() => {
                WriteLiteral("<i class=\"fa fa-home\"></i> Ana Sayfa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58ad66bf68106763571c810ba242d944430bc2146294", async() => {
                WriteLiteral("Tüm Oyunlar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <span>Red Dead Redemption 2</span>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumb End -->
<!-- Anime Section Begin -->
<section class=""anime-details spad"">
    <div class=""container"">
        <div class=""anime__details__content"">
            <div class=""row"">
                <div class=""col-lg-5"">
                    <div class=""anime__details__pic set-bg"" data-setbg=""");
#nullable restore
#line 27 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\OyunDetay.cshtml"
                                                                   Write(Model.Deger2.ElementAt(0).resim);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                        <div class=""comment""><i class=""fa fa-comments""></i> 11</div>
                        <div class=""view""><i class=""fa fa-eye""></i> 9141</div>
                    </div>
                </div>
                <div class=""col-lg-7"">
                    <div class=""anime__details__text"">
                        <div class=""anime__details__title"">
                            <h3>");
#nullable restore
#line 35 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\OyunDetay.cshtml"
                           Write(Model.Deger2.ElementAt(0).oyunAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                            <span>Red Company Feito／sutei naito</span>
                        </div>
                        <div class=""anime__details__rating"">
                            <div class=""rating"">
                                <a href=""#""><i class=""fa fa-star""></i></a>
                                <a href=""#""><i class=""fa fa-star""></i></a>
                                <a href=""#""><i class=""fa fa-star""></i></a>
                                <a href=""#""><i class=""fa fa-star""></i></a>
                                <a href=""#""><i class=""fa fa-star-half-o""></i></a>
                            </div>
                            <span>1.029 Votes</span>
                        </div>
                        <p>
                            Every human inhabiting the world of Alcia is branded by a “Count” or a number written on
                            their body. For Hina’s mother, her total drops to 0 and she’s pulled into the Abyss,
                            nev");
            WriteLiteral(@"er to be seen again. But her mother’s last words send Hina on a quest to find a
                            legendary hero from the Waste War - the fabled Ace!
                        </p>
                        <div class=""anime__details__widget"">
                            <div class=""row"">
                                <div class=""col-lg-6 col-md-6"">
                                    <ul>
                                        <li><span>Oyun Adi:</span> ");
#nullable restore
#line 58 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\OyunDetay.cshtml"
                                                              Write(Model.Deger2.ElementAt(0).oyunAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li><span>Oyun Boyutu:</span> ");
#nullable restore
#line 59 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\OyunDetay.cshtml"
                                                                 Write(Model.Deger2.ElementAt(0).boyut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li><span>Puan</span> ");
#nullable restore
#line 60 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\OyunDetay.cshtml"
                                                         Write(Model.Deger2.ElementAt(0).puan);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 10</li>\r\n                                        <li><span>Yayin Senesi:</span> ");
#nullable restore
#line 61 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\OyunDetay.cshtml"
                                                                  Write(Model.Deger2.ElementAt(0).yayinlamaTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li> 
                                    </ul>
                                </div>
                                <div class=""col-lg-6 col-md-6"">
             
                                 
                                </div>
                            </div>
                        </div>
                        <div class=""anime__details__btn"">
                            <a href=""#"" class=""follow-btn""><i class=""fa fa-heart-o""></i> Follow</a>
                            <a href=""#"" class=""watch-btn"">
                                <span>Watch Now</span> <i class=""fa fa-angle-right""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-8 col-md-8"">
                <div class=""anime__details__review"">
                    <div class=""section-title"">
                        <h5>Reviews</h5>
                    </div>
");
#nullable restore
#line 86 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\OyunDetay.cshtml"
                     foreach (var item in Model.Deger1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"anime__review__item\">\r\n                            <div class=\"anime__review__item__pic\">\r\n                                <img src=\"../../img/anime/review-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4591, "\"", 4597, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"anime__review__item__text\">\r\n                                <h6>");
#nullable restore
#line 93 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\OyunDetay.cshtml"
                               Write(item.kullaniciID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - <span>1 Hour ago</span></h6>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 95 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\OyunDetay.cshtml"
                               Write(item.yorum);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 99 "C:\Users\baris\WebProg\Oyunlar\Oyunlar\Views\Home\OyunDetay.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
                <div class=""anime__details__form"">
                    <div class=""section-title"">
                        <h5>Your Comment</h5>
                    </div>

                        <br />


                        <a href=""../../Degerlendirme/YeniDegerlendirme"" class=""btn fa fa-location-arrow"">Yeni Yorum Ekle</a>

                </div>
            </div>
            <div class=""col-lg-4 col-md-4"">
                <div class=""anime__details__sidebar"">
                    <div class=""section-title"">
                        <h5>you might like...</h5>
                    </div>
                    <div class=""product__sidebar__view__item set-bg"" data-setbg=""../../img/sidebar/tv-1.jpg"">
                        <div class=""ep"">18 / ?</div>
                        <div class=""view""><i class=""fa fa-eye""></i> 9141</div>
                        <h5><a href=""#"">Boruto: Naruto next generations</a></h5>
                    </div>
                    <div c");
            WriteLiteral(@"lass=""product__sidebar__view__item set-bg"" data-setbg=""../../img/sidebar/tv-2.jpg"">
                        <div class=""ep"">18 / ?</div>
                        <div class=""view""><i class=""fa fa-eye""></i> 9141</div>
                        <h5><a href=""#"">The Seven Deadly Sins: Wrath of the Gods</a></h5>
                    </div>
                    <div class=""product__sidebar__view__item set-bg"" data-setbg=""../../img/sidebar/tv-3.jpg"">
                        <div class=""ep"">18 / ?</div>
                        <div class=""view""><i class=""fa fa-eye""></i> 9141</div>
                        <h5><a href=""#"">Sword art online alicization war of underworld</a></h5>
                    </div>
                    <div class=""product__sidebar__view__item set-bg"" data-setbg=""../../img/sidebar/tv-4.jpg"">
                        <div class=""ep"">18 / ?</div>
                        <div class=""view""><i class=""fa fa-eye""></i> 9141</div>
                        <h5><a href=""#"">Fate/stay night: Heaven's Feel ");
            WriteLiteral("I. presage flower</a></h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Anime Section End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Oyunlar.Models.OyunYorum> Html { get; private set; }
    }
}
#pragma warning restore 1591
