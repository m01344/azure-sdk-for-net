// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.RouterWorkerOfferAccepted event. </summary>
    public partial class AcsRouterWorkerOfferAcceptedEventData : AcsRouterWorkerEventData
    {
        /// <summary> Initializes a new instance of <see cref="AcsRouterWorkerOfferAcceptedEventData"/>. </summary>
        internal AcsRouterWorkerOfferAcceptedEventData()
        {
            WorkerLabels = new ChangeTrackingDictionary<string, string>();
            WorkerTags = new ChangeTrackingDictionary<string, string>();
            JobLabels = new ChangeTrackingDictionary<string, string>();
            JobTags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterWorkerOfferAcceptedEventData"/>. </summary>
        /// <param name="jobId"> Router Event Job ID. </param>
        /// <param name="channelReference"> Router Event Channel Reference. </param>
        /// <param name="channelId"> Router Event Channel ID. </param>
        /// <param name="workerId"> Router Worker events Worker Id. </param>
        /// <param name="queueId"> Router Worker Offer Accepted Queue Id. </param>
        /// <param name="offerId"> Router Worker Offer Accepted Offer Id. </param>
        /// <param name="assignmentId"> Router Worker Offer Accepted Assignment Id. </param>
        /// <param name="jobPriority"> Router Worker Offer Accepted Job Priority. </param>
        /// <param name="workerLabels"> Router Worker Offer Accepted Worker Labels. </param>
        /// <param name="workerTags"> Router Worker Offer Accepted Worker Tags. </param>
        /// <param name="jobLabels"> Router Worker Offer Accepted Job Labels. </param>
        /// <param name="jobTags"> Router Worker Offer Accepted Job Tags. </param>
        internal AcsRouterWorkerOfferAcceptedEventData(string jobId, string channelReference, string channelId, string workerId, string queueId, string offerId, string assignmentId, int? jobPriority, IReadOnlyDictionary<string, string> workerLabels, IReadOnlyDictionary<string, string> workerTags, IReadOnlyDictionary<string, string> jobLabels, IReadOnlyDictionary<string, string> jobTags) : base(jobId, channelReference, channelId, workerId)
        {
            QueueId = queueId;
            OfferId = offerId;
            AssignmentId = assignmentId;
            JobPriority = jobPriority;
            WorkerLabels = workerLabels;
            WorkerTags = workerTags;
            JobLabels = jobLabels;
            JobTags = jobTags;
        }

        /// <summary> Router Worker Offer Accepted Queue Id. </summary>
        public string QueueId { get; }
        /// <summary> Router Worker Offer Accepted Offer Id. </summary>
        public string OfferId { get; }
        /// <summary> Router Worker Offer Accepted Assignment Id. </summary>
        public string AssignmentId { get; }
        /// <summary> Router Worker Offer Accepted Job Priority. </summary>
        public int? JobPriority { get; }
        /// <summary> Router Worker Offer Accepted Worker Labels. </summary>
        public IReadOnlyDictionary<string, string> WorkerLabels { get; }
        /// <summary> Router Worker Offer Accepted Worker Tags. </summary>
        public IReadOnlyDictionary<string, string> WorkerTags { get; }
        /// <summary> Router Worker Offer Accepted Job Labels. </summary>
        public IReadOnlyDictionary<string, string> JobLabels { get; }
        /// <summary> Router Worker Offer Accepted Job Tags. </summary>
        public IReadOnlyDictionary<string, string> JobTags { get; }
    }
}
