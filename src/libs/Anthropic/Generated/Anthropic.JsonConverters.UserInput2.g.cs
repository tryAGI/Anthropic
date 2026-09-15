#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class UserInput2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.UserInput2>
    {
        /// <inheritdoc />
        public override global::Anthropic.UserInput2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.WebFetchUrlSourcesUserInputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.WebFetchUrlSourcesUserInputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.WebFetchUrlSourcesUserInputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.WebFetchUrlSourceAll? all = default;
            if (discriminator?.Type == global::Anthropic.WebFetchUrlSourcesUserInputDiscriminatorType.All)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.WebFetchUrlSourceAll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.WebFetchUrlSourceAll> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.WebFetchUrlSourceAll)}");
                all = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.WebFetchUrlSourceNone? none = default;
            if (discriminator?.Type == global::Anthropic.WebFetchUrlSourcesUserInputDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.WebFetchUrlSourceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.WebFetchUrlSourceNone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.WebFetchUrlSourceNone)}");
                none = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.UserInput2(
                discriminator?.Type,
                all,

                none
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.UserInput2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.WebFetchUrlSourceAll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.WebFetchUrlSourceAll?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.WebFetchUrlSourceAll).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.All!, typeInfo);
            }
            else if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.WebFetchUrlSourceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.WebFetchUrlSourceNone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.WebFetchUrlSourceNone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None!, typeInfo);
            }
        }
    }
}