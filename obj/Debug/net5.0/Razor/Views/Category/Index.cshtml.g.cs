#pragma checksum "D:\Web\BanSach\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6172e4f41afaff045da386aa5ce612ccaaf06660"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6172e4f41afaff045da386aa5ce612ccaaf06660", @"/Views/Category/Index.cshtml")]
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
  
    ViewData["Title"] = "Danh m???c";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-navigation\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6172e4f41afaff045da386aa5ce612ccaaf066604071", async() => {
                WriteLiteral("Trang ch???");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6172e4f41afaff045da386aa5ce612ccaaf066605441", async() => {
                WriteLiteral("S??ch ti???ng Vi???t");
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
        <div class=""category-list-title"">DANH M???C S???N PH???M</div>
        <div class=""category-list-item"">
            <a href=""#"">S??ch kinh t???</a>
            <a href=""#"">S??ch thi???u nhi</a>
            <a href=""#"">S??ch k??? n??ng s???ng</a>
            <a href=""#"">S??ch Khoa H???c - K??? Thu???t</a>
            <a href=""#"">S??ch L???ch s???</a>
            <a href=""#"">??i???n ???nh - Nh???c - H???a</a>
            <a href=""#"">Truy???n Tranh, Manga, Comic</a>
            <a href=""#"">S??ch T??n Gi??o - T??m Linh</a>
        </div>
    </div>
    <div class=""product"">
        <div class=""product-title"">S??ch ti???ng Vi???t</div>

        <div class=""product-sort"">
            <div class=""product-sort-new product-sort-active"">
                S??ch m???i
            </div>
            <div class=""product-sort-exp"">
                Gi?? cao
            </div>
            <div class=""product-sort-che"">
                Gi?? th???p
            </div>
        </div");
            WriteLiteral(@">

        <div class=""product-all"">

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham1.jpg"">
                </div>
                <div class=""product-item-title"">
                    Th???n ch???t l??m th??m 300 y??n/gi???
                </div>
                <div class=""product-item-price"">105.000 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham1.jpg"">
                </div>
                <div class=""product-item-title"">
                    Th???n ch???t l??m th??m 300 y??n/gi???
                </div>
                <div class=""product-item-price"">105.000 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham1.jpg"">
                </div>
                <div class=""product-item-title"">
        ");
            WriteLiteral(@"            Th???n ch???t l??m th??m 300 y??n/gi???
                </div>
                <div class=""product-item-price"">105.000 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham1.jpg"">
                </div>
                <div class=""product-item-title"">
                    Th???n ch???t l??m th??m 300 y??n/gi???
                </div>
                <div class=""product-item-price"">105.000 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham8.jpg"">
                </div>
                <div class=""product-item-title"">
                    Th??? gi???i Otome Game th???t kh???c nghi???t v???i nh??n v???t qu???n ch??ng - T???p 1
                </div>
                <div class=""product-item-price"">101.600 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""produ");
            WriteLiteral(@"ct-item-img"">
                    <img src=""/images/sanpham8.jpg"">
                </div>
                <div class=""product-item-title"">
                    Th??? gi???i Otome Game th???t kh???c nghi???t v???i nh??n v???t qu???n ch??ng - T???p 1
                </div>
                <div class=""product-item-price"">101.600 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham8.jpg"">
                </div>
                <div class=""product-item-title"">
                    Th??? gi???i Otome Game th???t kh???c nghi???t v???i nh??n v???t qu???n ch??ng - T???p 1
                </div>
                <div class=""product-item-price"">101.600 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham8.jpg"">
                </div>
                <div class=""product-item-title"">
                    Th??? gi???i Otome Game th???t kh");
            WriteLiteral(@"???c nghi???t v???i nh??n v???t qu???n ch??ng - T???p 1
                </div>
                <div class=""product-item-price"">101.600 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham7.jpg"">
                </div>
                <div class=""product-item-title"">
                    H??y khi???n t????ng lai bi???t ??n v?? hi???n t???i b???n ???? c??? g???ng h???t m??nh
                </div>
                <div class=""product-item-price"">99.000 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham7.jpg"">
                </div>
                <div class=""product-item-title"">
                    H??y khi???n t????ng lai bi???t ??n v?? hi???n t???i b???n ???? c??? g???ng h???t m??nh
                </div>
                <div class=""product-item-price"">99.000 ??</div>
            </div>

            <div class=""product-item"">
        ");
            WriteLiteral(@"        <div class=""product-item-img"">
                    <img src=""/images/sanpham7.jpg"">
                </div>
                <div class=""product-item-title"">
                    H??y khi???n t????ng lai bi???t ??n v?? hi???n t???i b???n ???? c??? g???ng h???t m??nh
                </div>
                <div class=""product-item-price"">99.000 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham7.jpg"">
                </div>
                <div class=""product-item-title"">
                    H??y khi???n t????ng lai bi???t ??n v?? hi???n t???i b???n ???? c??? g???ng h???t m??nh
                </div>
                <div class=""product-item-price"">99.000 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham9.jpg"">
                </div>
                <div class=""product-item-title"">
                    M???t tho??ng ta ");
            WriteLiteral(@"r???c r??? ??? nh??n gian
                </div>
                <div class=""product-item-price"">135.000 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham9.jpg"">
                </div>
                <div class=""product-item-title"">
                    M???t tho??ng ta r???c r??? ??? nh??n gian
                </div>
                <div class=""product-item-price"">135.000 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham9.jpg"">
                </div>
                <div class=""product-item-title"">
                    M???t tho??ng ta r???c r??? ??? nh??n gian
                </div>
                <div class=""product-item-price"">135.000 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanph");
            WriteLiteral(@"am9.jpg"">
                </div>
                <div class=""product-item-title"">
                    M???t tho??ng ta r???c r??? ??? nh??n gian
                </div>
                <div class=""product-item-price"">135.000 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham6.jpg"">
                </div>
                <div class=""product-item-title"">
                    86 - Eightysix - Ep.5
                </div>
                <div class=""product-item-price"">145.000 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham6.jpg"">
                </div>
                <div class=""product-item-title"">
                    86 - Eightysix - Ep.5
                </div>
                <div class=""product-item-price"">145.000 ??</div>
            </div>

            <div class=""product-it");
            WriteLiteral(@"em"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham6.jpg"">
                </div>
                <div class=""product-item-title"">
                    86 - Eightysix - Ep.5
                </div>
                <div class=""product-item-price"">145.000 ??</div>
            </div>

            <div class=""product-item"">
                <div class=""product-item-img"">
                    <img src=""/images/sanpham6.jpg"">
                </div>
                <div class=""product-item-title"">
                    86 - Eightysix - Ep.5
                </div>
                <div class=""product-item-price"">145.000 ??</div>
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
           ");
            WriteLiteral(@" </div>
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
                <a href=""#""> <i class=""fa-solid fa-chevron-right""></i> </a>
            </div>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
