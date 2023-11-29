// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Network Status in the Location. </summary>
    public partial class NetworkStatusContractWithLocation
    {
        /// <summary> Initializes a new instance of <see cref="NetworkStatusContractWithLocation"/>. </summary>
        internal NetworkStatusContractWithLocation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkStatusContractWithLocation"/>. </summary>
        /// <param name="location"> Location of service. </param>
        /// <param name="networkStatus"> Network status in Location. </param>
        internal NetworkStatusContractWithLocation(AzureLocation? location, NetworkStatusContract networkStatus)
        {
            Location = location;
            NetworkStatus = networkStatus;
        }

        /// <summary> Location of service. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Network status in Location. </summary>
        public NetworkStatusContract NetworkStatus { get; }
    }
}
