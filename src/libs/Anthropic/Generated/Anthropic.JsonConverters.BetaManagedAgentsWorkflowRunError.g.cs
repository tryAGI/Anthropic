#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaManagedAgentsWorkflowRunErrorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsWorkflowRunError>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsWorkflowRunError Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError? timeoutError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminatorType.TimeoutError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError)}");
                timeoutError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsProgramWorkflowRunError? programError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminatorType.ProgramError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsProgramWorkflowRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsProgramWorkflowRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsProgramWorkflowRunError)}");
                programError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError? unknownError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminatorType.UnknownError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError)}");
                unknownError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError? threadLimitError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminatorType.ThreadLimitError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError)}");
                threadLimitError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError? maxWorkflowRunsError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminatorType.MaxWorkflowRunsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError)}");
                maxWorkflowRunsError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaManagedAgentsWorkflowRunError(
                discriminator?.Type,
                timeoutError,

                programError,

                unknownError,

                threadLimitError,

                maxWorkflowRunsError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsWorkflowRunError value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTimeoutError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTimeoutError(), typeInfo);
            }
            else if (value.IsProgramError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsProgramWorkflowRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsProgramWorkflowRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsProgramWorkflowRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickProgramError(), typeInfo);
            }
            else if (value.IsUnknownError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUnknownError(), typeInfo);
            }
            else if (value.IsThreadLimitError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickThreadLimitError(), typeInfo);
            }
            else if (value.IsMaxWorkflowRunsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMaxWorkflowRunsError(), typeInfo);
            }
        }
    }
}