
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaWebFetchTool20260209
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedCaller>? AllowedCallers { get; set; }

        /// <summary>
        /// List of domains to allow fetching from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// List of domains to block fetching from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_domains")]
        public global::System.Collections.Generic.IList<string>? BlockedDomains { get; set; }

        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlVariant140? CacheControl { get; set; }

        /// <summary>
        /// Citations configuration for fetched documents. Citations are disabled by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::Anthropic.BetaRequestCitationsConfig? Citations { get; set; }

        /// <summary>
        /// If true, tool will not be included in initial system prompt. Only loaded when returned via tool_reference from tool search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        public bool? DeferLoading { get; set; }

        /// <summary>
        /// Maximum number of tokens used by including web page text content in the context. The limit is approximate and does not apply to binary content such as PDFs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_content_tokens")]
        public int? MaxContentTokens { get; set; }

        /// <summary>
        /// Maximum number of times the tool can be used in the API request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_uses")]
        public int? MaxUses { get; set; }

        /// <summary>
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in `tool_use` blocks.
        /// </summary>
        /// <default>"web_fetch"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = "web_fetch";

        /// <summary>
        /// When true, guarantees schema validation on tool names and inputs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"web_fetch_20260209"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "web_fetch_20260209";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebFetchTool20260209" /> class.
        /// </summary>
        /// <param name="allowedCallers"></param>
        /// <param name="allowedDomains">
        /// List of domains to allow fetching from
        /// </param>
        /// <param name="blockedDomains">
        /// List of domains to block fetching from
        /// </param>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="citations">
        /// Citations configuration for fetched documents. Citations are disabled by default.
        /// </param>
        /// <param name="deferLoading">
        /// If true, tool will not be included in initial system prompt. Only loaded when returned via tool_reference from tool search.
        /// </param>
        /// <param name="maxContentTokens">
        /// Maximum number of tokens used by including web page text content in the context. The limit is approximate and does not apply to binary content such as PDFs.
        /// </param>
        /// <param name="maxUses">
        /// Maximum number of times the tool can be used in the API request.
        /// </param>
        /// <param name="name">
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in `tool_use` blocks.
        /// </param>
        /// <param name="strict">
        /// When true, guarantees schema validation on tool names and inputs
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebFetchTool20260209(
            global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedCaller>? allowedCallers,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? blockedDomains,
            global::Anthropic.CacheControlVariant140? cacheControl,
            global::Anthropic.BetaRequestCitationsConfig? citations,
            bool? deferLoading,
            int? maxContentTokens,
            int? maxUses,
            bool? strict,
            string name = "web_fetch",
            string type = "web_fetch_20260209")
        {
            this.AllowedCallers = allowedCallers;
            this.AllowedDomains = allowedDomains;
            this.BlockedDomains = blockedDomains;
            this.CacheControl = cacheControl;
            this.Citations = citations;
            this.DeferLoading = deferLoading;
            this.MaxContentTokens = maxContentTokens;
            this.MaxUses = maxUses;
            this.Name = name;
            this.Strict = strict;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebFetchTool20260209" /> class.
        /// </summary>
        public BetaWebFetchTool20260209()
        {
        }
    }
}