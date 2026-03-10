#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Caller13JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Caller13>
    {
        /// <inheritdoc />
        public override global::Anthropic.Caller13 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseServerToolUseBlockCallerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseServerToolUseBlockCallerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseServerToolUseBlockCallerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.DirectCaller? direct = default;
            if (discriminator?.Type == global::Anthropic.ResponseServerToolUseBlockCallerDiscriminatorType.Direct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.DirectCaller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.DirectCaller> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.DirectCaller)}");
                direct = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ServerToolCaller? codeExecution20250825 = default;
            if (discriminator?.Type == global::Anthropic.ResponseServerToolUseBlockCallerDiscriminatorType.CodeExecution20250825)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ServerToolCaller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ServerToolCaller> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ServerToolCaller)}");
                codeExecution20250825 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ServerToolCaller20260120? codeExecution20260120 = default;
            if (discriminator?.Type == global::Anthropic.ResponseServerToolUseBlockCallerDiscriminatorType.CodeExecution20260120)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ServerToolCaller20260120), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ServerToolCaller20260120> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ServerToolCaller20260120)}");
                codeExecution20260120 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.Caller13(
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
            global::Anthropic.Caller13 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDirect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.DirectCaller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.DirectCaller?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.DirectCaller).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Direct, typeInfo);
            }
            else if (value.IsCodeExecution20250825)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ServerToolCaller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ServerToolCaller?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ServerToolCaller).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecution20250825, typeInfo);
            }
            else if (value.IsCodeExecution20260120)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ServerToolCaller20260120), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ServerToolCaller20260120?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ServerToolCaller20260120).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecution20260120, typeInfo);
            }
        }
    }
}