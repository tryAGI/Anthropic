#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class StateChangesVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.StateChangesVariant1Item>
    {
        /// <inheritdoc />
        public override global::Anthropic.StateChangesVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaBrowserStateChangeTabOpened? tabOpened = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.TabOpened)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserStateChangeTabOpened), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserStateChangeTabOpened> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaBrowserStateChangeTabOpened)}");
                tabOpened = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaBrowserStateChangeDownloadStarted? downloadStarted = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserStateChangeDownloadStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserStateChangeDownloadStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaBrowserStateChangeDownloadStarted)}");
                downloadStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaBrowserStateChangeDownloadCompleted? downloadCompleted = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserStateChangeDownloadCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserStateChangeDownloadCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaBrowserStateChangeDownloadCompleted)}");
                downloadCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaBrowserStateChangeDownloadFailed? downloadFailed = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserStateChangeDownloadFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserStateChangeDownloadFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaBrowserStateChangeDownloadFailed)}");
                downloadFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.StateChangesVariant1Item(
                discriminator?.Type,
                tabOpened,

                downloadStarted,

                downloadCompleted,

                downloadFailed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.StateChangesVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTabOpened)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserStateChangeTabOpened), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserStateChangeTabOpened?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserStateChangeTabOpened).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TabOpened!, typeInfo);
            }
            else if (value.IsDownloadStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserStateChangeDownloadStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserStateChangeDownloadStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserStateChangeDownloadStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DownloadStarted!, typeInfo);
            }
            else if (value.IsDownloadCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserStateChangeDownloadCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserStateChangeDownloadCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserStateChangeDownloadCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DownloadCompleted!, typeInfo);
            }
            else if (value.IsDownloadFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserStateChangeDownloadFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserStateChangeDownloadFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserStateChangeDownloadFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DownloadFailed!, typeInfo);
            }
        }
    }
}