#pragma checksum "D:\Desktop\New folder\GamingShop\GamingShop\Views\Show\ShowPCProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69572cb3bb6e5fb736accf3e77cac64276fe17a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Show_ShowPCProducts), @"mvc.1.0.view", @"/Views/Show/ShowPCProducts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Show/ShowPCProducts.cshtml", typeof(AspNetCore.Views_Show_ShowPCProducts))]
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
#line 1 "D:\Desktop\New folder\GamingShop\GamingShop\Views\_ViewImports.cshtml"
using GamingShop;

#line default
#line hidden
#line 2 "D:\Desktop\New folder\GamingShop\GamingShop\Views\_ViewImports.cshtml"
using GamingShop.Models;

#line default
#line hidden
#line 3 "D:\Desktop\New folder\GamingShop\GamingShop\Views\_ViewImports.cshtml"
using GamingShop.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69572cb3bb6e5fb736accf3e77cac64276fe17a0", @"/Views/Show/ShowPCProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8758681afa7bf21b8a74fed78fc0974b07b809d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Show_ShowPCProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TblProduct>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Desktop\New folder\GamingShop\GamingShop\Views\Show\ShowPCProducts.cshtml"
  
    ViewData["Title"] = "ShowPCProducts";

#line default
#line hidden
            BeginContext(77, 216, true);
            WriteLiteral("<div class=\"col-md-12\">\r\n    <div class=\"row\">\r\n        <div class=\"products-tabs\">\r\n            <div id=\"tab2\" class=\"tab-pane fade in active\">\r\n                <div class=\"products-slick\" data-nav=\"#slick-nav-2\">\r\n");
            EndContext();
#line 11 "D:\Desktop\New folder\GamingShop\GamingShop\Views\Show\ShowPCProducts.cshtml"
                     foreach (var item in Model)
                    {


#line default
#line hidden
            BeginContext(368, 44, true);
            WriteLiteral("                        <div class=\"product\"");
            EndContext();
            BeginWriteAttribute("productid", " productid=\"", 412, "\"", 432, 1);
#line 14 "D:\Desktop\New folder\GamingShop\GamingShop\Views\Show\ShowPCProducts.cshtml"
WriteAttributeValue("", 424, item.Id, 424, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(433, 106, true);
            WriteLiteral(">\r\n                            <div style=\"width:100%;height:200px\">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 539, "\"", 635, 1);
#line 16 "D:\Desktop\New folder\GamingShop\GamingShop\Views\Show\ShowPCProducts.cshtml"
WriteAttributeValue("", 545, $"data:image/jpg;base64,{Convert.ToBase64String(item.TblProductImgs.First().ImgThumb)}", 545, 90, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(636, 256, true);
            WriteLiteral(@">
                                <div class=""product-label"">
                                </div>
                            </div>
                            <div class=""product-body"">
                                <p class=""product-category"">");
            EndContext();
            BeginContext(893, 21, false);
#line 21 "D:\Desktop\New folder\GamingShop\GamingShop\Views\Show\ShowPCProducts.cshtml"
                                                       Write(item.TblCategory.Name);

#line default
#line hidden
            EndContext();
            BeginContext(914, 75, true);
            WriteLiteral("</p>\r\n                                <h3 class=\"product-name\"><a href=\"#\">");
            EndContext();
            BeginContext(990, 16, false);
#line 22 "D:\Desktop\New folder\GamingShop\GamingShop\Views\Show\ShowPCProducts.cshtml"
                                                                Write(item.TblAll.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1006, 69, true);
            WriteLiteral("</a></h3>\r\n                                <h4 class=\"product-price\">");
            EndContext();
            BeginContext(1076, 10, false);
#line 23 "D:\Desktop\New folder\GamingShop\GamingShop\Views\Show\ShowPCProducts.cshtml"
                                                     Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1086, 32, true);
            WriteLiteral(" <del class=\"product-old-price\">");
            EndContext();
            BeginContext(1119, 10, false);
#line 23 "D:\Desktop\New folder\GamingShop\GamingShop\Views\Show\ShowPCProducts.cshtml"
                                                                                                Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1129, 706, true);
            WriteLiteral(@"</del></h4>
                                <div class=""product-rating"">
                                    <i class=""fa fa-star""></i>
                                    <i class=""fa fa-star""></i>
                                    <i class=""fa fa-star""></i>
                                    <i class=""fa fa-star""></i>
                                    <i class=""fa fa-star""></i>
                                </div>
                                <div class=""product-btns"">

                                </div>
                            </div>
                            <div class=""add-to-cart"">
                                <button class=""add-to-cart-btn"" id=""addtocart""");
            EndContext();
            BeginWriteAttribute("cartid", " cartid=\"", 1835, "\"", 1852, 1);
#line 36 "D:\Desktop\New folder\GamingShop\GamingShop\Views\Show\ShowPCProducts.cshtml"
WriteAttributeValue("", 1844, item.Id, 1844, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1853, 132, true);
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i>اضافه به سبد خرید</button>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 39 "D:\Desktop\New folder\GamingShop\GamingShop\Views\Show\ShowPCProducts.cshtml"
                    }

#line default
#line hidden
            BeginContext(2008, 1064, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<script>
        $(function () {
            $(addtocart).click(function () {
                var cartid = $(this).attr('cartid');
                $.post('/PurchaseCard/AddToCart', { cartid: cartid }, function (value) {
                    if (value === true) {
                        alert(""Succuss"");
                    }
                })
            })
        })
        $(addtowish).click(function () {
            var cartid = $(this).attr('cartid');
            $.post('/WishList/AddToCart', { cartid: cartid }, function (value) {
                if (value === true) {
                    alert(""Succuss"");
                }
            })
        })
        $(quickview).click(function () {
            var cartid = $(this).attr('cartid');
            $.post('/Show/CheckQuickView', { cartid: cartid }, function (value) {
                if (value === true) {
                    alert(""S"");
                ");
            WriteLiteral("}\r\n            })\r\n        })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TblProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
