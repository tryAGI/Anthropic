#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaMemoryTool20250818CommandJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaMemoryTool20250818Command>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaMemoryTool20250818Command Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818CommandDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818CommandDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaMemoryTool20250818CommandDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaMemoryTool20250818ViewCommand? view = default;
            if (discriminator?.Command == global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand.View)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818ViewCommand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818ViewCommand> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaMemoryTool20250818ViewCommand)}");
                view = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaMemoryTool20250818CreateCommand? create = default;
            if (discriminator?.Command == global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand.Create)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818CreateCommand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818CreateCommand> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaMemoryTool20250818CreateCommand)}");
                create = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaMemoryTool20250818StrReplaceCommand? strReplace = default;
            if (discriminator?.Command == global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand.StrReplace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818StrReplaceCommand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818StrReplaceCommand> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaMemoryTool20250818StrReplaceCommand)}");
                strReplace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaMemoryTool20250818InsertCommand? insert = default;
            if (discriminator?.Command == global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand.Insert)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818InsertCommand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818InsertCommand> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaMemoryTool20250818InsertCommand)}");
                insert = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaMemoryTool20250818DeleteCommand? delete = default;
            if (discriminator?.Command == global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand.Delete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818DeleteCommand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818DeleteCommand> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaMemoryTool20250818DeleteCommand)}");
                delete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaMemoryTool20250818RenameCommand? rename = default;
            if (discriminator?.Command == global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand.Rename)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818RenameCommand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818RenameCommand> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaMemoryTool20250818RenameCommand)}");
                rename = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.BetaMemoryTool20250818Command(
                discriminator?.Command,
                view,
                create,
                strReplace,
                insert,
                delete,
                rename
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaMemoryTool20250818Command value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsView)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818ViewCommand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818ViewCommand?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaMemoryTool20250818ViewCommand).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.View, typeInfo);
            }
            else if (value.IsCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818CreateCommand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818CreateCommand?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaMemoryTool20250818CreateCommand).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Create, typeInfo);
            }
            else if (value.IsStrReplace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818StrReplaceCommand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818StrReplaceCommand?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaMemoryTool20250818StrReplaceCommand).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrReplace, typeInfo);
            }
            else if (value.IsInsert)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818InsertCommand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818InsertCommand?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaMemoryTool20250818InsertCommand).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Insert, typeInfo);
            }
            else if (value.IsDelete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818DeleteCommand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818DeleteCommand?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaMemoryTool20250818DeleteCommand).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Delete, typeInfo);
            }
            else if (value.IsRename)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818RenameCommand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818RenameCommand?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaMemoryTool20250818RenameCommand).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Rename, typeInfo);
            }
        }
    }
}