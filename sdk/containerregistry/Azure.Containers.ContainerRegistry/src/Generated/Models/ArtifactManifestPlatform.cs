// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The artifact's platform, consisting of operating system and architecture. </summary>
    public partial class ArtifactManifestPlatform
    {
        /// <summary> Initializes a new instance of <see cref="ArtifactManifestPlatform"/>. </summary>
        /// <param name="digest"> Manifest digest. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="digest"/> is null. </exception>
        internal ArtifactManifestPlatform(string digest)
        {
            Argument.AssertNotNull(digest, nameof(digest));

            Digest = digest;
        }

        /// <summary> Initializes a new instance of <see cref="ArtifactManifestPlatform"/>. </summary>
        /// <param name="digest"> Manifest digest. </param>
        /// <param name="architecture"> CPU architecture. </param>
        /// <param name="operatingSystem"> Operating system. </param>
        internal ArtifactManifestPlatform(string digest, ArtifactArchitecture? architecture, ArtifactOperatingSystem? operatingSystem)
        {
            Digest = digest;
            Architecture = architecture;
            OperatingSystem = operatingSystem;
        }

        /// <summary> Manifest digest. </summary>
        public string Digest { get; }
        /// <summary> CPU architecture. </summary>
        public ArtifactArchitecture? Architecture { get; }
        /// <summary> Operating system. </summary>
        public ArtifactOperatingSystem? OperatingSystem { get; }
    }
}
