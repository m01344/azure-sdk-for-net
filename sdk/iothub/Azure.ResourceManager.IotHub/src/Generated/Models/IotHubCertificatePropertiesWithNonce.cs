// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The description of an X509 CA Certificate including the challenge nonce issued for the Proof-Of-Possession flow. </summary>
    public partial class IotHubCertificatePropertiesWithNonce
    {
        /// <summary> Initializes a new instance of <see cref="IotHubCertificatePropertiesWithNonce"/>. </summary>
        internal IotHubCertificatePropertiesWithNonce()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IotHubCertificatePropertiesWithNonce"/>. </summary>
        /// <param name="subject"> The certificate's subject name. </param>
        /// <param name="expireOn"> The certificate's expiration date and time. </param>
        /// <param name="thumbprintString"> The certificate's thumbprint. </param>
        /// <param name="isVerified"> Determines whether certificate has been verified. </param>
        /// <param name="createdOn"> The certificate's create date and time. </param>
        /// <param name="updatedOn"> The certificate's last update date and time. </param>
        /// <param name="verificationCode"> The certificate's verification code that will be used for proof of possession. </param>
        /// <param name="certificate"> The certificate content. </param>
        internal IotHubCertificatePropertiesWithNonce(string subject, DateTimeOffset? expireOn, string thumbprintString, bool? isVerified, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string verificationCode, BinaryData certificate)
        {
            Subject = subject;
            ExpireOn = expireOn;
            ThumbprintString = thumbprintString;
            IsVerified = isVerified;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            VerificationCode = verificationCode;
            Certificate = certificate;
        }

        /// <summary> The certificate's subject name. </summary>
        public string Subject { get; }
        /// <summary> The certificate's expiration date and time. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> The certificate's thumbprint. </summary>
        public string ThumbprintString { get; }
        /// <summary> Determines whether certificate has been verified. </summary>
        public bool? IsVerified { get; }
        /// <summary> The certificate's create date and time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The certificate's last update date and time. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> The certificate's verification code that will be used for proof of possession. </summary>
        public string VerificationCode { get; }
        /// <summary>
        /// The certificate content
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Certificate { get; }
    }
}
