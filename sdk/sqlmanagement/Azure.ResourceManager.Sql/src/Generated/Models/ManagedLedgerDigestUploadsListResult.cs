// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of ledger digest upload settings. </summary>
    internal partial class ManagedLedgerDigestUploadsListResult
    {
        /// <summary> Initializes a new instance of <see cref="ManagedLedgerDigestUploadsListResult"/>. </summary>
        internal ManagedLedgerDigestUploadsListResult()
        {
            Value = new ChangeTrackingList<ManagedLedgerDigestUploadData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedLedgerDigestUploadsListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ManagedLedgerDigestUploadsListResult(IReadOnlyList<ManagedLedgerDigestUploadData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedLedgerDigestUploadData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
