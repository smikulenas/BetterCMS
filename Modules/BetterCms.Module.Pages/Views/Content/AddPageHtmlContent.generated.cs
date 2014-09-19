﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Pages.Views.Content
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
    
    #line 1 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/AddPageHtmlContent.cshtml")]
    public partial class AddPageHtmlContent : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Content.PageContentViewModel>
    {
        public AddPageHtmlContent()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-tab-header\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" class=\"bcms-tab bcms-tab-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">");

            
            #line 11 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                           Write(PagesGlobalization.AddPageContent_RegularContentTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    <a");

WriteLiteral(" class=\"bcms-tab\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                           Write(PagesGlobalization.AddPageContent_WidgetTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n</div>\r\n");

            
            #line 14 "..\..\Views\Content\AddPageHtmlContent.cshtml"
   ViewBag.CanEdit = (ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.EditContent); 
            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 16 "..\..\Views\Content\AddPageHtmlContent.cshtml"
Write(Html.TabbedContentMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"bcms-padded-content\"");

WriteLiteral(">\r\n            \r\n        <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n");

            
            #line 20 "..\..\Views\Content\AddPageHtmlContent.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Content\AddPageHtmlContent.cshtml"
             using (Html.BeginForm<ContentController>(c => c.SavePageHtmlContent(null), FormMethod.Post, new { @id = "bcms-content-form", @class = "bcms-ajax-form" }))
            {              
                
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.Partial("Partial/EditHtmlContent", Model));

            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                 
                
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.Id, new { @id = "bcmsPageContentId"}));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                    
                
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.ContentId, new { @id = "bcmsContentId"}));

            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                       
                
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.ParentPageContentId, new { @id = "bcmsParentPageContentId" }));

            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                                            
                
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.PageId));

            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                      
                
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.RegionId, new { @id = "bcmsContentToRegionId" }));

            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                               
                
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(modal => modal.DesirableStatus, new { @class = "bcms-content-desirable-status"}));

            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                                                
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n\r\n        <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 33 "..\..\Views\Content\AddPageHtmlContent.cshtml"
       Write(Html.Partial("Partial/SelectWidget", Model.WidgetCategories));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591