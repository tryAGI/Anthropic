
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response model for a file uploaded to the container.
    /// </summary>
    public sealed partial class BetaResponseContainerUploadBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Default Value: container_upload
        /// </summary>
        /// <default>global::Anthropic.BetaResponseContainerUploadBlockType.ContainerUpload</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseContainerUploadBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseContainerUploadBlockType Type { get; set; } = global::Anthropic.BetaResponseContainerUploadBlockType.ContainerUpload;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseContainerUploadBlock" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="type">
        /// Default Value: container_upload
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseContainerUploadBlock(
            string fileId,
            global::Anthropic.BetaResponseContainerUploadBlockType type = global::Anthropic.BetaResponseContainerUploadBlockType.ContainerUpload)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseContainerUploadBlock" /> class.
        /// </summary>
        public BetaResponseContainerUploadBlock()
        {
        }
    }
}