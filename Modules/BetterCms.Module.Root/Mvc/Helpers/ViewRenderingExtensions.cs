﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;

using BetterCms.Core.Modules.Projections;
using BetterCms.Module.Root.Models;
using BetterCms.Module.Root.ViewModels.Cms;

namespace BetterCms.Module.Root.Mvc.Helpers
{
    public static class ViewRenderingExtensions
    {
        /// <summary>
        /// Renders the view to string.
        /// </summary>
        /// <param name="controller">The controller.</param>
        /// <param name="viewName">Name of the view.</param>
        /// <param name="model">The model.</param>
        /// <param name="enableFormContext">if set to <c>true</c> enable form context.</param>
        /// <returns>View, rendered to string</returns>
        public static string RenderViewToString(this CmsControllerBase controller, string viewName, object model, bool enableFormContext = false)
        {
            if (string.IsNullOrEmpty(viewName))
            {
                viewName = controller.ControllerContext.RouteData.GetRequiredString("action");
            }

            controller.ViewData.Model = model;

            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(controller.ControllerContext, viewName);
                var viewContext = new ViewContext(controller.ControllerContext, viewResult.View, controller.ViewData, controller.TempData, sw);
                if (enableFormContext && viewContext.FormContext == null)
                {
                    viewContext.FormContext = new FormContext();
                }

                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(controller.ControllerContext, viewResult.View);

                return sw.GetStringBuilder().ToString();
            }
        }

        /// <summary>
        /// Renders the page to string.
        /// </summary>
        /// <param name="controller">The controller.</param>
        /// <param name="renderPageViewModel">The render page view model.</param>
        /// <returns>Renders page to string</returns>
        public static string RenderPageToString(this CmsControllerBase controller, RenderPageViewModel renderPageViewModel)
        {
            var htmlHelper = GetHtmlHelper(controller);

            var html = RenderRecursively(controller, renderPageViewModel, renderPageViewModel, htmlHelper);
// TODO:    html = DynamicLayoutHelper.ReplaceRegionRepresentationHtml(html);
            return html;
        }

        /// <summary>
        /// Renders page to string recursively - going deep to master pages and layouts.
        /// </summary>
        /// <param name="controller">The controller.</param>
        /// <param name="currentModel">The model.</param>
        /// <param name="pageModel">The page model.</param>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <returns></returns>
        private static string RenderRecursively(CmsControllerBase controller, RenderPageViewModel currentModel, RenderPageViewModel pageModel, HtmlHelper htmlHelper)
        {
            if (currentModel.MasterPage != null)
            {
                var renderedMaster = RenderRecursively(controller, currentModel.MasterPage, pageModel, htmlHelper);

                foreach (var region in currentModel.Regions)
                {
                    var contentsBuilder = new StringBuilder();
                    var projections = currentModel.Contents.Where(c => c.RegionId == region.RegionId).OrderBy(c => c.Order).ToList();

                    using (new LayoutRegionWrapper(contentsBuilder, region, currentModel.AreRegionsEditable))
                    {
                        foreach (var projection in projections)
                        {
                            // Add Html
                            using (new RegionContentWrapper(contentsBuilder, projection, currentModel.CanManageContent && currentModel.AreRegionsEditable))
                            {
                                var content = projection.GetHtml(htmlHelper);
                                contentsBuilder.Append(content);
                            }
                        }
                    }

                    var html = contentsBuilder.ToString();
                    renderedMaster = DynamicLayoutHelper.ReplaceRegionHtml(region.RegionIdentifier, renderedMaster, html);
                }
                
                return renderedMaster;
            }

            var newModel = currentModel.Clone();
            newModel.Id = pageModel.Id;
            newModel.PageUrl = pageModel.PageUrl;
            newModel.Title = pageModel.Title;
            newModel.MetaTitle = pageModel.MetaTitle;
            newModel.RenderingPage = pageModel;
            newModel.Metadata = pageModel.Metadata;

            PopulateCollections(newModel, pageModel);

            var renderedView = RenderViewToString(controller, "~/Areas/bcms-Root/Views/Cms/Index.cshtml", newModel);
            return renderedView;
        }

        /// <summary>
        /// Populates the collections.
        /// </summary>
        /// <param name="destination">The destination.</param>
        /// <param name="source">The source.</param>
        private static void PopulateCollections(RenderPageViewModel destination, RenderPageViewModel source)
        {
            if (source.MasterPage != null)
            {
                PopulateCollections(destination, source.MasterPage);
            }

            if (source.JavaScripts != null)
            {
                if (destination.JavaScripts == null)
                {
                    destination.JavaScripts = new List<IJavaScriptAccessor>();
                }
                foreach (var js in source.JavaScripts)
                {
                    if (!destination.JavaScripts.Contains(js))
                    {
                        destination.JavaScripts.Add(js);
                    }
                }
            }

            if (source.Stylesheets != null)
            {
                if (destination.Stylesheets == null)
                {
                    destination.Stylesheets = new List<IStylesheetAccessor>();
                }
                foreach (var css in source.Stylesheets)
                {
                    if (!destination.Stylesheets.Contains(css))
                    {
                        destination.Stylesheets.Add(css);
                    }
                }
            }
        }

        /// <summary>
        /// Gets fake HTML helper.
        /// </summary>
        /// <param name="controller">The controller.</param>
        /// <returns>Fake HTML helper</returns>
        private static HtmlHelper GetHtmlHelper(this Controller controller)
        {
            var viewContext = new ViewContext(controller.ControllerContext, new FakeView(), controller.ViewData, controller.TempData, TextWriter.Null);
            return new HtmlHelper(viewContext, new ViewPage());
        }

        /// <summary>
        /// Fake razor view
        /// </summary>
        private class FakeView : IView
        {
            public void Render(ViewContext viewContext, TextWriter writer)
            {
                throw new InvalidOperationException();
            }
        }
    }
}