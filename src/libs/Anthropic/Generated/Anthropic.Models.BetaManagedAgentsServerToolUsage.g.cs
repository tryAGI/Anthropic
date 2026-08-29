
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Cumulative count of server-executed tool invocations, broken down by tool.<br/>
    /// Example: {"web_search_requests":3,"web_fetch_requests":0}
    /// </summary>
    public sealed partial class BetaManagedAgentsServerToolUsage
    {
        /// <summary>
        /// Number of server-executed web search requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_requests")]
        public int? WebSearchRequests { get; set; }

        /// <summary>
        /// Number of server-executed web fetch requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_fetch_requests")]
        public int? WebFetchRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsServerToolUsage" /> class.
        /// </summary>
        /// <param name="webSearchRequests">
        /// Number of server-executed web search requests.
        /// </param>
        /// <param name="webFetchRequests">
        /// Number of server-executed web fetch requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsServerToolUsage(
            int? webSearchRequests,
            int? webFetchRequests)
        {
            this.WebSearchRequests = webSearchRequests;
            this.WebFetchRequests = webFetchRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsServerToolUsage" /> class.
        /// </summary>
        public BetaManagedAgentsServerToolUsage()
        {
        }

    }
}