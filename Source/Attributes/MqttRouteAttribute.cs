﻿// Copyright (c) .NET Foundation. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt
// in the project root for license information.

// Modifications Copyright (c) Atlas Lift Tech Inc. All rights reserved.

using System;

namespace MQTTnet.AspNetCore.Routing
{
    /// <summary>
    /// Specifies an attribute route on a controller.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class MqttRouteAttribute : Attribute
    {
        /// <summary>
        /// Creates a new <see cref="RouteAttribute"/> with the given route template.
        /// </summary>
        /// <param name="template">The route template. May not be null.</param>
        public MqttRouteAttribute(string template)
        {
            Template = template ?? throw new ArgumentNullException(nameof(template));
        }
        /// <summary>
        /// Creates a new <see cref="RouteAttribute"/> default route template for controller.
        ///
        /// </summary>
        public MqttRouteAttribute():this("/")
        {

        }
        
        /// <summary>
        /// Gets the route template.
        /// </summary>
        public string Template { get; }

        /// <inheritdoc/>
        public string Name { get; set; }
    }
}