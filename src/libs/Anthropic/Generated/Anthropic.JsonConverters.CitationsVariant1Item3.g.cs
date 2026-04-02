#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class CitationsVariant1Item3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.CitationsVariant1Item3>
    {
        /// <inheritdoc />
        public override global::Anthropic.CitationsVariant1Item3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminator>(ref readerCopy, options);

            global::Anthropic.RequestCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation)
            {
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestCharLocationCitation>(ref reader, options);
            }
            global::Anthropic.RequestPageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation)
            {
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestPageLocationCitation>(ref reader, options);
            }
            global::Anthropic.RequestContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation)
            {
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestContentBlockLocationCitation>(ref reader, options);
            }
            global::Anthropic.RequestWebSearchResultLocationCitation? webSearchResultLocation = default;
            if (discriminator?.Type == global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminatorType.WebSearchResultLocation)
            {
                webSearchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestWebSearchResultLocationCitation>(ref reader, options);
            }
            global::Anthropic.RequestSearchResultLocationCitation? searchResultLocation = default;
            if (discriminator?.Type == global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminatorType.SearchResultLocation)
            {
                searchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestSearchResultLocationCitation>(ref reader, options);
            }

            var __value = new global::Anthropic.CitationsVariant1Item3(
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
            global::Anthropic.CitationsVariant1Item3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCharLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CharLocation, typeof(global::Anthropic.RequestCharLocationCitation), options);
            }
            else if (value.IsPageLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PageLocation, typeof(global::Anthropic.RequestPageLocationCitation), options);
            }
            else if (value.IsContentBlockLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockLocation, typeof(global::Anthropic.RequestContentBlockLocationCitation), options);
            }
            else if (value.IsWebSearchResultLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchResultLocation, typeof(global::Anthropic.RequestWebSearchResultLocationCitation), options);
            }
            else if (value.IsSearchResultLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResultLocation, typeof(global::Anthropic.RequestSearchResultLocationCitation), options);
            }
        }
    }
}