// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    /// <summary> A wrapper for a list of USProgramBrief entities. </summary>
    internal partial class USProgramBriefs
    {
        /// <summary> Initializes a new instance of <see cref="USProgramBriefs"/>. </summary>
        internal USProgramBriefs()
        {
            ProgramBriefs = new ChangeTrackingList<USProgramBrief>();
        }

        /// <summary> Initializes a new instance of <see cref="USProgramBriefs"/>. </summary>
        /// <param name="programBriefs"> List of Program Briefs. </param>
        /// <param name="nextLink"> Represents the URL link to the next page. </param>
        internal USProgramBriefs(IReadOnlyList<USProgramBrief> programBriefs, string nextLink)
        {
            ProgramBriefs = programBriefs;
            NextLink = nextLink;
        }

        /// <summary> List of Program Briefs. </summary>
        public IReadOnlyList<USProgramBrief> ProgramBriefs { get; }
        /// <summary> Represents the URL link to the next page. </summary>
        public string NextLink { get; }
    }
}
