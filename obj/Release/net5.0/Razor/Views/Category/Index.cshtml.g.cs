#pragma checksum "D:\Web\BanSach\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65188e2e9f5b0899912584d1f245c70e1df6005f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "D:\Web\BanSach\Views\_ViewImports.cshtml"
using BanSach;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web\BanSach\Views\_ViewImports.cshtml"
using BanSach.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65188e2e9f5b0899912584d1f245c70e1df6005f", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbdb15628b2748c9c17308dd0512563618f946e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Web\BanSach\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Danh mục";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-navigation\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65188e2e9f5b0899912584d1f245c70e1df6005f4071", async() => {
                WriteLiteral("Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" >\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65188e2e9f5b0899912584d1f245c70e1df6005f5441", async() => {
                WriteLiteral("Sách tiếng Việt");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<div class=""category-all"">
    <div class=""category-list"">
        <div class=""category-list-title"">DANH MỤC SẢN PHẨM</div>
        <div class=""category-list-item"">
            <a href=""#"">Sách kinh tế</a>
            <a href=""#"">Sách thiếu nhi</a>
            <a href=""#"">Sách kỹ năng sống</a>
            <a href=""#"">Sách Khoa Học - Kỹ Thuật</a>
            <a href=""#"">Sách Lịch sử</a>
            <a href=""#"">Điện Ảnh - Nhạc - Họa</a>
            <a href=""#"">Truyện Tranh, Manga, Comic</a>
            <a href=""#"">Sách Tôn Giáo - Tâm Linh</a>
        </div>
    </div>
    <div class=""product"">
        <div class=""product-title"">Sách tiếng Việt</div>

        <div class=""product-sort"">
            <div class=""product-sort-new product-sort-active"">
                Sách mới
            </div>
            <div class=""product-sort-exp"">
                Giá cao
            </div>
            <div class=""product-sort-che"">
                Giá thấp
            </div>
        </div");
            WriteLiteral(@">

        <div class=""product-all"">

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham1.jpg"">
                </div>
                <div class=""product-item-title"">
                    Thần chết làm thêm 300 yên/giờ
                </div>
                <div class=""product-item-price"">105.000 đ</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham1.jpg"">
                </div>
                <div class=""product-item-title"">
                    Thần chết làm thêm 300 yên/giờ
                </div>
                <div class=""product-item-price"">105.000 đ</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham1.jpg"">
                </div>
                <div class=""product-item-title"">
        ");
            WriteLiteral(@"            Thần chết làm thêm 300 yên/giờ
                </div>
                <div class=""product-item-price"">105.000 đ</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham8.jpg"">
                </div>
                <div class=""product-item-title"">
                    Thế giới Otome Game thật khắc nghiệt với nhân vật quần chúng - Tập 1
                </div>
                <div class=""product-item-price"">101.600 đ</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham8.jpg"">
                </div>
                <div class=""product-item-title"">
                    Thế giới Otome Game thật khắc nghiệt với nhân vật quần chúng - Tập 1
                </div>
                <div class=""product-item-price"">101.600 đ</div>
            </div>

            <div class=""product-ite");
            WriteLiteral(@"m"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham8.jpg"">
                </div>
                <div class=""product-item-title"">
                    Thế giới Otome Game thật khắc nghiệt với nhân vật quần chúng - Tập 1
                </div>
                <div class=""product-item-price"">101.600 đ</div>
            </div>
        </div>

        <div class=""product-pagination"">
            <div>
                <a href=""#""> <i class=""fa-solid fa-chevron-left""></i> </a>
            </div>
            <div>
                <a href=""#""> 1 </a>
            </div>
            <div>
                <a href=""#""> 2 </a>
            </div>
            <div>
                <a href=""#""> 3 </a>
            </div>
            <div>
                <a href=""#""> 4 </a>
            </div>
            <div>
                <a href=""#""> 5 </a>
            </div>
            <div>
                <a href=""#""> <i class=""fa-solid fa-chevron-right""></i>");
            WriteLiteral(" </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
