#pragma checksum "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a899e799fb5bfacdb795db2053dcf490ef7a9c37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_ShowProductAdmin), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/ShowProductAdmin.cshtml")]
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
#line 1 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\_ViewImports.cshtml"
using MansStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\_ViewImports.cshtml"
using MansStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a899e799fb5bfacdb795db2053dcf490ef7a9c37", @"/Areas/Admin/Views/Product/ShowProductAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8407108df3eea56eeb124be495682b91daa6f690", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_ShowProductAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BissnessEntity.ProductsFormAdminList_Dto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("searchproduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("waves-effect waves-light btn mb-1 mr-1 left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info purple"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app-assets/vendors/data-tables/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app-assets/vendors/data-tables/extensions/responsive/js/dataTables.responsive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app-assets/vendors/data-tables/js/dataTables.select.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app-assets/js/scripts/data-tables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app-assets/vendors/sweetalert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
  
    ViewData["Title"] = "ShowProductAdmin";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Sheets", async() => {
                WriteLiteral(@"
    <link rel=""apple-touch-icon"" href=""/app-assets/images/favicon/apple-touch-icon-152x152.png"">
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""/app-assets/images/favicon/favicon-32x32.png"">

    <!-- BEGIN: VENDOR CSS-->


    <link rel=""stylesheet"" type=""text/css"" href=""/app-assets/vendors/data-tables/css/jquery.dataTables.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/app-assets/vendors/data-tables/extensions/responsive/css/responsive.dataTables.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/app-assets/css/pages/data-tables.min.css"">




    <!-- END: VENDOR CSS-->
    <!-- BEGIN: Page Level CSS-->

    <link rel=""stylesheet"" type=""text/css"" href=""/app-assets/css/pages/data-tables.min.css"">
    <style>
        #data-table-simple_filter {
            display: none;
        }

        #data-table-simple_length {
            display: none;
        }

        #data-table-simple_paginate {
            display: none;
        }
    </style>
