﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NewsletterEvents.cs" company="Devbridge Group LLC">
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
using BetterCms.Module.Newsletter.Models;

using BetterModules.Events;

// ReSharper disable CheckNamespace
namespace BetterCms.Events
// ReSharper restore CheckNamespace
{
    /// <summary>
    /// Attachable newsletter events container
    /// </summary>
    public class NewsletterEvents : EventsBase<NewsletterEvents>
    {
        /// <summary>
        /// Occurs when a subscriber is created.
        /// </summary>
        public event DefaultEventHandler<SingleItemEventArgs<Subscriber>> SubscriberCreated;

        /// <summary>
        /// Occurs when a subscriber is updated.
        /// </summary>
        public event DefaultEventHandler<SingleItemEventArgs<Subscriber>> SubscriberUpdated;

        /// <summary>
        /// Occurs when a subscriber is deleted.
        /// </summary>
        public event DefaultEventHandler<SingleItemEventArgs<Subscriber>> SubscriberDeleted;

        /// <summary>
        /// Called when subscriber is created.
        /// </summary>
        /// <param name="subscriber">The subscriber.</param>
        public void OnSubscriberCreated(Subscriber subscriber)
        {
            if (SubscriberCreated != null)
            {
                SubscriberCreated(new SingleItemEventArgs<Subscriber>(subscriber));
            }
        }
        
        /// <summary>
        /// Called when subscriber is updates.
        /// </summary>
        /// <param name="subscriber">The subscriber.</param>
        public void OnSubscriberUpdated(Subscriber subscriber)
        {
            if (SubscriberUpdated != null)
            {
                SubscriberUpdated(new SingleItemEventArgs<Subscriber>(subscriber));
            }
        }

        /// <summary>
        /// Called when subscriber is deleted.
        /// </summary>
        /// <param name="subscriber">The subscriber.</param>
        public void OnSubscriberDeleted(Subscriber subscriber)
        {
            if (SubscriberDeleted != null)
            {
                SubscriberDeleted(new SingleItemEventArgs<Subscriber>(subscriber));
            }
        }
    }
}
