#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Caller7JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Caller7>
    {
        /// <inheritdoc />
        public override global::Anthropic.Caller7 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaDirectCaller? direct = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminatorType.Direct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaDirectCaller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaDirectCaller> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaDirectCaller)}");
                direct = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaServerToolCaller? codeExecution20250825 = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminatorType.CodeExecution20250825)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaServerToolCaller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaServerToolCaller> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaServerToolCaller)}");
                codeExecution20250825 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaServerToolCaller20260120? codeExecution20260120 = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminatorType.CodeExecution20260120)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaServerToolCaller20260120), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaServerToolCaller20260120> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaServerToolCaller20260120)}");
                codeExecution20260120 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.Caller7(
                discriminator?.Type,
                direct,
                codeExecution20250825,
                codeExecution20260120
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Caller7 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDirect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaDirectCaller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaDirectCaller?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaDirectCaller).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Direct, typeInfo);
            }
            else if (value.IsCodeExecution20250825)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaServerToolCaller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaServerToolCaller?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaServerToolCaller).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecution20250825, typeInfo);
            }
            else if (value.IsCodeExecution20260120)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaServerToolCaller20260120), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaServerToolCaller20260120?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaServerToolCaller20260120).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecution20260120, typeInfo);
            }
        }
    }
}