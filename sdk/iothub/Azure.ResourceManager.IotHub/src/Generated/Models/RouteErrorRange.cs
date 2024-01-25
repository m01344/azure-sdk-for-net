// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Range of route errors. </summary>
    public partial class RouteErrorRange
    {
        /// <summary> Initializes a new instance of <see cref="RouteErrorRange"/>. </summary>
        internal RouteErrorRange()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RouteErrorRange"/>. </summary>
        /// <param name="start"> Start where the route error happened. </param>
        /// <param name="end"> End where the route error happened. </param>
        internal RouteErrorRange(RouteErrorPosition start, RouteErrorPosition end)
        {
            Start = start;
            End = end;
        }

        /// <summary> Start where the route error happened. </summary>
        public RouteErrorPosition Start { get; }
        /// <summary> End where the route error happened. </summary>
        public RouteErrorPosition End { get; }
    }
}
