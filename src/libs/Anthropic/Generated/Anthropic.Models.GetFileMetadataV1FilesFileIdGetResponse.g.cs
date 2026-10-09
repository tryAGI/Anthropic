
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetFileMetadataV1FilesFileIdGetResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.GetFileMetadataV1FilesFileIdGetResponseError Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Default Value: error
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileMetadataV1FilesFileIdGetResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="requestId"></param>
        /// <param name="type">
        /// Default Value: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFileMetadataV1FilesFileIdGetResponse(
            global::Anthropic.GetFileMetadataV1FilesFileIdGetResponseError error,
            string? requestId,
            string type = "error")
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileMetadataV1FilesFileIdGetResponse" /> class.
        /// </summary>
        public GetFileMetadataV1FilesFileIdGetResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="GetFileMetadataV1FilesFileIdGetResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static GetFileMetadataV1FilesFileIdGetResponse FromError(global::Anthropic.GetFileMetadataV1FilesFileIdGetResponseError error)
        {
            return new GetFileMetadataV1FilesFileIdGetResponse
            {
                Error = error,
            };
        }

    }
}