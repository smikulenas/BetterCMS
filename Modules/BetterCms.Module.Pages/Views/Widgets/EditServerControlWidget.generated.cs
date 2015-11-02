﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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
    
    #line 1 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Pages;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Pages.ViewModels.Widgets;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Root.ViewModels.Category;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/EditServerControlWidget.cshtml")]
    public partial class _Views_Widgets_EditServerControlWidget_cshtml : System.Web.Mvc.WebViewPage<EditServerControlWidgetViewModel>
    {
        public _Views_Widgets_EditServerControlWidget_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 11 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
  
    var categoriesTemplateViewModel = new CategoryTemplateViewModel
    {
        TooltipDescription = PagesGlobalization.EditPageProperties_BasicPropertiesTab_Category_Tooltip_Description
    };

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 18 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
 if (Model == null)
{
    return;
}

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-tab-header bcms-js-tab-header\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item bcms-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">");

            
            #line 23 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                        Write(PagesGlobalization.EditWidget_BasicPropertiesTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    <a");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                            Write(PagesGlobalization.EditWidget_OptionsTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n</div>\n\n<div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(">\n");

WriteLiteral("    ");

            
            #line 28 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
Write(Html.TabbedContentMessagesBox("bcms-edit-widget-messages"));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("    ");

            
            #line 29 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
Write(Html.Partial("Partial/WarnMessageAboutDraft", Model));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 30 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
     using (Html.BeginForm<WidgetsController>(c => c.EditServerControlWidget((string)null), FormMethod.Post, new { @id = "bcms-widget-form", @class = "bcms-ajax-form" }))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\n            <div");

WriteLiteral(" class=\"bcms-padded-content\"");

WriteLiteral(">\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 35 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
               Write(Html.Tooltip(PagesGlobalization.Widget_Title_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                Write(PagesGlobalization.Widget_Title_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                    <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 38 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                   Write(Html.TextBoxFor(model => model.Name, new { @class = "bcms-editor-field-box" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                        ");

            
            #line 39 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.Name));

            
            #line default
            #line hidden
WriteLiteral("\n                    </div>\n                </div>\n\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n                \n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 50 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
               Write(Html.Tooltip(PagesGlobalization.Widget_Url_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 51 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                Write(PagesGlobalization.Widget_Url_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                    <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 53 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                   Write(Html.TextBoxFor(model => model.Url, new { @class = "bcms-editor-field-box" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                        ");

            
            #line 54 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.Url));

            
            #line default
            #line hidden
WriteLiteral("\n                    </div>\n                </div>\n\n                <div");

WriteLiteral(" class=\"bcms-tags-box-holder\"");

WriteLiteral(" data-bind=\"with: categories\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 59 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
               Write(Html.Partial("~/Areas/bcms-root/Views/Category/CategoriesTemplate.cshtml", categoriesTemplateViewModel));

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 63 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
               Write(Html.Tooltip(PagesGlobalization.WidgetPreviewImageUrl_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 64 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                Write(PagesGlobalization.WidgetPreviewImageUrl_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                    <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 66 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                   Write(Html.TextBoxFor(model => model.PreviewImageUrl, new { @class = "bcms-editor-field-box" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                        ");

            
            #line 67 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.PreviewImageUrl));

            
            #line default
            #line hidden
WriteLiteral("\n                    </div>\n                </div>\n\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 72 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
               Write(Html.Tooltip(PagesGlobalization.WidgetPreviewImage_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 73 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                Write(PagesGlobalization.WidgetPreviewImage_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n                    <div");

WriteLiteral(" class=\"bcms-preview-module-image\"");

WriteLiteral(">\n                        <div");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\n                            <img");

WriteLiteral(" id=\"bcms-widget-preview-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 3984), Tuple.Create("\"", 4012)
            
            #line 77 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
, Tuple.Create(Tuple.Create("", 3990), Tuple.Create<System.Object, System.Int32>(Model.PreviewImageUrl
            
            #line default
            #line hidden
, 3990), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\n                        </div>\n                    </div>\n\n                </" +
"div>\n            </div>\n        </div>\n");

            
            #line 84 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\n");

WriteLiteral("            ");

            
            #line 86 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
       Write(Html.Partial(PagesConstants.OptionsGridTemplate));

            
            #line default
            #line hidden
WriteLiteral("\n        </div>\n");

            
            #line 88 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
        
        
            
            #line default
            #line hidden
            
            #line 89 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
   Write(Html.HiddenFor(model => model.Id, new { @id = "bcmsContentId" }));

            
            #line default
            #line hidden
            
            #line 89 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                         
        
            
            #line default
            #line hidden
            
            #line 90 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
   Write(Html.HiddenFor(model => model.Version, new { @id = "bcmsContentVersion" }));

            
            #line default
            #line hidden
            
            #line 90 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                                   
        
            
            #line default
            #line hidden
            
            #line 91 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
   Write(Html.HiddenFor(modal => modal.DesirableStatus, new { @class = "bcms-content-desirable-status" }));

            
            #line default
            #line hidden
            
            #line 91 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                                                         
        
            
            #line default
            #line hidden
            
            #line 92 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
   Write(Html.HiddenFor(modal => modal.PreviewOnPageContentId, new { @class = "bcms-preview-page-content-id" }));

            
            #line default
            #line hidden
            
            #line 92 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                                                               
        
            
            #line default
            #line hidden
            
            #line 93 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
   Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
            
            #line 93 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                            
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n");

        }
    }
}
#pragma warning restore 1591
