#pragma checksum "D:\VisualStudioProjects\ARMS\ARMS.UI\Areas\Staff\Views\State\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aee4725ca1fe7fd2416d5b9a129bc38e176e7dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Staff_Views_State_Index), @"mvc.1.0.view", @"/Areas/Staff/Views/State/Index.cshtml")]
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
#line 1 "D:\VisualStudioProjects\ARMS\ARMS.UI\Areas\Staff\Views\_ViewImports.cshtml"
using ARMS.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VisualStudioProjects\ARMS\ARMS.UI\Areas\Staff\Views\_ViewImports.cshtml"
using ARMS.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\VisualStudioProjects\ARMS\ARMS.UI\Areas\Staff\Views\State\Index.cshtml"
using ARMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VisualStudioProjects\ARMS\ARMS.UI\Areas\Staff\Views\State\Index.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aee4725ca1fe7fd2416d5b9a129bc38e176e7dd", @"/Areas/Staff/Views/State/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c3e36393d0d3a40e45d8e33fbcce0b0eb53591", @"/Areas/Staff/Views/_ViewImports.cshtml")]
    public class Areas_Staff_Views_State_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\VisualStudioProjects\ARMS\ARMS.UI\Areas\Staff\Views\State\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\VisualStudioProjects\ARMS\ARMS.UI\Areas\Staff\Views\State\Index.cshtml"
Write(Html.DevExtreme().DataGrid<State>()
      .ShowBorders(true)
      .DataSource(d => d.Mvc().Controller("State")
          .LoadAction("Get")
          .InsertAction("Insert")
          .UpdateAction("Update")
          .Key("Id"))
      .Columns(columns =>
      {
          columns.AddFor(m => m.NameOfState);
          columns.Add()
              .Type(GridCommandColumnType.Buttons)
              .Buttons(b =>
              {
                  b.Add().Name(GridColumnButtonName.Edit);
                  b.Add().Name(GridColumnButtonName.Delete);
              });
      })
      .Paging(p => p.PageSize(10))
      .FilterRow(f => f.Visible(true))
      .SearchPanel(searchPanel => searchPanel
          .Visible(true)
          .Width(240)
          .Placeholder("Search...")
      )
      .HeaderFilter(f => f.Visible(true))
      .GroupPanel(p => p.Visible(true))
      .Grouping(g => g.AutoExpandAll(false))
      .RemoteOperations(true)
      .Editing(e =>
      {
          e.Mode(GridEditMode.Cell);
          e.AllowAdding(true);
          e.AllowUpdating(true);
          e.UseIcons(true);
      })
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
