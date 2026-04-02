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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaMemoryTool20250818CommandDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaMemoryTool20250818ViewCommand? view = default;
            if (discriminator?.Command == global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand.View)
            {
                view = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaMemoryTool20250818ViewCommand>(ref reader, options);
            }
            global::Anthropic.BetaMemoryTool20250818CreateCommand? create = default;
            if (discriminator?.Command == global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand.Create)
            {
                create = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaMemoryTool20250818CreateCommand>(ref reader, options);
            }
            global::Anthropic.BetaMemoryTool20250818StrReplaceCommand? strReplace = default;
            if (discriminator?.Command == global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand.StrReplace)
            {
                strReplace = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaMemoryTool20250818StrReplaceCommand>(ref reader, options);
            }
            global::Anthropic.BetaMemoryTool20250818InsertCommand? insert = default;
            if (discriminator?.Command == global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand.Insert)
            {
                insert = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaMemoryTool20250818InsertCommand>(ref reader, options);
            }
            global::Anthropic.BetaMemoryTool20250818DeleteCommand? delete = default;
            if (discriminator?.Command == global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand.Delete)
            {
                delete = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaMemoryTool20250818DeleteCommand>(ref reader, options);
            }
            global::Anthropic.BetaMemoryTool20250818RenameCommand? rename = default;
            if (discriminator?.Command == global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand.Rename)
            {
                rename = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaMemoryTool20250818RenameCommand>(ref reader, options);
            }

            var __value = new global::Anthropic.BetaMemoryTool20250818Command(
                discriminator?.Command,
                view,

                create,

                strReplace,

                insert,

                delete,

                rename
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaMemoryTool20250818Command value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsView)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.View, typeof(global::Anthropic.BetaMemoryTool20250818ViewCommand), options);
            }
            else if (value.IsCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Create, typeof(global::Anthropic.BetaMemoryTool20250818CreateCommand), options);
            }
            else if (value.IsStrReplace)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrReplace, typeof(global::Anthropic.BetaMemoryTool20250818StrReplaceCommand), options);
            }
            else if (value.IsInsert)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Insert, typeof(global::Anthropic.BetaMemoryTool20250818InsertCommand), options);
            }
            else if (value.IsDelete)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Delete, typeof(global::Anthropic.BetaMemoryTool20250818DeleteCommand), options);
            }
            else if (value.IsRename)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Rename, typeof(global::Anthropic.BetaMemoryTool20250818RenameCommand), options);
            }
        }
    }
}