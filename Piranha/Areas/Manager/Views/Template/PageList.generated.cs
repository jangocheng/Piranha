﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Template
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Template/PageList.cshtml")]
    public partial class PageList : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.TemplateModels.PageListModel>
    {
        public PageList()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
  
    ViewBag.Title = @Piranha.Resources.Template.ListTitlePage ;
    ViewBag.Selected = "Settings" ;
    ViewBag.SelectedTab = "PageType" ;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Head", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(document).ready(function() {\r\n            $(\".delete\").click(functio" +
"n() {\r\n                return confirm(\"");

            
            #line 11 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                           Write(Piranha.Resources.Template.MessageDeletePageConfirm);

            
            #line default
            #line hidden
WriteLiteral(@""") ;
            });

            var options = {
                listClass:  'list-js',
                searchId: 'search',
                valueNames: ['name', 'created', 'updated']
            };
            var list = new List('list', options);
        });
    </script>
");

});

DefineSection("Toolbar", () => {

WriteLiteral(" \r\n");

            
            #line 24 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 853), Tuple.Create("\"", 879)
            
            #line 28 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
, Tuple.Create(Tuple.Create("", 860), Tuple.Create<System.Object, System.Int32>(Url.Action("page")
            
            #line default
            #line hidden
, 860), false)
);

WriteLiteral(" class=\"add\"");

WriteLiteral(">");

            
            #line 28 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                                     Write(Piranha.Resources.Global.ToolbarAdd);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 29 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                      Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <button");

WriteLiteral(" class=\"search\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1078), Tuple.Create("\"", 1125)
            
            #line 31 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
, Tuple.Create(Tuple.Create("", 1086), Tuple.Create<System.Object, System.Int32>(Piranha.Resources.Global.ToolbarSearch
            
            #line default
            #line hidden
, 1086), false)
);

WriteLiteral("></button>");

            
            #line 31 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                                                                   Write(Html.TextBox("search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

WriteLiteral("<div");

WriteLiteral(" class=\"grid_12\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" id=\"list\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th><span");

WriteLiteral(" class=\"sort asc\"");

WriteLiteral(" data-sort=\"name\"");

WriteLiteral(">");

            
            #line 40 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                                       Write(Piranha.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"created\"");

WriteLiteral(">");

            
            #line 41 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                                      Write(Piranha.Resources.Global.Created);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"updated\"");

WriteLiteral(">");

            
            #line 42 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                                      Write(Piranha.Resources.Global.Updated);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n   " +
"     <tbody");

WriteLiteral(" class=\"list-js\"");

WriteLiteral(">\r\n");

            
            #line 47 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 47 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
             foreach (var pt in Model.Templates) {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1831), Tuple.Create("\"", 1877)
            
            #line 49 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
, Tuple.Create(Tuple.Create("", 1838), Tuple.Create<System.Object, System.Int32>(Url.Action("page", new { id = pt.Id })
            
            #line default
            #line hidden
, 1838), false)
);

WriteLiteral(">");

            
            #line 49 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                                                              Write(pt.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                <td");

WriteLiteral(" class=\"created date\"");

WriteLiteral(">");

            
            #line 50 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                    Write(pt.Created.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"updated date\"");

WriteLiteral(">");

            
            #line 51 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                                    Write(pt.Updated.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"buttons one\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"icon delete\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2146), Tuple.Create("\"", 2196)
            
            #line 53 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
, Tuple.Create(Tuple.Create("", 2154), Tuple.Create<System.Object, System.Int32>(Piranha.Resources.Template.ListDeletePage
            
            #line default
            #line hidden
, 2154), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 2197), Tuple.Create("\"", 2249)
            
            #line 53 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
                    , Tuple.Create(Tuple.Create("", 2204), Tuple.Create<System.Object, System.Int32>(Url.Action("deletepage", new { id = pt.Id })
            
            #line default
            #line hidden
, 2204), false)
);

WriteLiteral("></a></td>\r\n            </tr>\r\n");

            
            #line 55 "..\..\Areas\Manager\Views\Template\PageList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td");

WriteLiteral(" colspan=\"5\"");

WriteLiteral("></td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
