// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the AppServiceCertificateOrder data model.
    /// SSL certificate purchase order.
    /// </summary>
    public partial class AppServiceCertificateOrderData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AppServiceCertificateOrderData"/>. </summary>
        /// <param name="location"> The location. </param>
        public AppServiceCertificateOrderData(AzureLocation location) : base(location)
        {
            Certificates = new ChangeTrackingDictionary<string, AppServiceCertificateProperties>();
            AppServiceCertificateNotRenewableReasons = new ChangeTrackingList<AppServiceCertificateNotRenewableReason>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceCertificateOrderData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="certificates"> State of the Key Vault secret. </param>
        /// <param name="distinguishedName"> Certificate distinguished name. </param>
        /// <param name="domainVerificationToken"> Domain verification token. </param>
        /// <param name="validityInYears"> Duration in years (must be 1). </param>
        /// <param name="keySize"> Certificate key size. </param>
        /// <param name="productType"> Certificate product type. </param>
        /// <param name="isAutoRenew"> &lt;code&gt;true&lt;/code&gt; if the certificate should be automatically renewed when it expires; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="provisioningState"> Status of certificate order. </param>
        /// <param name="status"> Current order status. </param>
        /// <param name="signedCertificate"> Signed certificate. </param>
        /// <param name="csr"> Last CSR that was created for this order. </param>
        /// <param name="intermediate"> Intermediate certificate. </param>
        /// <param name="root"> Root certificate. </param>
        /// <param name="serialNumber"> Current serial number of the certificate. </param>
        /// <param name="lastCertificateIssuedOn"> Certificate last issuance time. </param>
        /// <param name="expireOn"> Certificate expiration time. </param>
        /// <param name="isPrivateKeyExternal"> &lt;code&gt;true&lt;/code&gt; if private key is external; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="appServiceCertificateNotRenewableReasons"> Reasons why App Service Certificate is not renewable at the current moment. </param>
        /// <param name="nextAutoRenewTimeStamp"> Time stamp when the certificate would be auto renewed next. </param>
        /// <param name="contact"> Contact info. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal AppServiceCertificateOrderData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IDictionary<string, AppServiceCertificateProperties> certificates, string distinguishedName, string domainVerificationToken, int? validityInYears, int? keySize, CertificateProductType? productType, bool? isAutoRenew, ProvisioningState? provisioningState, CertificateOrderStatus? status, AppServiceCertificateDetails signedCertificate, string csr, AppServiceCertificateDetails intermediate, AppServiceCertificateDetails root, string serialNumber, DateTimeOffset? lastCertificateIssuedOn, DateTimeOffset? expireOn, bool? isPrivateKeyExternal, IReadOnlyList<AppServiceCertificateNotRenewableReason> appServiceCertificateNotRenewableReasons, DateTimeOffset? nextAutoRenewTimeStamp, CertificateOrderContact contact, string kind) : base(id, name, resourceType, systemData, tags, location)
        {
            Certificates = certificates;
            DistinguishedName = distinguishedName;
            DomainVerificationToken = domainVerificationToken;
            ValidityInYears = validityInYears;
            KeySize = keySize;
            ProductType = productType;
            IsAutoRenew = isAutoRenew;
            ProvisioningState = provisioningState;
            Status = status;
            SignedCertificate = signedCertificate;
            Csr = csr;
            Intermediate = intermediate;
            Root = root;
            SerialNumber = serialNumber;
            LastCertificateIssuedOn = lastCertificateIssuedOn;
            ExpireOn = expireOn;
            IsPrivateKeyExternal = isPrivateKeyExternal;
            AppServiceCertificateNotRenewableReasons = appServiceCertificateNotRenewableReasons;
            NextAutoRenewTimeStamp = nextAutoRenewTimeStamp;
            Contact = contact;
            Kind = kind;
        }

        /// <summary> State of the Key Vault secret. </summary>
        public IDictionary<string, AppServiceCertificateProperties> Certificates { get; }
        /// <summary> Certificate distinguished name. </summary>
        public string DistinguishedName { get; set; }
        /// <summary> Domain verification token. </summary>
        public string DomainVerificationToken { get; }
        /// <summary> Duration in years (must be 1). </summary>
        public int? ValidityInYears { get; set; }
        /// <summary> Certificate key size. </summary>
        public int? KeySize { get; set; }
        /// <summary> Certificate product type. </summary>
        public CertificateProductType? ProductType { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the certificate should be automatically renewed when it expires; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsAutoRenew { get; set; }
        /// <summary> Status of certificate order. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Current order status. </summary>
        public CertificateOrderStatus? Status { get; }
        /// <summary> Signed certificate. </summary>
        public AppServiceCertificateDetails SignedCertificate { get; }
        /// <summary> Last CSR that was created for this order. </summary>
        public string Csr { get; set; }
        /// <summary> Intermediate certificate. </summary>
        public AppServiceCertificateDetails Intermediate { get; }
        /// <summary> Root certificate. </summary>
        public AppServiceCertificateDetails Root { get; }
        /// <summary> Current serial number of the certificate. </summary>
        public string SerialNumber { get; }
        /// <summary> Certificate last issuance time. </summary>
        public DateTimeOffset? LastCertificateIssuedOn { get; }
        /// <summary> Certificate expiration time. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if private key is external; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsPrivateKeyExternal { get; }
        /// <summary> Reasons why App Service Certificate is not renewable at the current moment. </summary>
        public IReadOnlyList<AppServiceCertificateNotRenewableReason> AppServiceCertificateNotRenewableReasons { get; }
        /// <summary> Time stamp when the certificate would be auto renewed next. </summary>
        public DateTimeOffset? NextAutoRenewTimeStamp { get; }
        /// <summary> Contact info. </summary>
        public CertificateOrderContact Contact { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
