// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The roll up count summary of reservations in each state. </summary>
    internal partial class ReservationSummary
    {
        /// <summary> Initializes a new instance of <see cref="ReservationSummary"/>. </summary>
        internal ReservationSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReservationSummary"/>. </summary>
        /// <param name="succeededCount"> The number of reservation in Succeeded state. </param>
        /// <param name="failedCount"> The number of reservation in Failed state. </param>
        /// <param name="expiringCount"> The number of reservation in Expiring state. </param>
        /// <param name="expiredCount"> The number of reservation in Expired state. </param>
        /// <param name="pendingCount"> The number of reservation in Pending state. </param>
        /// <param name="cancelledCount"> The number of reservation in Cancelled state. </param>
        /// <param name="processingCount"> The number of reservation in Processing state. </param>
        /// <param name="warningCount"> The number of reservation in Warning state. </param>
        /// <param name="noBenefitCount"> The number of reservation in NoBenefit state. </param>
        internal ReservationSummary(float? succeededCount, float? failedCount, float? expiringCount, float? expiredCount, float? pendingCount, float? cancelledCount, float? processingCount, float? warningCount, float? noBenefitCount)
        {
            SucceededCount = succeededCount;
            FailedCount = failedCount;
            ExpiringCount = expiringCount;
            ExpiredCount = expiredCount;
            PendingCount = pendingCount;
            CancelledCount = cancelledCount;
            ProcessingCount = processingCount;
            WarningCount = warningCount;
            NoBenefitCount = noBenefitCount;
        }

        /// <summary> The number of reservation in Succeeded state. </summary>
        public float? SucceededCount { get; }
        /// <summary> The number of reservation in Failed state. </summary>
        public float? FailedCount { get; }
        /// <summary> The number of reservation in Expiring state. </summary>
        public float? ExpiringCount { get; }
        /// <summary> The number of reservation in Expired state. </summary>
        public float? ExpiredCount { get; }
        /// <summary> The number of reservation in Pending state. </summary>
        public float? PendingCount { get; }
        /// <summary> The number of reservation in Cancelled state. </summary>
        public float? CancelledCount { get; }
        /// <summary> The number of reservation in Processing state. </summary>
        public float? ProcessingCount { get; }
        /// <summary> The number of reservation in Warning state. </summary>
        public float? WarningCount { get; }
        /// <summary> The number of reservation in NoBenefit state. </summary>
        public float? NoBenefitCount { get; }
    }
}
