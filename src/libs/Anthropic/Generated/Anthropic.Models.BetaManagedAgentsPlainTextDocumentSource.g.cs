
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
        /// <default>"text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "text";

        /// <summary>
        /// MIME type of the text content. Must be "text/plain".
        /// </summary>
        /// <default>"text/plain"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        public string MediaType { get; set; } = "text/plain";

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
            string type = "text",
            string mediaType = "text/plain")
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

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsPlainTextDocumentSource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsPlainTextDocumentSource FromData(string data)
        {
            return new BetaManagedAgentsPlainTextDocumentSource
            {
                Data = data,
            };
        }

    }
}