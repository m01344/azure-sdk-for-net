// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The SiteRecoveryVmEndpoint. </summary>
    public partial class SiteRecoveryVmEndpoint
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryVmEndpoint"/>. </summary>
        internal SiteRecoveryVmEndpoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryVmEndpoint"/>. </summary>
        /// <param name="endpointName"></param>
        /// <param name="privatePort"></param>
        /// <param name="publicPort"></param>
        /// <param name="protocol"></param>
        internal SiteRecoveryVmEndpoint(string endpointName, int? privatePort, int? publicPort, string protocol)
        {
            EndpointName = endpointName;
            PrivatePort = privatePort;
            PublicPort = publicPort;
            Protocol = protocol;
        }

        /// <summary> Gets the endpoint name. </summary>
        public string EndpointName { get; }
        /// <summary> Gets the private port. </summary>
        public int? PrivatePort { get; }
        /// <summary> Gets the public port. </summary>
        public int? PublicPort { get; }
        /// <summary> Gets the protocol. </summary>
        public string Protocol { get; }
    }
}
