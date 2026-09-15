#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ServerToolResultsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ServerToolResults>
    {
        /// <inheritdoc />
        public override global::Anthropic.ServerToolResults Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaWebFetchUrlSourceAll? all = default;
            if (discriminator?.Type == global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType.All)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchUrlSourceAll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchUrlSourceAll> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebFetchUrlSourceAll)}");
                all = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebFetchUrlSourceNone? none = default;
            if (discriminator?.Type == global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchUrlSourceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchUrlSourceNone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebFetchUrlSourceNone)}");
                none = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebFetchUrlSourceOnly? only = default;
            if (discriminator?.Type == global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType.Only)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchUrlSourceOnly), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchUrlSourceOnly> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebFetchUrlSourceOnly)}");
                only = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebFetchUrlSourceExcept? except = default;
            if (discriminator?.Type == global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType.Except)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchUrlSourceExcept), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchUrlSourceExcept> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebFetchUrlSourceExcept)}");
                except = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.ServerToolResults(
                discriminator?.Type,
                all,

                none,

                only,

                except
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ServerToolResults value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchUrlSourceAll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchUrlSourceAll?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchUrlSourceAll).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.All!, typeInfo);
            }
            else if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchUrlSourceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchUrlSourceNone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchUrlSourceNone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None!, typeInfo);
            }
            else if (value.IsOnly)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchUrlSourceOnly), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchUrlSourceOnly?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchUrlSourceOnly).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Only!, typeInfo);
            }
            else if (value.IsExcept)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchUrlSourceExcept), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchUrlSourceExcept?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchUrlSourceExcept).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Except!, typeInfo);
            }
        }
    }
}