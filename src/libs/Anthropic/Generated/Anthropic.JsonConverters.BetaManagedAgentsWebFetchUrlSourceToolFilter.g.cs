#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaManagedAgentsWebFetchUrlSourceToolFilterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? all = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType.All)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll)}");
                all = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? none = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone)}");
                none = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly? only = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType.Only)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly)}");
                only = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept? except = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType.Except)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept)}");
                except = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter(
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
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAll(), typeInfo);
            }
            else if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNone(), typeInfo);
            }
            else if (value.IsOnly)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOnly(), typeInfo);
            }
            else if (value.IsExcept)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickExcept(), typeInfo);
            }
        }
    }
}