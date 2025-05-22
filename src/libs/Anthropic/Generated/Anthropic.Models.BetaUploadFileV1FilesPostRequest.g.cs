
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaUploadFileV1FilesPostRequest
    {
        /// <summary>
        /// The file to upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The file to upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUploadFileV1FilesPostRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="filename">
        /// The file to upload
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUploadFileV1FilesPostRequest(
            byte[] file,
            string filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUploadFileV1FilesPostRequest" /> class.
        /// </summary>
        public BetaUploadFileV1FilesPostRequest()
        {
        }
    }
}