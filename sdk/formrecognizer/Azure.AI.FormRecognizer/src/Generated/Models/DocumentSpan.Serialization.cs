// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial struct DocumentSpan
    {
        internal static DocumentSpan DeserializeDocumentSpan(JsonElement element)
        {
            int offset = default;
            int length = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
            }
            return new DocumentSpan(offset, length);
        }
    }
}
