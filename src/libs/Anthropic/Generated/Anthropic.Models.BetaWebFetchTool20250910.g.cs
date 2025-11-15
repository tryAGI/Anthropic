
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaWebFetchTool20250910
    {
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
        public global::Anthropic.BetaCacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::Anthropic.BetaRequestCitationsConfig? Citations { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaWebFetchTool20250910NameJsonConverter))]
        public global::Anthropic.BetaWebFetchTool20250910Name Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaWebFetchTool20250910TypeJsonConverter))]
        public global::Anthropic.BetaWebFetchTool20250910Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebFetchTool20250910" /> class.
        /// </summary>
        /// <param name="allowedDomains">
        /// List of domains to allow fetching from
        /// </param>
        /// <param name="blockedDomains">
        /// List of domains to block fetching from
        /// </param>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="citations"></param>
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
        /// <param name="strict"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebFetchTool20250910(
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? blockedDomains,
            global::Anthropic.BetaCacheControlEphemeral? cacheControl,
            global::Anthropic.BetaRequestCitationsConfig? citations,
            int? maxContentTokens,
            int? maxUses,
            global::Anthropic.BetaWebFetchTool20250910Name name,
            bool? strict,
            global::Anthropic.BetaWebFetchTool20250910Type type)
        {
            this.AllowedDomains = allowedDomains;
            this.BlockedDomains = blockedDomains;
            this.CacheControl = cacheControl;
            this.Citations = citations;
            this.MaxContentTokens = maxContentTokens;
            this.MaxUses = maxUses;
            this.Name = name;
            this.Strict = strict;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebFetchTool20250910" /> class.
        /// </summary>
        public BetaWebFetchTool20250910()
        {
        }
    }
}