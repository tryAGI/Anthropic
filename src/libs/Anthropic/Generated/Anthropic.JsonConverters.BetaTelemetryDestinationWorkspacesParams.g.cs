#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaTelemetryDestinationWorkspacesParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaTelemetryDestinationWorkspacesParams>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaTelemetryDestinationWorkspacesParams Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams? all = default;
            if (discriminator?.Type == global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminatorType.All)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams)}");
                all = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams? include = default;
            if (discriminator?.Type == global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminatorType.Include)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams)}");
                include = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams? exclude = default;
            if (discriminator?.Type == global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminatorType.Exclude)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams)}");
                exclude = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaTelemetryDestinationWorkspacesParams(
                discriminator?.Type,
                all,

                include,

                exclude
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaTelemetryDestinationWorkspacesParams value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsAll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAll(), typeInfo);
            }
            else if (value.IsInclude)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInclude(), typeInfo);
            }
            else if (value.IsExclude)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickExclude(), typeInfo);
            }
        }
    }
}