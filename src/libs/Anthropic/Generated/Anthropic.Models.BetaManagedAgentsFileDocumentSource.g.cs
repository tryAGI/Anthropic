
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Document referenced by file ID.
    /// </summary>
    public sealed partial class BetaManagedAgentsFileDocumentSource
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"file"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "file";

        /// <summary>
        /// ID of a previously uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsFileDocumentSource" /> class.
        /// </summary>
        /// <param name="fileId">
        /// ID of a previously uploaded file.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsFileDocumentSource(
            string fileId,
            string type = "file")
        {
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsFileDocumentSource" /> class.
        /// </summary>
        public BetaManagedAgentsFileDocumentSource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsFileDocumentSource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsFileDocumentSource FromFileId(string fileId)
        {
            return new BetaManagedAgentsFileDocumentSource
            {
                FileId = fileId,
            };
        }

    }
}