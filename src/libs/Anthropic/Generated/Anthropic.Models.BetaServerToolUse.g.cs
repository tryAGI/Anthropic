
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaServerToolUse
    {
        /// <summary>
        /// The number of web search requests made.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WebSearchRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServerToolUse" /> class.
        /// </summary>
        /// <param name="webSearchRequests">
        /// The number of web search requests made.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaServerToolUse(
            int webSearchRequests)
        {
            this.WebSearchRequests = webSearchRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServerToolUse" /> class.
        /// </summary>
        public BetaServerToolUse()
        {
        }

    }
}