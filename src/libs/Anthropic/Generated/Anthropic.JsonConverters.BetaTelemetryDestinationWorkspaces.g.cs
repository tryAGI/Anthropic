#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaTelemetryDestinationWorkspacesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaTelemetryDestinationWorkspaces>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaTelemetryDestinationWorkspaces Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaTelemetryDestinationWorkspacesAll? all = default;
            if (discriminator?.Type == global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminatorType.All)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesAll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesAll> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTelemetryDestinationWorkspacesAll)}");
                all = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaTelemetryDestinationWorkspacesInclude? include = default;
            if (discriminator?.Type == global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminatorType.Include)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesInclude), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesInclude> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTelemetryDestinationWorkspacesInclude)}");
                include = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaTelemetryDestinationWorkspacesExclude? exclude = default;
            if (discriminator?.Type == global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminatorType.Exclude)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesExclude), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesExclude> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTelemetryDestinationWorkspacesExclude)}");
                exclude = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaTelemetryDestinationWorkspaces(
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
            global::Anthropic.BetaTelemetryDestinationWorkspaces value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsAll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesAll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesAll?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesAll).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAll(), typeInfo);
            }
            else if (value.IsInclude)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesInclude), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesInclude?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesInclude).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInclude(), typeInfo);
            }
            else if (value.IsExclude)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesExclude), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationWorkspacesExclude?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesExclude).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickExclude(), typeInfo);
            }
        }
    }
}