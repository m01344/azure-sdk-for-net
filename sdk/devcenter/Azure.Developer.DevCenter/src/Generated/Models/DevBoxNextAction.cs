// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> Details about the next run of an action. </summary>
    public partial class DevBoxNextAction
    {
        /// <summary> Initializes a new instance of DevBoxNextAction. </summary>
        /// <param name="scheduledTime"> The time the action will be triggered (UTC). </param>
        internal DevBoxNextAction(DateTimeOffset scheduledTime)
        {
            ScheduledTime = scheduledTime;
        }

        /// <summary> The time the action will be triggered (UTC). </summary>
        public DateTimeOffset ScheduledTime { get; }
    }
}
