#pragma checksum "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2540892cfa62657f452ab414197cf8b1b8cd6780"
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
#line 1 "E:\WebProject\MansStore\MansStore\Views\_ViewImports.cshtml"
using MansStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\WebProject\MansStore\MansStore\Views\_ViewImports.cshtml"
using MansStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\WebProject\MansStore\MansStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2540892cfa62657f452ab414197cf8b1b8cd6780", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78fe3eaf795bf5ff72fcb2e2c5a6d8857e85ebe7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("350"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("woo_cart_btn btn_cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    int sliderCout = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""clearfix""></div>
<!-- ============================================================== -->
<!-- Top header  -->
<!-- ============================================================== -->
<!-- ======================== Banner Start ==================== -->
<div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
");
#nullable restore
#line 16 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
         for (int i = 1; i < Model.Sliders.Count() - 1; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 18 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\r\n");
#nullable restore
#line 19 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </ol>\r\n    <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 25 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
         foreach (var item in Model.Sliders)
        {
            if (sliderCout == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item active\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2540892cfa62657f452ab414197cf8b1b8cd67807600", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1008, "~/images/Slider/", 1008, 16, true);
#nullable restore
#line 30 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1024, item.Srcimg, 1024, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"carousel-caption banner_caption\">\r\n                        <h4><span class=\"theme-cl\">");
#nullable restore
#line 32 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                                              Write(item.RedBoldTxt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 32 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                                                                      Write(item.BoldTxt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>");
#nullable restore
#line 33 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                      Write(item.Discription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1296, "\"", 1313, 1);
#nullable restore
#line 34 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 1303, item.Link, 1303, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-theme\">خرید کنید</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 37 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2540892cfa62657f452ab414197cf8b1b8cd678010880", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1549, "~/images/Slider/", 1549, 16, true);
#nullable restore
#line 41 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1565, item.Srcimg, 1565, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"carousel-caption banner_caption\">\r\n                        <h4><span class=\"theme-cl\">");
#nullable restore
#line 43 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                                              Write(item.RedBoldTxt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 43 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                                                                      Write(item.BoldTxt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>");
#nullable restore
#line 44 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                      Write(item.Discription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1837, "\"", 1854, 1);
#nullable restore
#line 45 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 1844, item.Link, 1844, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-theme\">خرید کنید</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 48 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
            }

            sliderCout++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>

    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">قبلی</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">بعدی</span>
    </a>
</div>
<!-- ======================== Women Accessiries Start ==================== -->


<!-- ======================== Top category ==================== -->
<section>
    <div class=""container"">
        <div class=""row justify-content-center"">
");
#nullable restore
#line 71 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
             foreach (var item in Model.HomeCard)
            {            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4 col-md-4 col-sm-12\">\r\n                <div class=\"card card_big\">\r\n                    <div class=\"card-bg\">\r\n                        <div class=\"card-bg-img bg-cover\" style=\"background:#fde9ed \">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2540892cfa62657f452ab414197cf8b1b8cd678015362", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3054, "~/images/HomeCard/", 3054, 18, true);
#nullable restore
#line 76 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3072, item.imgSrc, 3072, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                        \r\n                    </div>\r\n                    <div class=\"card-body my-auto\">\r\n                        <!-- Heading -->\r\n                        <h3 class=\"mb-0 text-danger\">");
#nullable restore
#line 81 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                                                Write(item.textcard);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <br />\r\n                        <!-- Link -->\r\n                        <a class=\"btn btn-link\"");
            BeginWriteAttribute("href", " href=\"", 3471, "\"", 3488, 1);
#nullable restore
#line 84 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 3478, item.link, 3478, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            خرید جدید <i class=\"ti-arrow-left mr-2\"></i>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 90 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            

        </div>
    </div>
</section>
<!-- ======================== Top category End ==================== -->



<!-- ======================= Hot Deal Start ============================== -->
<section class=""pt-0"">
    <div class=""container"">
        <div class=""row align-item-center"">

            <div class=""col-lg-6 col-md-6"">
                <div class=""d-flex flex-column overflow-hidden rounded-lg pad-bt"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 4149, "\"", 4251, 2);
#nullable restore
#line 107 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 4156, Model.Homeimg.Where(p=>p.LocationImg==BissnessEntity.LocationImg.Right).FirstOrDefault().link, 4156, 94, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4250, "", 4251, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2540892cfa62657f452ab414197cf8b1b8cd678019274", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4263, "~/images/Homeimg/", 4263, 17, true);
#nullable restore
#line 107 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4280, Model.Homeimg.Where(p=>p.LocationImg==BissnessEntity.LocationImg.Right)?.FirstOrDefault()?.imgSrc, 4280, 98, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 4378, "??", 4378, 2, true);
            AddHtmlAttributeValue(" ", 4380, "\'\'", 4381, 3, true);
            AddHtmlAttributeValue(" ", 4383, "", 4384, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-lg-6 col-md-6\">\r\n                <div class=\"offer-deals mb-4\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4580, "\"", 4681, 1);
#nullable restore
#line 113 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 4587, Model.Homeimg.Where(p=>p.LocationImg==BissnessEntity.LocationImg.Left1).FirstOrDefault().link, 4587, 94, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2540892cfa62657f452ab414197cf8b1b8cd678021802", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4693, "~/images/Homeimg/", 4693, 17, true);
#nullable restore
#line 113 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4710, Model.Homeimg.Where(p=>p.LocationImg==BissnessEntity.LocationImg.Left1)?.FirstOrDefault()?.imgSrc, 4710, 98, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 4808, "??", 4808, 2, true);
            AddHtmlAttributeValue(" ", 4810, "\'\'", 4811, 3, true);
            AddHtmlAttributeValue(" ", 4813, "", 4814, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                </div>\r\n                <div class=\"offer-deals mt-3\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4943, "\"", 5044, 1);
#nullable restore
#line 116 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 4950, Model.Homeimg.Where(p=>p.LocationImg==BissnessEntity.LocationImg.Left2).FirstOrDefault().link, 4950, 94, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2540892cfa62657f452ab414197cf8b1b8cd678024255", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5056, "~/images/Homeimg/", 5056, 17, true);
#nullable restore
#line 116 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5073, Model.Homeimg.Where(p=>p.LocationImg==BissnessEntity.LocationImg.Left2)?.FirstOrDefault()?.imgSrc, 5073, 98, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5171, "??", 5171, 2, true);
            AddHtmlAttributeValue(" ", 5173, "\'\'", 5174, 3, true);
            AddHtmlAttributeValue(" ", 5176, "", 5177, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                </div>
            </div>

        </div>
    </div>
</section>
<!-- ======================= Hot Deals End =============================== -->

<section class=""pt-0"">
    <div class=""container"">

        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12"">
                <div class=""sec-heading-flex pl-2 pr-2"">
                    <div class=""sec-heading-flex-one"">
                        <h2>جدیدترین ها</h2>
                    </div>
                    <div class=""sec-heading-flex-last"">
                        <a href=""/product/showproduct"" class=""btn btn-theme"">بیشتر<i class=""ti-arrow-left mr-2""></i></a>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-12 col-md-12"">
                <div class=""owl-carousel products-slider owl-theme"">
");
#nullable restore
#line 144 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                     foreach (var item in Model.Dinamic)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            <div class=\"woo_product_grid\">\r\n                                <div class=\"woo_product_thumb\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2540892cfa62657f452ab414197cf8b1b8cd678027587", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6418, "~/images/product/", 6418, 17, true);
#nullable restore
#line 150 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6435, item.ImageSrc, 6435, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"woo_product_caption center\">\r\n                                    <div class=\"woo_rate\">\r\n");
#nullable restore
#line 154 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                                         for (int i = 0; i <= item.star; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fa fa-star active\"></i>\r\n");
#nullable restore
#line 157 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                                         for (int i = 0; i <= (5 - item.star); i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fa fa-star filled\"></i>\r\n");
#nullable restore
#line 161 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <div class=\"woo_title\">\r\n                                        <h4 class=\"woo_pro_title\"><a href=\"detail-1.html\">");
#nullable restore
#line 164 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                                                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                    </div>\r\n                                    <div class=\"woo_price\">\r\n                                        <h6>");
#nullable restore
#line 167 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                                       Write(item.price.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</h6>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"woo_product_cart hover\">\r\n                                    <ul>\r\n                                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2540892cfa62657f452ab414197cf8b1b8cd678031722", async() => {
                WriteLiteral("<i class=\"ti-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7802, "~/product/Detail?id=", 7802, 20, true);
#nullable restore
#line 172 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7822, item.id, 7822, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 7941, "\"", 7973, 2);
            WriteAttributeValue("", 7948, "/Cart/AddCart?id=", 7948, 17, true);
#nullable restore
#line 173 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 7965, item.id, 7965, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"woo_cart_btn btn_view\"><i class=\"ti-shopping-cart\"></i></a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 8094, "\"", 8140, 2);
            WriteAttributeValue("", 8101, "/Product/AddFavorite?ProductId=", 8101, 31, true);
#nullable restore
#line 174 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 8132, item.id, 8132, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"woo_cart_btn btn_save\"><i class=\"ti-heart\"></i></a></li>\r\n                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 179 "E:\WebProject\MansStore\MansStore\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<div class=\"clearfix\"></div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomePageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
