// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The DscNodeCountProperties. </summary>
    internal partial class DscNodeCountProperties
    {
        /// <summary> Initializes a new instance of <see cref="DscNodeCountProperties"/>. </summary>
        internal DscNodeCountProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DscNodeCountProperties"/>. </summary>
        /// <param name="nameCount"> Gets the count for the name. </param>
        internal DscNodeCountProperties(int? nameCount)
        {
            NameCount = nameCount;
        }

        /// <summary> Gets the count for the name. </summary>
        public int? NameCount { get; }
    }
}
