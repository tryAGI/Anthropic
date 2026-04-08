
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Base64-encoded document data.
    /// </summary>
    public sealed partial class BetaManagedAgentsBase64DocumentSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsBase64DocumentSourceTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsBase64DocumentSourceType Type { get; set; }

        /// <summary>
        /// MIME type of the document (e.g., "application/pdf").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaType { get; set; }

        /// <summary>
        /// Base64-encoded document data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsBase64DocumentSource" /> class.
        /// </summary>
        /// <param name="mediaType">
        /// MIME type of the document (e.g., "application/pdf").
        /// </param>
        /// <param name="data">
        /// Base64-encoded document data.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsBase64DocumentSource(
            string mediaType,
            string data,
            global::Anthropic.BetaManagedAgentsBase64DocumentSourceType type)
        {
            this.Type = type;
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsBase64DocumentSource" /> class.
        /// </summary>
        public BetaManagedAgentsBase64DocumentSource()
        {
        }
    }
}