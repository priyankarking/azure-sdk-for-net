// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class SasCredential : IUtf8JsonSerializable, IJsonModel<SasCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SasCredential>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SasCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SasCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SasCredential)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SasUri))
            {
                if (SasUri != null)
                {
                    writer.WritePropertyName("sasUri"u8);
                    writer.WriteStringValue(SasUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("sasUri");
                }
            }
            writer.WritePropertyName("credentialType"u8);
            writer.WriteStringValue(CredentialType.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SasCredential IJsonModel<SasCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SasCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SasCredential)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSasCredential(document.RootElement, options);
        }

        internal static SasCredential DeserializeSasCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri sasUri = default;
            DataReferenceCredentialType credentialType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sasUri = null;
                        continue;
                    }
                    sasUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentialType"u8))
                {
                    credentialType = new DataReferenceCredentialType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SasCredential(credentialType, serializedAdditionalRawData, sasUri);
        }

        BinaryData IPersistableModel<SasCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SasCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SasCredential)} does not support writing '{options.Format}' format.");
            }
        }

        SasCredential IPersistableModel<SasCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SasCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSasCredential(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SasCredential)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SasCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
