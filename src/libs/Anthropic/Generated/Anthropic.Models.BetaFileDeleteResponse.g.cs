
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaFileDeleteResponse
    {
        /// <summary>
        /// ID of the deleted file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Deleted object type.<br/>
        /// For file deletion, this is always `"file_deleted"`.<br/>
        /// Default Value: file_deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaFileDeleteResponseTypeJsonConverter))]
        public global::Anthropic.BetaFileDeleteResponseType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFileDeleteResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the deleted file.
        /// </param>
        /// <param name="type">
        /// Deleted object type.<br/>
        /// For file deletion, this is always `"file_deleted"`.<br/>
        /// Default Value: file_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFileDeleteResponse(
            string id,
            global::Anthropic.BetaFileDeleteResponseType? type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFileDeleteResponse" /> class.
        /// </summary>
        public BetaFileDeleteResponse()
        {
        }
    }
}