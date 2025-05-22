
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A content block that represents a file to be uploaded to the container<br/>
    /// Files uploaded via this block will be available in the container's input directory.
    /// </summary>
    public sealed partial class BetaRequestContainerUploadBlock
    {
        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.BetaCacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaRequestContainerUploadBlockTypeJsonConverter))]
        public global::Anthropic.BetaRequestContainerUploadBlockType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestContainerUploadBlock" /> class.
        /// </summary>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="fileId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestContainerUploadBlock(
            string fileId,
            global::Anthropic.BetaCacheControlEphemeral? cacheControl,
            global::Anthropic.BetaRequestContainerUploadBlockType type)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.CacheControl = cacheControl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestContainerUploadBlock" /> class.
        /// </summary>
        public BetaRequestContainerUploadBlock()
        {
        }
    }
}