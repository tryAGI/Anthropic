#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class CitationsVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.CitationsVariant1Item>
    {
        /// <inheritdoc />
        public override global::Anthropic.CitationsVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaRequestCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation)
            {
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestCharLocationCitation>(ref reader, options);
            }
            global::Anthropic.BetaRequestPageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation)
            {
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestPageLocationCitation>(ref reader, options);
            }
            global::Anthropic.BetaRequestContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation)
            {
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestContentBlockLocationCitation>(ref reader, options);
            }
            global::Anthropic.BetaRequestWebSearchResultLocationCitation? webSearchResultLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.WebSearchResultLocation)
            {
                webSearchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestWebSearchResultLocationCitation>(ref reader, options);
            }
            global::Anthropic.BetaRequestSearchResultLocationCitation? searchResultLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.SearchResultLocation)
            {
                searchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestSearchResultLocationCitation>(ref reader, options);
            }

            var __value = new global::Anthropic.CitationsVariant1Item(
                discriminator?.Type,
                charLocation,

                pageLocation,

                contentBlockLocation,

                webSearchResultLocation,

                searchResultLocation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.CitationsVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCharLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CharLocation, typeof(global::Anthropic.BetaRequestCharLocationCitation), options);
            }
            else if (value.IsPageLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PageLocation, typeof(global::Anthropic.BetaRequestPageLocationCitation), options);
            }
            else if (value.IsContentBlockLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockLocation, typeof(global::Anthropic.BetaRequestContentBlockLocationCitation), options);
            }
            else if (value.IsWebSearchResultLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchResultLocation, typeof(global::Anthropic.BetaRequestWebSearchResultLocationCitation), options);
            }
            else if (value.IsSearchResultLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResultLocation, typeof(global::Anthropic.BetaRequestSearchResultLocationCitation), options);
            }
        }
    }
}