");
            }
            );
            WriteLiteral(@"
<div class=""row"">
    <div class=""col s12 m12 l12"">
        <div id=""button-trigger"" class=""card card card-default scrollspy"">
            <div class=""card-content"">
                <h4 class=""card-title"">لیست محصول ها</h4>
                <div class=""row"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a899e799fb5bfacdb795db2053dcf490ef7a9c378669", async() => {
                WriteLiteral("\r\n                        <div class=\"app-search\">\r\n                            <i class=\"material-icons mr-2 search-icon\">search</i>\r\n                            <input type=\"text\" name=\"tag\" placeholder=\"جستجوی محصول\" class=\"app-filter iransans\"");
                BeginWriteAttribute("id", " id=\"", 1790, "\"", 1795, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                        </div>
                      
                        <div class=""row"">
                            <div class=""col-12"">
                                <input type=""submit"" class=""waves-effect waves-light btn mb-1 mr-1 "" id=""btnsear"" value=""جست وجو"">
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""col s12"">
                        <table id=""data-table-simple"" class=""display"">
                            <thead>
                                <tr>
                                    <th>اسم</th>
                                    <th>دسته بندی</th>
                                    <th>برند</th>
                                    <th>قیمت</th>
                                    <th>تعداد</th>
                                    <th>عمل</th>

                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 74 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
                                  
                                    foreach (var i in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 78 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
                                           Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 79 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
                                           Write(i.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                            <td>");
#nullable restore
#line 80 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
                                           Write(i.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                            <td>");
#nullable restore
#line 81 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
                                           Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 82 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
                                           Write(i.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                            <td>\r\n                                                <br />\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a899e799fb5bfacdb795db2053dcf490ef7a9c3713713", async() => {
                WriteLiteral("ویرایش");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3463, "~/admin/product/readData/", 3463, 25, true);
#nullable restore
#line 86 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
AddHtmlAttributeValue("", 3488, i.Id, 3488, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3609, "\"", 3632, 3);
            WriteAttributeValue("", 3619, "Delete(", 3619, 7, true);
#nullable restore
#line 87 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
WriteAttributeValue("", 3626, i.Id, 3626, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3631, ")", 3631, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"waves-effect waves-light btn mb-1 mr-1 left\">حذف</a>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a899e799fb5bfacdb795db2053dcf490ef7a9c3715999", async() => {
                WriteLiteral("اطلاعات بیشتر");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3752, "~/admin/product/detail/", 3752, 23, true);
#nullable restore
#line 88 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
AddHtmlAttributeValue("", 3775, i.Id, 3775, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                            </td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 93 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
                                    }

                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tfoot>
                                <tr>
                                    <th>اسم</th>
                                    <th>دسته بندی</th>
                                    <th>برند</th>
                                    <th>قیمت</th>
                                    <th>تعداد</th>
                                    <th>عمل</th>
                                </tr>
                            </tfoot>
                        </table>
                        <div class=""dataTables_paginate paging_simple_numbers"" id=""data-table-simple"">
");
#nullable restore
#line 108 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
                              
                                BissenessLagicLayer.BlProduct bll = new BissenessLagicLayer.BlProduct();
                                int f = bll.gettoall();
                                int count;
                                if (f % 10 == 0) count = f / 10;
                                else count = (f / 10) + 1;
                                var a = 0;
                                for (int i = 0; i < count; i++)
                                {

                                    if (i == 0)
                                    {
                                        a = 1;
                                    }
                                    else
                                    {
                                        a = i;
                                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\" btn   cyan\" style=\"padding-right:17px\" aria-controls=\"data-table-simple\" data-dt-idx=");
#nullable restore
#line 127 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
                                                                                                                               Write(i);

#line default
#line hidden
#nullable disable
            BeginWriteAttribute("href", " href=\"", 5597, "\"", 5647, 1);
#nullable restore
#line 127 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
WriteAttributeValue("", 5604, Url.Action("getskip","Product",new {c=i }), 5604, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"0\">");
#nullable restore
#line 127 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
                                                                                                                                                                                                  Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 128 "E:\WebProject\MansStore\MansStore\Areas\Admin\Views\Product\ShowProductAdmin.cshtml"
                                }



                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- Modal Structure -->\r\n\r\n    </div>\r\n   \r\n\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("script", async() => {
                WriteLiteral("\r\n    <script src=\"//cdn.jsdelivr.net/npm/sweetalert2@11\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a899e799fb5bfacdb795db2053dcf490ef7a9c3721590", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a899e799fb5bfacdb795db2053dcf490ef7a9c3722690", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a899e799fb5bfacdb795db2053dcf490ef7a9c3723790", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n  \r\n    <!-- END PAGE~JS-->\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a899e799fb5bfacdb795db2053dcf490ef7a9c3724927", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a899e799fb5bfacdb795db2053dcf490ef7a9c3726027", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
       
        function Delete(id) {
            Swal.fire({
                title: 'حذف محصول',
                text: 'آیا مطمئن به حذف محصول هستید؟',
                icon: 'delete',
                showCancelButton: true,
                focusConfirm: false,
                confirmButtonColor: '#3085d6',
                CancelButtonColor: '#d33',
                confirmButtonText:
                    'بله حذف شود',
                cancelButtonText:
                    'خیر'
            }).then((result) => {
                if (result.isConfirmed) {
                    $.ajax({
                        type: ""post"",
                        data: { id: id }
                        ,
                        url: ""/Admin/Product/delete"",
                        success: function (data) {
                            if (data == ""با موفقیت حذف شد"") {
                                Swal.fire(
                                    'موفق!'
                                ).the");
                WriteLiteral(@"n(function () {
                                    location.reload();
                                });

                            }
                        }
                    }
                    )

                }
            });

        }
       


    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BissnessEntity.ProductsFormAdminList_Dto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
