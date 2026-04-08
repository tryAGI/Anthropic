
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsFileDocumentSourceTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsFileDocumentSourceType Type { get; set; }

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
            global::Anthropic.BetaManagedAgentsFileDocumentSourceType type)
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
    }
}