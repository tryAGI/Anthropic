
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Plain text document content.
    /// </summary>
    public sealed partial class BetaManagedAgentsPlainTextDocumentSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPlainTextDocumentSourceTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsPlainTextDocumentSourceType Type { get; set; }

        /// <summary>
        /// MIME type of the text content. Must be "text/plain".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPlainTextDocumentSourceMediaTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsPlainTextDocumentSourceMediaType MediaType { get; set; }

        /// <summary>
        /// The plain text content.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsPlainTextDocumentSource" /> class.
        /// </summary>
        /// <param name="data">
        /// The plain text content.
        /// </param>
        /// <param name="type"></param>
        /// <param name="mediaType">
        /// MIME type of the text content. Must be "text/plain".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsPlainTextDocumentSource(
            string data,
            global::Anthropic.BetaManagedAgentsPlainTextDocumentSourceType type,
            global::Anthropic.BetaManagedAgentsPlainTextDocumentSourceMediaType mediaType)
        {
            this.Type = type;
            this.MediaType = mediaType;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsPlainTextDocumentSource" /> class.
        /// </summary>
        public BetaManagedAgentsPlainTextDocumentSource()
        {
        }
    }
}