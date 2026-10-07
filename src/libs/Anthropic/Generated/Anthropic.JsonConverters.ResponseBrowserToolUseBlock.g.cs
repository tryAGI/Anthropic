#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ResponseBrowserToolUseBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ResponseBrowserToolUseBlock>
    {
        /// <inheritdoc />
        public override global::Anthropic.ResponseBrowserToolUseBlock Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Anthropic.ResponseBrowserToolUseBlockUnion? union = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserToolUseBlockUnion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserToolUseBlockUnion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserToolUseBlockUnion).Name}");
                union = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Anthropic.ResponseBrowserToolUseBlock(
                union
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ResponseBrowserToolUseBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsUnion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserToolUseBlockUnion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserToolUseBlockUnion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserToolUseBlockUnion).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickUnion(), typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}