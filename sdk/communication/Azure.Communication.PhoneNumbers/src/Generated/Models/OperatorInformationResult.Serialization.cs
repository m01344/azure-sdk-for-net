// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    public partial class OperatorInformationResult
    {
        internal static OperatorInformationResult DeserializeOperatorInformationResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<OperatorInformation>> values = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OperatorInformation> array = new List<OperatorInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperatorInformation.DeserializeOperatorInformation(item));
                    }
                    values = array;
                    continue;
                }
            }
            return new OperatorInformationResult(Optional.ToList(values));
        }
    }
}
