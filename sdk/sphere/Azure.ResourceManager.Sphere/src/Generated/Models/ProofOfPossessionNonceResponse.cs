// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> Result of the action to generate a proof of possession nonce. </summary>
    public partial class ProofOfPossessionNonceResponse : SphereCertificateProperties
    {
        /// <summary> Initializes a new instance of <see cref="ProofOfPossessionNonceResponse"/>. </summary>
        internal ProofOfPossessionNonceResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProofOfPossessionNonceResponse"/>. </summary>
        /// <param name="certificate"> The certificate as a UTF-8 encoded base 64 string. </param>
        /// <param name="status"> The certificate status. </param>
        /// <param name="subject"> The certificate subject. </param>
        /// <param name="thumbprint"> The certificate thumbprint. </param>
        /// <param name="expiryUtc"> The certificate expiry date. </param>
        /// <param name="notBeforeUtc"> The certificate not before date. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        internal ProofOfPossessionNonceResponse(string certificate, SphereCertificateStatus? status, string subject, string thumbprint, DateTimeOffset? expiryUtc, DateTimeOffset? notBeforeUtc, SphereProvisioningState? provisioningState) : base(certificate, status, subject, thumbprint, expiryUtc, notBeforeUtc, provisioningState)
        {
        }
    }
}
