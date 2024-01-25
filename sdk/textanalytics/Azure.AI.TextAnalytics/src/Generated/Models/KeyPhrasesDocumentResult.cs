// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The KeyPhrasesDocumentResult. </summary>
    internal partial class KeyPhrasesDocumentResult : DocumentResult
    {
        /// <summary> Initializes a new instance of <see cref="KeyPhrasesDocumentResult"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="keyPhrases"> A list of representative words or phrases. The number of key phrases returned is proportional to the number of words in the input document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/> or <paramref name="keyPhrases"/> is null. </exception>
        public KeyPhrasesDocumentResult(string id, IEnumerable<DocumentWarning> warnings, IEnumerable<string> keyPhrases) : base(id, warnings)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(warnings, nameof(warnings));
            Argument.AssertNotNull(keyPhrases, nameof(keyPhrases));

            KeyPhrases = keyPhrases.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="KeyPhrasesDocumentResult"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="keyPhrases"> A list of representative words or phrases. The number of key phrases returned is proportional to the number of words in the input document. </param>
        internal KeyPhrasesDocumentResult(string id, IList<DocumentWarning> warnings, TextDocumentStatistics? statistics, IList<string> keyPhrases) : base(id, warnings, statistics)
        {
            KeyPhrases = keyPhrases;
        }

        /// <summary> A list of representative words or phrases. The number of key phrases returned is proportional to the number of words in the input document. </summary>
        public IList<string> KeyPhrases { get; }
    }
}
