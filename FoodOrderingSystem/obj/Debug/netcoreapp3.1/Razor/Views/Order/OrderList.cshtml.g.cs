#pragma checksum "D:\软件开发实训\FoodOrderingSystem\FoodOrderingSystem\Views\Order\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "454a8b43b4a12eb0511d5bba836540ef213fabc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderList), @"mvc.1.0.view", @"/Views/Order/OrderList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454a8b43b4a12eb0511d5bba836540ef213fabc6", @"/Views/Order/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f4e746d81c78bfd8426e836b90f92c129f14c26", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "已付款", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "已发货", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "已完成", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\软件开发实训\FoodOrderingSystem\FoodOrderingSystem\Views\Order\OrderList.cshtml"
  
    ViewData["Title"] = "Order List";
    Layout = "~/Views/Shared/_Layout_Content.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""wrapper wrapper-content"" id=""app"">
    <div class=""ibox float-e-margins"">
        <div class=""ibox-title"">
            <h5>订单列表</h5>
            <div class=""ibox-tools"">
                <a class=""collapse-link"">
                    <i class=""fa fa-chevron-up""></i>
                </a>
            </div>
        </div>
        <div class=""ibox-content"">
            <div class=""form-group"">
                <button type=""button"" class=""btn btn-info"" ");
            WriteLiteral(@"@click=""editOrder()"">
                    <i class=""fa fa-pencil""></i> &nbsp;编辑</button>
            </div>

            <div class=""jqGrid_wrapper"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th></th>
                            <th>订单号</th>
                            <th>用户名</th>
                            <th>送餐地址</th>
                            <th>预定时间</th>
                            <th>金额</th>
                            <th>订单状态</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for=""item in tableData"">
                            <td><input type=""checkbox"" v-model=""item.checked"" /></td>
                            <td>{{item.id}}</td>
                            <td>{{item.userName}}</td>
                            <td>{{item.address}}</td>
                            <td>{{item.createTime}}</td>
           ");
            WriteLiteral(@"                 <td>{{item.price}}元</td>
                            <td>
                                <template v-if=""!item.isEdit"">
                                    {{item.status}}
                                </template>
                                <template v-else>
                                    <select class=""form-control"" v-model=""item.status"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "454a8b43b4a12eb0511d5bba836540ef213fabc66278", async() => {
                WriteLiteral("已付款");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "454a8b43b4a12eb0511d5bba836540ef213fabc67474", async() => {
                WriteLiteral("已发货");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "454a8b43b4a12eb0511d5bba836540ef213fabc68670", async() => {
                WriteLiteral("已完成");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </select>\r\n\r\n                                    <button type=\"button\" class=\"btn btn-info \" ");
            WriteLiteral("@click=\"saveOrder(item)\">\r\n                                        <i class=\"fa fa-pencil\"></i> &nbsp;保存\r\n                                    </button>\r\n                                    <button type=\"button\" class=\"btn btn-danger \" ");
            WriteLiteral(@"@click=""cancelOrder(item)"">
                                        <i class=""fa fa-remove""></i>&nbsp;&nbsp;<span class=""bold"">取消</span>
                                    </button>
                                </template>
                            </td>
                        </tr>
                    </tbody>
                </table>

                <pagination v-model=""pagerOpt.page"" :total=""pagerOpt.total"" :page-size=""pagerOpt.pageSize"" ");
            WriteLiteral(@"@input=""pageChange()""></pagination>
            </div>
        </div>
    </div>
</div>

<script>
    var app = new Vue({
        el: '#app',
        data: {
            tableData: [],

            pagerOpt: {
                pageSize: 10,
                page: 1,
                total: 0,
            },

            backup: """"
        },
        mounted() {
            this.getData();
        },
        methods: {
            getData() {
                var params = `pageNo=${this.pagerOpt.page}&pageSize=${this.pagerOpt.pageSize}`
                _fetch(""/Order/GetOrders?"" + params, ""GET"").then(res => {
                    if (res.status = ""Success"") {
                        
                        res.data.filter(x => {
                            x.checked = false;
                            x.isEdit = false;
                        });
                        this.tableData = res.data;
                        this.pagerOpt.total = res.total;
                    }
   ");
            WriteLiteral(@"                 else {
                        alert(""系统出错了！"");
                    }
                });
            },

            editOrder() {
                var ids = [];
                this.tableData.filter(v => {
                    if (v.checked) {
                        ids.push(v.id);
                    }
                });

                if (ids.length == 0 || ids.length > 1) {
                    alert('请先选择一份订单');
                    return;
                }

                var item = this.tableData.find(x => x.id == ids[0]);
                item.isEdit = true;
                this.backup = item.status;
            },

            cancelOrder(item) {
                item.isEdit = false;
                item.status = this.backup;
            },

            //修改并保存订单的最新状态
            saveOrder(item) {
                var parms = `id=${item.id}&status=${item.status}`
                _fetch(""/Order/Save?"" + parms, ""Post"").then(res => {
                    ");
            WriteLiteral(@"if (res.status = ""Success"") {
                        this.getData();
                    }
                    else {
                        alert(""系统出错了！"");
                    }
                });
            },
            pageChange() {
                this.getData();
            }
        }
    });
</script>

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
