// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Factory's git repo information. </summary>
    public partial class FactoryRepoContent
    {
        /// <summary> Initializes a new instance of <see cref="FactoryRepoContent"/>. </summary>
        public FactoryRepoContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FactoryRepoContent"/>. </summary>
        /// <param name="factoryResourceId"> The factory resource id. </param>
        /// <param name="repoConfiguration">
        /// Git repo information of the factory.
        /// Please note <see cref="FactoryRepoConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactoryGitHubConfiguration"/> and <see cref="FactoryVstsConfiguration"/>.
        /// </param>
        internal FactoryRepoContent(ResourceIdentifier factoryResourceId, FactoryRepoConfiguration repoConfiguration)
        {
            FactoryResourceId = factoryResourceId;
            RepoConfiguration = repoConfiguration;
        }

        /// <summary> The factory resource id. </summary>
        public ResourceIdentifier FactoryResourceId { get; set; }
        /// <summary>
        /// Git repo information of the factory.
        /// Please note <see cref="FactoryRepoConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactoryGitHubConfiguration"/> and <see cref="FactoryVstsConfiguration"/>.
        /// </summary>
        public FactoryRepoConfiguration RepoConfiguration { get; set; }
    }
}
