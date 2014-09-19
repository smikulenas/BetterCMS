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

namespace BetterCms.Module.ImagesGallery.Views.GalleryWidget
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
    
    #line 1 "..\..\Views\GalleryWidget\List.cshtml"
    using BetterCms.Module.ImagesGallery;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\GalleryWidget\List.cshtml"
    using BetterCms.Module.ImagesGallery.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/GalleryWidget/List.cshtml")]
    public partial class List : System.Web.Mvc.WebViewPage<BetterCms.Module.ImagesGallery.ViewModels.GalleryViewModel>
    {
        public List()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\GalleryWidget\List.cshtml"
 if (Model.LoadCmsStyles)
{
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\GalleryWidget\List.cshtml"
Write(Html.Partial("Partial/ListStyles"));

            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\GalleryWidget\List.cshtml"
                                       
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\Views\GalleryWidget\List.cshtml"
  
    var i = 0;
    var l = Model.Albums.Count;
    var perSection = Model.ImagesPerSection <= 0 ? l : Model.ImagesPerSection;
    
    foreach (var album in Model.Albums)
    {
        if (i % perSection == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("<section>\r\n");

            
            #line 20 "..\..\Views\GalleryWidget\List.cshtml"
        }
        

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-album-holder\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 576), Tuple.Create("\"", 602)
            
            #line 23 "..\..\Views\GalleryWidget\List.cshtml"
, Tuple.Create(Tuple.Create("", 582), Tuple.Create<System.Object, System.Int32>(album.CoverImageUrl
            
            #line default
            #line hidden
, 582), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 603), Tuple.Create("\"", 621)
            
            #line 23 "..\..\Views\GalleryWidget\List.cshtml"
, Tuple.Create(Tuple.Create("", 609), Tuple.Create<System.Object, System.Int32>(album.Title
            
            #line default
            #line hidden
, 609), false)
);

WriteLiteral(" />\r\n            <div");

WriteLiteral(" class=\"bcms-album-name\"");

WriteLiteral(">\r\n                <h4><a");

WriteAttribute("href", Tuple.Create(" href=\"", 692), Tuple.Create("\"", 709)
            
            #line 25 "..\..\Views\GalleryWidget\List.cshtml"
, Tuple.Create(Tuple.Create("", 699), Tuple.Create<System.Object, System.Int32>(album.Url
            
            #line default
            #line hidden
, 699), false)
);

WriteLiteral(">");

            
            #line 25 "..\..\Views\GalleryWidget\List.cshtml"
                                    Write(album.Title);

            
            #line default
            #line hidden
WriteLiteral("</a></h4>\r\n                <span>");

            
            #line 26 "..\..\Views\GalleryWidget\List.cshtml"
                 Write(album.ImagesCount);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 26 "..\..\Views\GalleryWidget\List.cshtml"
                                    Write(ImagesGalleryGlobalization.GalleryWidget_Pictures);

            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\GalleryWidget\List.cshtml"
                                                                                            if (album.LastUpdateDate.HasValue) { 
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\GalleryWidget\List.cshtml"
                                                                                                                            Write(Html.Raw(","));

            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\GalleryWidget\List.cshtml"
                                                                                                                                                }
            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 27 "..\..\Views\GalleryWidget\List.cshtml"
                
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\GalleryWidget\List.cshtml"
                 if (album.LastUpdateDate.HasValue)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <time");

WriteAttribute("datetime", Tuple.Create(" datetime=\"", 985), Tuple.Create("\"", 1095)
            
            #line 29 "..\..\Views\GalleryWidget\List.cshtml"
, Tuple.Create(Tuple.Create("", 996), Tuple.Create<System.Object, System.Int32>(album.LastUpdateDate.Value.ToString(ImagesGalleryModuleConstants.GalleryWidgetUpdateDateTagFormat)
            
            #line default
            #line hidden
, 996), false)
);

WriteLiteral(">");

            
            #line 29 "..\..\Views\GalleryWidget\List.cshtml"
                                                                                                                                    Write(album.LastUpdateDate.Value.ToString(ImagesGalleryModuleConstants.GalleryWidgetUpdateDateDisplayFormat));

            
            #line default
            #line hidden
WriteLiteral("</time>\r\n");

            
            #line 30 "..\..\Views\GalleryWidget\List.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n");

            
            #line 33 "..\..\Views\GalleryWidget\List.cshtml"

        i++;

        if (i % perSection == 0 || i == l)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("</section>\r\n");

            
            #line 39 "..\..\Views\GalleryWidget\List.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591