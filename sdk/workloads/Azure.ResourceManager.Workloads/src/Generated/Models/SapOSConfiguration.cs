// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary>
    /// Defines the OS configuration.
    /// Please note <see cref="SapOSConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SapLinuxConfiguration"/> and <see cref="SapWindowsConfiguration"/>.
    /// </summary>
    public abstract partial class SapOSConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="SapOSConfiguration"/>. </summary>
        protected SapOSConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SapOSConfiguration"/>. </summary>
        /// <param name="osType"> The OS Type. </param>
        internal SapOSConfiguration(SapOSType osType)
        {
            OSType = osType;
        }

        /// <summary> The OS Type. </summary>
        internal SapOSType OSType { get; set; }
    }
}
