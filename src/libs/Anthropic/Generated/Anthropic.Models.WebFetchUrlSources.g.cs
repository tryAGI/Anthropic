
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Which sources contribute to the set of URLs web fetch may fetch.<br/>
    /// Each key is a tagged variant: ``user_input`` is ``all`` or ``none``; the<br/>
    /// two tool filters are ``all``, ``none``, ``only`` (only the named tools'<br/>
    /// results) or ``except`` (every result but the named tools'). A named tool<br/>
    /// must be declared in this request's ``tools[]``.
    /// </summary>
    public sealed partial class WebFetchUrlSources
    {
        /// <summary>
        /// Which client tools' results contribute fetchable URLs: "all", "none", or an only or except list of client tool names from tools[].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_tool_results")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ClientToolResults2JsonConverter))]
        public global::Anthropic.ClientToolResults2? ClientToolResults { get; set; }

        /// <summary>
        /// Which server tools' results contribute fetchable URLs: "all", "none", or an only or except list of server tool names from tools[]; only web_search and web_fetch results ever contribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_results")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ServerToolResults2JsonConverter))]
        public global::Anthropic.ServerToolResults2? ServerToolResults { get; set; }

        /// <summary>
        /// Whether URLs in user messages are fetchable: "all" or "none".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.UserInput2JsonConverter))]
        public global::Anthropic.UserInput2? UserInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebFetchUrlSources" /> class.
        /// </summary>
        /// <param name="clientToolResults">
        /// Which client tools' results contribute fetchable URLs: "all", "none", or an only or except list of client tool names from tools[].
        /// </param>
        /// <param name="serverToolResults">
        /// Which server tools' results contribute fetchable URLs: "all", "none", or an only or except list of server tool names from tools[]; only web_search and web_fetch results ever contribute.
        /// </param>
        /// <param name="userInput">
        /// Whether URLs in user messages are fetchable: "all" or "none".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebFetchUrlSources(
            global::Anthropic.ClientToolResults2? clientToolResults,
            global::Anthropic.ServerToolResults2? serverToolResults,
            global::Anthropic.UserInput2? userInput)
        {
            this.ClientToolResults = clientToolResults;
            this.ServerToolResults = serverToolResults;
            this.UserInput = userInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebFetchUrlSources" /> class.
        /// </summary>
        public WebFetchUrlSources()
        {
        }

    }
}