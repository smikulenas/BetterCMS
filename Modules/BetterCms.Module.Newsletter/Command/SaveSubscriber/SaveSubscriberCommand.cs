﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SaveSubscriberCommand.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using BetterCms.Module.Newsletter.Services;
using BetterCms.Module.Newsletter.ViewModels;

using BetterCms.Module.Root.Mvc;

using BetterModules.Core.Web.Mvc.Commands;

namespace BetterCms.Module.Newsletter.Command.SaveSubscriber
{
    public class SaveSubscriberCommand : CommandBase, ICommand<SubscriberViewModel, SubscriberViewModel>
    {
        /// <summary>
        /// Gets or sets the subscriber service.
        /// </summary>
        /// <value>
        /// The subscriber service.
        /// </value>
        public ISubscriberService SubscriberService { get; set; }

        /// <summary>
        /// Executes the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public SubscriberViewModel Execute(SubscriberViewModel request)
        {
            var subscriber = SubscriberService.SaveSubscriber(request.Email, request.Id, request.Version, request.IgnoreUniqueSubscriberException);

            return new SubscriberViewModel
            {
                Id = subscriber.Id,
                Version = subscriber.Version,
                Email = subscriber.Email
            };
        }
    }
}