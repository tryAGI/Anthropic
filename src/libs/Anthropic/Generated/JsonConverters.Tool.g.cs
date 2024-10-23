#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Tool>
    {
        /// <inheritdoc />
        public override global::Anthropic.Tool Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Anthropic.ToolCustom? custom = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolCustom), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolCustom> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolCustom).Name}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.ToolComputerUse? computerUse = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolComputerUse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolComputerUse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolComputerUse).Name}");
                computerUse = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.ToolTextEditor? textEditor = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolTextEditor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolTextEditor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolTextEditor).Name}");
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.ToolBash? bash = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolBash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolBash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolBash).Name}");
                bash = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Anthropic.Tool(
                custom,
                computerUse,
                textEditor,
                bash
                );

            if (custom != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolCustom), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolCustom> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolCustom).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (computerUse != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolComputerUse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolComputerUse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolComputerUse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (textEditor != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolTextEditor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolTextEditor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolTextEditor).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (bash != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolBash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolBash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolBash).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Tool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolCustom), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolCustom?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolCustom).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom, typeInfo);
            }
            else if (value.IsComputerUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolComputerUse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolComputerUse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolComputerUse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerUse, typeInfo);
            }
            else if (value.IsTextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolTextEditor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolTextEditor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolTextEditor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor, typeInfo);
            }
            else if (value.IsBash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolBash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolBash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolBash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash, typeInfo);
            }
        }
    }
}