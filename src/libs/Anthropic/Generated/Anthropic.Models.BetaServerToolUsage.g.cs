
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaServerToolUsage
    {
        /// <summary>
        /// The number of web fetch tool requests.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </summary>
        /// <default>0</default>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_fetch_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WebFetchRequests { get; set; } = 0;

        /// <summary>
        /// The number of web search tool requests.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <default>0</default>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WebSearchRequests { get; set; } = 0;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServerToolUsage" /> class.
        /// </summary>
        /// <param name="webFetchRequests">
        /// The number of web fetch tool requests.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </param>
        /// <param name="webSearchRequests">
        /// The number of web search tool requests.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaServerToolUsage(
            int webFetchRequests,
            int webSearchRequests)
        {
            this.WebFetchRequests = webFetchRequests;
            this.WebSearchRequests = webSearchRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServerToolUsage" /> class.
        /// </summary>
        public BetaServerToolUsage()
        {
        }
    }
}