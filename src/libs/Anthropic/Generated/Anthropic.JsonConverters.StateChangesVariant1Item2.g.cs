#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class StateChangesVariant1Item2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.StateChangesVariant1Item2>
    {
        /// <inheritdoc />
        public override global::Anthropic.StateChangesVariant1Item2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BrowserStateChangeTabOpened? tabOpened = default;
            if (discriminator?.Type == global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.TabOpened)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserStateChangeTabOpened), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserStateChangeTabOpened> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BrowserStateChangeTabOpened)}");
                tabOpened = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BrowserStateChangeDownloadStarted? downloadStarted = default;
            if (discriminator?.Type == global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserStateChangeDownloadStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserStateChangeDownloadStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BrowserStateChangeDownloadStarted)}");
                downloadStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BrowserStateChangeDownloadCompleted? downloadCompleted = default;
            if (discriminator?.Type == global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserStateChangeDownloadCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserStateChangeDownloadCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BrowserStateChangeDownloadCompleted)}");
                downloadCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BrowserStateChangeDownloadFailed? downloadFailed = default;
            if (discriminator?.Type == global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserStateChangeDownloadFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserStateChangeDownloadFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BrowserStateChangeDownloadFailed)}");
                downloadFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.StateChangesVariant1Item2(
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
            global::Anthropic.StateChangesVariant1Item2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTabOpened)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserStateChangeTabOpened), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserStateChangeTabOpened?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserStateChangeTabOpened).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TabOpened!, typeInfo);
            }
            else if (value.IsDownloadStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserStateChangeDownloadStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserStateChangeDownloadStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserStateChangeDownloadStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DownloadStarted!, typeInfo);
            }
            else if (value.IsDownloadCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserStateChangeDownloadCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserStateChangeDownloadCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserStateChangeDownloadCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DownloadCompleted!, typeInfo);
            }
            else if (value.IsDownloadFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserStateChangeDownloadFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserStateChangeDownloadFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserStateChangeDownloadFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DownloadFailed!, typeInfo);
            }
        }
    }
}