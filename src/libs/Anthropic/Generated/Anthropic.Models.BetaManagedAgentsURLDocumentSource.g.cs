
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Document referenced by URL.
    /// </summary>
    public sealed partial class BetaManagedAgentsURLDocumentSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsURLDocumentSourceTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsURLDocumentSourceType Type { get; set; }

        /// <summary>
        /// URL of the document to fetch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsURLDocumentSource" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the document to fetch.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsURLDocumentSource(
            string url,
            global::Anthropic.BetaManagedAgentsURLDocumentSourceType type)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsURLDocumentSource" /> class.
        /// </summary>
        public BetaManagedAgentsURLDocumentSource()
        {
        }
    }
}