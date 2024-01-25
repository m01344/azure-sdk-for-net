// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> SingletonPartitionScheme. </summary>
    public partial class SingletonPartitionScheme : ManagedServicePartitionScheme
    {
        /// <summary> Initializes a new instance of <see cref="SingletonPartitionScheme"/>. </summary>
        public SingletonPartitionScheme()
        {
            PartitionScheme = PartitionScheme.Singleton;
        }

        /// <summary> Initializes a new instance of <see cref="SingletonPartitionScheme"/>. </summary>
        /// <param name="partitionScheme"> Specifies how the service is partitioned. </param>
        internal SingletonPartitionScheme(PartitionScheme partitionScheme) : base(partitionScheme)
        {
            PartitionScheme = partitionScheme;
        }
    }
}
