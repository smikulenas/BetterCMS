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
    
    #line 1 "..\..\Views\Page\AddNewPage.cshtml"
    using BetterCms.Module.Pages;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Page\AddNewPage.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Page\AddNewPage.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Page\AddNewPage.cshtml"
    using BetterCms.Module.Pages.ViewModels.Page;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Page\AddNewPage.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Page\AddNewPage.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Page\AddNewPage.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Views\Page\AddNewPage.cshtml"
    using BetterCms.Module.Root.ViewModels.Security;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Views\Page\AddNewPage.cshtml"
    using BetterCms.Module.Root.ViewModels.Shared;
    
    #line default
    #line hidden
    
    #line 10 "..\..\Views\Page\AddNewPage.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/AddNewPage.cshtml")]
    public partial class _Views_Page_AddNewPage_cshtml : System.Web.Mvc.WebViewPage<AddNewPageViewModel>
    {
        public _Views_Page_AddNewPage_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-tab-header bcms-js-tab-header\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item bcms-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\Page\AddNewPage.cshtml"
                                                                            Write(PagesGlobalization.AddNewPage_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        <a");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\Page\AddNewPage.cshtml"
                                                                Write(PagesGlobalization.AddNewPage_Options);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 22 "..\..\Views\Page\AddNewPage.cshtml"
   Write(Html.TabbedContentMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 23 "..\..\Views\Page\AddNewPage.cshtml"
        
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Page\AddNewPage.cshtml"
         using (Html.BeginForm<PageController>(f => f.AddNewPage(null, null), FormMethod.Post, new { @class = "bcms-ajax-form" }))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-padded-content\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 28 "..\..\Views\Page\AddNewPage.cshtml"
                   Write(Html.Tooltip(PagesGlobalization.AddNewPage_PageTitle_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 29 "..\..\Views\Page\AddNewPage.cshtml"
                                                    Write(PagesGlobalization.AddNewPage_PageTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 31 "..\..\Views\Page\AddNewPage.cshtml"
                       Write(Html.TextBoxFor(f => f.PageTitle, new { @class = "bcms-editor-field-box", @id = "PageTitle" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 32 "..\..\Views\Page\AddNewPage.cshtml"
                       Write(Html.BcmsValidationMessageFor(f => f.PageTitle));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

WriteLiteral("                    ");

            
            #line 35 "..\..\Views\Page\AddNewPage.cshtml"
               Write(Html.Partial("Partial/AddNewPageEditPermalink"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-addpage-title\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 37 "..\..\Views\Page\AddNewPage.cshtml"
                   Write(Html.Tooltip(PagesGlobalization.AddNewPage_Template_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\Page\AddNewPage.cshtml"
                                                    Write(PagesGlobalization.AddNewPage_Template);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"bcms-info-message-box\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" class=\"bcms-btn-close\"");

WriteLiteral(" id=\"bcms-addnewpage-closeinfomessage\"");

WriteLiteral(">");

            
            #line 41 "..\..\Views\Page\AddNewPage.cshtml"
                                                                                   Write(RootGlobalization.Button_Close);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

WriteLiteral("                        ");

            
            #line 42 "..\..\Views\Page\AddNewPage.cshtml"
                   Write(Html.Raw(PagesGlobalization.AddNewPage_Template_InfoMessage_Text));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

WriteLiteral("                    ");

            
            #line 44 "..\..\Views\Page\AddNewPage.cshtml"
               Write(Html.Partial("Partial/TemplatesList", Model.Templates));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 45 "..\..\Views\Page\AddNewPage.cshtml"
               Write(Html.HiddenFor(f => f.TemplateId, new { @id = "TemplateId" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 46 "..\..\Views\Page\AddNewPage.cshtml"
               Write(Html.HiddenFor(f => f.MasterPageId, new { @id = "MasterPageId" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 47 "..\..\Views\Page\AddNewPage.cshtml"
               Write(Html.HiddenFor(f => f.ParentPageUrl));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 48 "..\..\Views\Page\AddNewPage.cshtml"
               Write(Html.HiddenFor(f => f.CreateMasterPage));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 49 "..\..\Views\Page\AddNewPage.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Page\AddNewPage.cshtml"
                     if (Model.Languages != null && Model.Languages.Any())
                {
                    
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Page\AddNewPage.cshtml"
               Write(Html.HiddenFor(model => model.LanguageId, new { data_bind = "value: language.languageId()" }));

            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Page\AddNewPage.cshtml"
                                                                                                                  
                }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 53 "..\..\Views\Page\AddNewPage.cshtml"
               Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 54 "..\..\Views\Page\AddNewPage.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Page\AddNewPage.cshtml"
                     if (Model.AccessControlEnabled)
                {
                    var viewModel = new UserAccessTemplateViewModel
                                        {
                                            Title = PagesGlobalization.AddNewPage_UserAccess,
                                            Tooltip = PagesGlobalization.AddNewPage_UserAccess_Tooltip_Description
                                        };
                    
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Page\AddNewPage.cshtml"
               Write(Html.Partial(RootModuleConstants.AccessControlTemplate, viewModel));

            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Page\AddNewPage.cshtml"
                                                                                       
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 64 "..\..\Views\Page\AddNewPage.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\Page\AddNewPage.cshtml"
                     if (Model.ShowLanguages)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(" data-bind=\"with: language\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 67 "..\..\Views\Page\AddNewPage.cshtml"
                   Write(Html.Tooltip(PagesGlobalization.AddNewPage_Language_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 68 "..\..\Views\Page\AddNewPage.cshtml"
                                                    Write(PagesGlobalization.AddNewPage_Language);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <select");

WriteLiteral(" class=\"bcms-global-select\"");

WriteLiteral(" data-bind=\"options: languages, optionsText: \'value\', optionsValue: \'key\', value:" +
" languageId\"");

WriteLiteral("></select>\r\n                    </div>\r\n");

            
            #line 71 "..\..\Views\Page\AddNewPage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n");

            
            #line 74 "..\..\Views\Page\AddNewPage.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(" data-bind=\"with: options\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 76 "..\..\Views\Page\AddNewPage.cshtml"
           Write(Html.Partial(PagesConstants.OptionValuesGridTemplate, new EditableGridViewModel()));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 78 "..\..\Views\Page\AddNewPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
