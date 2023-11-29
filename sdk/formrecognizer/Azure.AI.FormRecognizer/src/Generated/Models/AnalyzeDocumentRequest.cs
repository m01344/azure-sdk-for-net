// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Document analysis parameters. </summary>
    internal partial class AnalyzeDocumentRequest
    {
        /// <summary> Initializes a new instance of <see cref="AnalyzeDocumentRequest"/>. </summary>
        public AnalyzeDocumentRequest()
        {
        }

        /// <summary> Document URL to analyze.  Either urlSource or base64Source must be specified. </summary>
        public Uri UrlSource { get; set; }
        /// <summary> Base64 encoding of the document to analyze.  Either urlSource or base64Source must be specified. </summary>
        public byte[] Base64Source { get; set; }
    }
}
