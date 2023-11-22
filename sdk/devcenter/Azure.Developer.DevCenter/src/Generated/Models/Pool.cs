// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> A pool of Dev Boxes. </summary>
    public partial class Pool
    {
        /// <summary> Initializes a new instance of Pool. </summary>
        /// <param name="location"> Azure region where Dev Boxes in the pool are located. </param>
        /// <param name="healthStatus">
        /// Overall health status of the Pool. Indicates whether or not the Pool is
        /// available to create Dev Boxes.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        internal Pool(string location, PoolHealthStatus healthStatus)
        {
            Argument.AssertNotNull(location, nameof(location));

            Location = location;
            HealthStatus = healthStatus;
        }

        /// <summary> Initializes a new instance of Pool. </summary>
        /// <param name="name"> Pool name. </param>
        /// <param name="location"> Azure region where Dev Boxes in the pool are located. </param>
        /// <param name="osType"> The operating system type of Dev Boxes in this pool. </param>
        /// <param name="hardwareProfile"> Hardware settings for the Dev Boxes created in this pool. </param>
        /// <param name="hibernateSupport"> Indicates whether hibernate is enabled/disabled or unknown. </param>
        /// <param name="storageProfile"> Storage settings for Dev Box created in this pool. </param>
        /// <param name="imageReference"> Image settings for Dev Boxes create in this pool. </param>
        /// <param name="localAdministrator">
        /// Indicates whether owners of Dev Boxes in this pool are local administrators on
        /// the Dev Boxes.
        /// </param>
        /// <param name="stopOnDisconnect"> Stop on disconnect configuration settings for Dev Boxes created in this pool. </param>
        /// <param name="healthStatus">
        /// Overall health status of the Pool. Indicates whether or not the Pool is
        /// available to create Dev Boxes.
        /// </param>
        internal Pool(string name, string location, OsType? osType, HardwareProfile hardwareProfile, HibernateSupport? hibernateSupport, StorageProfile storageProfile, ImageReference imageReference, LocalAdminStatus? localAdministrator, StopOnDisconnectConfiguration stopOnDisconnect, PoolHealthStatus healthStatus)
        {
            Name = name;
            Location = location;
            OsType = osType;
            HardwareProfile = hardwareProfile;
            HibernateSupport = hibernateSupport;
            StorageProfile = storageProfile;
            ImageReference = imageReference;
            LocalAdministrator = localAdministrator;
            StopOnDisconnect = stopOnDisconnect;
            HealthStatus = healthStatus;
        }

        /// <summary> Pool name. </summary>
        public string Name { get; }
        /// <summary> Azure region where Dev Boxes in the pool are located. </summary>
        public string Location { get; }
        /// <summary> The operating system type of Dev Boxes in this pool. </summary>
        public OsType? OsType { get; }
        /// <summary> Hardware settings for the Dev Boxes created in this pool. </summary>
        public HardwareProfile HardwareProfile { get; }
        /// <summary> Indicates whether hibernate is enabled/disabled or unknown. </summary>
        public HibernateSupport? HibernateSupport { get; }
        /// <summary> Storage settings for Dev Box created in this pool. </summary>
        public StorageProfile StorageProfile { get; }
        /// <summary> Image settings for Dev Boxes create in this pool. </summary>
        public ImageReference ImageReference { get; }
        /// <summary>
        /// Indicates whether owners of Dev Boxes in this pool are local administrators on
        /// the Dev Boxes.
        /// </summary>
        public LocalAdminStatus? LocalAdministrator { get; }
        /// <summary> Stop on disconnect configuration settings for Dev Boxes created in this pool. </summary>
        public StopOnDisconnectConfiguration StopOnDisconnect { get; }
        /// <summary>
        /// Overall health status of the Pool. Indicates whether or not the Pool is
        /// available to create Dev Boxes.
        /// </summary>
        public PoolHealthStatus HealthStatus { get; }
    }
}
