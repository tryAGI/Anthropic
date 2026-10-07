
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Which sources contribute URLs the web_fetch tool may fetch. A key that is null was not set and allows every URL from that source.
    /// </summary>
    public sealed partial class BetaManagedAgentsWebFetchUrlSources
    {
        /// <summary>
        /// Whether URLs in the text of user messages may be fetched. Null when not set, which allows them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_input")]
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput? UserInput { get; set; }

        /// <summary>
        /// Which custom tools' results contribute URLs that may be fetched. Null when not set, which allows every custom tool's results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_tool_results")]
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? ClientToolResults { get; set; }

        /// <summary>
        /// Which of the web_search and web_fetch tools' results contribute URLs that may be fetched. Null when not set, which allows both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_results")]
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? ServerToolResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWebFetchUrlSources" /> class.
        /// </summary>
        /// <param name="userInput">
        /// Whether URLs in the text of user messages may be fetched. Null when not set, which allows them.
        /// </param>
        /// <param name="clientToolResults">
        /// Which custom tools' results contribute URLs that may be fetched. Null when not set, which allows every custom tool's results.
        /// </param>
        /// <param name="serverToolResults">
        /// Which of the web_search and web_fetch tools' results contribute URLs that may be fetched. Null when not set, which allows both.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWebFetchUrlSources(
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput? userInput,
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? clientToolResults,
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? serverToolResults)
        {
            this.UserInput = userInput;
            this.ClientToolResults = clientToolResults;
            this.ServerToolResults = serverToolResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWebFetchUrlSources" /> class.
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSources()
        {
        }

    }
}