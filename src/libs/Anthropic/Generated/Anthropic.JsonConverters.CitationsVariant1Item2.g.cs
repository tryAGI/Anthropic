#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class CitationsVariant1Item2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.CitationsVariant1Item2>
    {
        /// <inheritdoc />
        public override global::Anthropic.CitationsVariant1Item2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaResponseCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation)
            {
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseCharLocationCitation>(ref reader, options);
            }
            global::Anthropic.BetaResponsePageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation)
            {
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponsePageLocationCitation>(ref reader, options);
            }
            global::Anthropic.BetaResponseContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation)
            {
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseContentBlockLocationCitation>(ref reader, options);
            }
            global::Anthropic.BetaResponseWebSearchResultLocationCitation? webSearchResultLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.WebSearchResultLocation)
            {
                webSearchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseWebSearchResultLocationCitation>(ref reader, options);
            }
            global::Anthropic.BetaResponseSearchResultLocationCitation? searchResultLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.SearchResultLocation)
            {
                searchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseSearchResultLocationCitation>(ref reader, options);
            }

            var __value = new global::Anthropic.CitationsVariant1Item2(
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
            global::Anthropic.CitationsVariant1Item2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCharLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CharLocation, typeof(global::Anthropic.BetaResponseCharLocationCitation), options);
            }
            else if (value.IsPageLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PageLocation, typeof(global::Anthropic.BetaResponsePageLocationCitation), options);
            }
            else if (value.IsContentBlockLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockLocation, typeof(global::Anthropic.BetaResponseContentBlockLocationCitation), options);
            }
            else if (value.IsWebSearchResultLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchResultLocation, typeof(global::Anthropic.BetaResponseWebSearchResultLocationCitation), options);
            }
            else if (value.IsSearchResultLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResultLocation, typeof(global::Anthropic.BetaResponseSearchResultLocationCitation), options);
            }
        }
    }
}