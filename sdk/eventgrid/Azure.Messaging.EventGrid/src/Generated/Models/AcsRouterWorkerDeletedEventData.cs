// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.RouterWorkerDeleted event. </summary>
    public partial class AcsRouterWorkerDeletedEventData : AcsRouterWorkerEventData
    {
        /// <summary> Initializes a new instance of <see cref="AcsRouterWorkerDeletedEventData"/>. </summary>
        internal AcsRouterWorkerDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterWorkerDeletedEventData"/>. </summary>
        /// <param name="jobId"> Router Event Job ID. </param>
        /// <param name="channelReference"> Router Event Channel Reference. </param>
        /// <param name="channelId"> Router Event Channel ID. </param>
        /// <param name="workerId"> Router Worker events Worker Id. </param>
        internal AcsRouterWorkerDeletedEventData(string jobId, string channelReference, string channelId, string workerId) : base(jobId, channelReference, channelId, workerId)
        {
        }
    }
}
