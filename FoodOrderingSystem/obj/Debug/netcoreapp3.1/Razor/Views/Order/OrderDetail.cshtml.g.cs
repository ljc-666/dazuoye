#pragma checksum "D:\软件开发实训\FoodOrderingSystem\FoodOrderingSystem\Views\Order\OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cb4fdb676b3c095d210380ab9e4cbece5ad9d74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderDetail), @"mvc.1.0.view", @"/Views/Order/OrderDetail.cshtml")]
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
#line 1 "D:\软件开发实训\FoodOrderingSystem\FoodOrderingSystem\Views\_ViewImports.cshtml"
using FoodOrderingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\软件开发实训\FoodOrderingSystem\FoodOrderingSystem\Views\_ViewImports.cshtml"
using FoodOrderingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb4fdb676b3c095d210380ab9e4cbece5ad9d74", @"/Views/Order/OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f4e746d81c78bfd8426e836b90f92c129f14c26", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\软件开发实训\FoodOrderingSystem\FoodOrderingSystem\Views\Order\OrderDetail.cshtml"
  
    ViewData["Title"] = "OrderDetail";
    Layout = "~/Views/Shared/_Layout_Content.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""wrapper wrapper-content"">
    <div class=""ibox float-e-margins"">
        <div class=""ibox-title"">
            <h5>订单详情</h5>
            <div class=""ibox-tools"">
                <a class=""collapse-link"">
                    <i class=""fa fa-chevron-up""></i>
                </a>
            </div>
        </div>
        <div class=""ibox-content"">
            <div class=""form-group"">
                <button id=""btnAdd"" type=""button"" class=""btn btn-primary ""><i class=""fa fa-plus""></i>&nbsp;添加</button>
                <button id=""btnEdit"" type=""button"" class=""btn btn-info ""><i class=""fa fa-pencil""></i> 编辑</button>
                <button id=""btnDel"" type=""button"" class=""btn btn-danger "">
                    <i class=""fa fa-remove""></i>&nbsp;&nbsp;<span class=""bold"">删除</span>
                </button>
                <button id=""btnCancel"" type=""button"" class=""btn btn-warning ""><i class=""fa fa-undo""></i> 取消选中状态</button>
            </div>

            <div class=""jqGrid_wrapper""");
            WriteLiteral(">\r\n                <ul id=\"departmentTree\" class=\"ztree\">\r\n                    <li>数据加载中......</li>\r\n                </ul>\r\n                <input type=\"hidden\" id=\"txtParentId\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
