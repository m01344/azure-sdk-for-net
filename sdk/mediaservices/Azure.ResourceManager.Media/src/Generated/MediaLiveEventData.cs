// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing the MediaLiveEvent data model.
    /// The live event.
    /// </summary>
    public partial class MediaLiveEventData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="MediaLiveEventData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MediaLiveEventData(AzureLocation location) : base(location)
        {
            Transcriptions = new ChangeTrackingList<LiveEventTranscription>();
            StreamOptions = new ChangeTrackingList<StreamOptionsFlag>();
        }

        /// <summary> Initializes a new instance of <see cref="MediaLiveEventData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="description"> A description for the live event. </param>
        /// <param name="input"> Live event input settings. It defines how the live event receives input from a contribution encoder. </param>
        /// <param name="preview"> Live event preview settings. Preview allows live event producers to preview the live streaming content without creating any live output. </param>
        /// <param name="encoding"> Encoding settings for the live event. It configures whether a live encoder is used for the live event and settings for the live encoder if it is used. </param>
        /// <param name="transcriptions"> Live transcription settings for the live event. See https://go.microsoft.com/fwlink/?linkid=2133742 for more information about the live transcription feature. </param>
        /// <param name="provisioningState"> The provisioning state of the live event. </param>
        /// <param name="resourceState"> The resource state of the live event. See https://go.microsoft.com/fwlink/?linkid=2139012 for more information. </param>
        /// <param name="crossSiteAccessPolicies"> Live event cross site access policies. </param>
        /// <param name="useStaticHostname"> Specifies whether a static hostname would be assigned to the live event preview and ingest endpoints. This value can only be updated if the live event is in Standby state. </param>
        /// <param name="hostnamePrefix"> When useStaticHostname is set to true, the hostnamePrefix specifies the first part of the hostname assigned to the live event preview and ingest endpoints. The final hostname would be a combination of this prefix, the media service account name and a short code for the Azure Media Services data center. </param>
        /// <param name="streamOptions"> The options to use for the LiveEvent. This value is specified at creation time and cannot be updated. The valid values for the array entry values are 'Default' and 'LowLatency'. </param>
        /// <param name="createdOn"> The creation time for the live event. </param>
        /// <param name="lastModifiedOn"> The last modified time of the live event. </param>
        internal MediaLiveEventData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string description, LiveEventInput input, LiveEventPreview preview, LiveEventEncoding encoding, IList<LiveEventTranscription> transcriptions, string provisioningState, LiveEventResourceState? resourceState, CrossSiteAccessPolicies crossSiteAccessPolicies, bool? useStaticHostname, string hostnamePrefix, IList<StreamOptionsFlag> streamOptions, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn) : base(id, name, resourceType, systemData, tags, location)
        {
            Description = description;
            Input = input;
            Preview = preview;
            Encoding = encoding;
            Transcriptions = transcriptions;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            CrossSiteAccessPolicies = crossSiteAccessPolicies;
            UseStaticHostname = useStaticHostname;
            HostnamePrefix = hostnamePrefix;
            StreamOptions = streamOptions;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
        }

        /// <summary> A description for the live event. </summary>
        public string Description { get; set; }
        /// <summary> Live event input settings. It defines how the live event receives input from a contribution encoder. </summary>
        public LiveEventInput Input { get; set; }
        /// <summary> Live event preview settings. Preview allows live event producers to preview the live streaming content without creating any live output. </summary>
        public LiveEventPreview Preview { get; set; }
        /// <summary> Encoding settings for the live event. It configures whether a live encoder is used for the live event and settings for the live encoder if it is used. </summary>
        public LiveEventEncoding Encoding { get; set; }
        /// <summary> Live transcription settings for the live event. See https://go.microsoft.com/fwlink/?linkid=2133742 for more information about the live transcription feature. </summary>
        public IList<LiveEventTranscription> Transcriptions { get; }
        /// <summary> The provisioning state of the live event. </summary>
        public string ProvisioningState { get; }
        /// <summary> The resource state of the live event. See https://go.microsoft.com/fwlink/?linkid=2139012 for more information. </summary>
        public LiveEventResourceState? ResourceState { get; }
        /// <summary> Live event cross site access policies. </summary>
        public CrossSiteAccessPolicies CrossSiteAccessPolicies { get; set; }
        /// <summary> Specifies whether a static hostname would be assigned to the live event preview and ingest endpoints. This value can only be updated if the live event is in Standby state. </summary>
        public bool? UseStaticHostname { get; set; }
        /// <summary> When useStaticHostname is set to true, the hostnamePrefix specifies the first part of the hostname assigned to the live event preview and ingest endpoints. The final hostname would be a combination of this prefix, the media service account name and a short code for the Azure Media Services data center. </summary>
        public string HostnamePrefix { get; set; }
        /// <summary> The options to use for the LiveEvent. This value is specified at creation time and cannot be updated. The valid values for the array entry values are 'Default' and 'LowLatency'. </summary>
        public IList<StreamOptionsFlag> StreamOptions { get; }
        /// <summary> The creation time for the live event. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The last modified time of the live event. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
    }
}
