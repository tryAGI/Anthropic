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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ResponseServerToolUseBlockCallerDiscriminator>(ref readerCopy, options);

            global::Anthropic.DirectCaller? direct = default;
            if (discriminator?.Type == global::Anthropic.ResponseServerToolUseBlockCallerDiscriminatorType.Direct)
            {
                direct = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.DirectCaller>(ref reader, options);
            }
            global::Anthropic.ServerToolCaller? codeExecution20250825 = default;
            if (discriminator?.Type == global::Anthropic.ResponseServerToolUseBlockCallerDiscriminatorType.CodeExecution20250825)
            {
                codeExecution20250825 = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ServerToolCaller>(ref reader, options);
            }
            global::Anthropic.ServerToolCaller20260120? codeExecution20260120 = default;
            if (discriminator?.Type == global::Anthropic.ResponseServerToolUseBlockCallerDiscriminatorType.CodeExecution20260120)
            {
                codeExecution20260120 = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ServerToolCaller20260120>(ref reader, options);
            }

            var __value = new global::Anthropic.Caller13(
                discriminator?.Type,
                direct,

                codeExecution20250825,

                codeExecution20260120
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Caller13 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsDirect)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Direct, typeof(global::Anthropic.DirectCaller), options);
            }
            else if (value.IsCodeExecution20250825)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecution20250825, typeof(global::Anthropic.ServerToolCaller), options);
            }
            else if (value.IsCodeExecution20260120)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecution20260120, typeof(global::Anthropic.ServerToolCaller20260120), options);
            }
        }
    }
}