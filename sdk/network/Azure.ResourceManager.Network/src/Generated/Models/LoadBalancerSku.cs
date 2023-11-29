// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> SKU of a load balancer. </summary>
    public partial class LoadBalancerSku
    {
        /// <summary> Initializes a new instance of <see cref="LoadBalancerSku"/>. </summary>
        public LoadBalancerSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LoadBalancerSku"/>. </summary>
        /// <param name="name"> Name of a load balancer SKU. </param>
        /// <param name="tier"> Tier of a load balancer SKU. </param>
        internal LoadBalancerSku(LoadBalancerSkuName? name, LoadBalancerSkuTier? tier)
        {
            Name = name;
            Tier = tier;
        }

        /// <summary> Name of a load balancer SKU. </summary>
        public LoadBalancerSkuName? Name { get; set; }
        /// <summary> Tier of a load balancer SKU. </summary>
        public LoadBalancerSkuTier? Tier { get; set; }
    }
}
