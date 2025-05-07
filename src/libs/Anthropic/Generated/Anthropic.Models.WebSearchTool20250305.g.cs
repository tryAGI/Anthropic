
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchTool20250305
    {
        /// <summary>
        /// If provided, only these domains will be included in results. Cannot be used alongside `blocked_domains`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// If provided, these domains will never appear in results. Cannot be used alongside `allowed_domains`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_domains")]
        public global::System.Collections.Generic.IList<string>? BlockedDomains { get; set; }

        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlEphemeral? CacheControl { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.WebSearchTool20250305NameJsonConverter))]
        public global::Anthropic.WebSearchTool20250305Name Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.WebSearchTool20250305TypeJsonConverter))]
        public global::Anthropic.WebSearchTool20250305Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::Anthropic.UserLocation? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool20250305" /> class.
        /// </summary>
        /// <param name="allowedDomains">
        /// If provided, only these domains will be included in results. Cannot be used alongside `blocked_domains`.
        /// </param>
        /// <param name="blockedDomains">
        /// If provided, these domains will never appear in results. Cannot be used alongside `allowed_domains`.
        /// </param>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="maxUses">
        /// Maximum number of times the tool can be used in the API request.
        /// </param>
        /// <param name="name">
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in `tool_use` blocks.
        /// </param>
        /// <param name="type"></param>
        /// <param name="userLocation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchTool20250305(
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? blockedDomains,
            global::Anthropic.CacheControlEphemeral? cacheControl,
            int? maxUses,
            global::Anthropic.WebSearchTool20250305Name name,
            global::Anthropic.WebSearchTool20250305Type type,
            global::Anthropic.UserLocation? userLocation)
        {
            this.AllowedDomains = allowedDomains;
            this.BlockedDomains = blockedDomains;
            this.CacheControl = cacheControl;
            this.MaxUses = maxUses;
            this.Name = name;
            this.Type = type;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool20250305" /> class.
        /// </summary>
        public WebSearchTool20250305()
        {
        }
    }
}