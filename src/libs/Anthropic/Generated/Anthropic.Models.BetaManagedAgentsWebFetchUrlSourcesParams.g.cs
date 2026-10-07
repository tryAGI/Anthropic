
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Which sources contribute URLs the web_fetch tool may fetch. When web_fetch is limited to URLs the conversation has already shown the model (in a user message, a custom tool's result, or an earlier web_search or web_fetch result), each key narrows one of those sources and defaults to "all". Setting all three keys to "none" is rejected.
    /// </summary>
    public sealed partial class BetaManagedAgentsWebFetchUrlSourcesParams
    {
        /// <summary>
        /// Whether URLs in the text of user messages may be fetched: "all" (the default) or "none".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_input")]
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputParams? UserInput { get; set; }

        /// <summary>
        /// Which custom tools' results contribute URLs that may be fetched: "all" (the default), "none", or an only or except list. Each name in a list must be a custom tool in the same tools array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_tool_results")]
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterParams? ClientToolResults { get; set; }

        /// <summary>
        /// Which of the web_search and web_fetch tools' results contribute URLs that may be fetched: "all" (the default), "none", or an only or except list. Each name in a list must be "web_search" or "web_fetch".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_results")]
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterParams? ServerToolResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWebFetchUrlSourcesParams" /> class.
        /// </summary>
        /// <param name="userInput">
        /// Whether URLs in the text of user messages may be fetched: "all" (the default) or "none".
        /// </param>
        /// <param name="clientToolResults">
        /// Which custom tools' results contribute URLs that may be fetched: "all" (the default), "none", or an only or except list. Each name in a list must be a custom tool in the same tools array.
        /// </param>
        /// <param name="serverToolResults">
        /// Which of the web_search and web_fetch tools' results contribute URLs that may be fetched: "all" (the default), "none", or an only or except list. Each name in a list must be "web_search" or "web_fetch".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWebFetchUrlSourcesParams(
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputParams? userInput,
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterParams? clientToolResults,
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterParams? serverToolResults)
        {
            this.UserInput = userInput;
            this.ClientToolResults = clientToolResults;
            this.ServerToolResults = serverToolResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWebFetchUrlSourcesParams" /> class.
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourcesParams()
        {
        }

    }
}