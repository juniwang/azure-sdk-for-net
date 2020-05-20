// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resource.Models
{
    public partial class HttpMessage
    {
        internal static HttpMessage DeserializeHttpMessage(JsonElement element)
        {
            object content = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    content = property.Value.GetObject();
                    continue;
                }
            }
            return new HttpMessage(content);
        }
    }
}