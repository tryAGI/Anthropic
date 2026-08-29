
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The browser toolset: a single ``tools[]`` entry (carrying no<br/>
    /// ``name``) that declares the browser tool family. The model is served<br/>
    /// the family's tool with any members disabled via ``configs`` removed<br/>
    /// from its schema.
    /// </summary>
    public sealed partial class BrowserToolset20260801
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<global::Anthropic.AllowedCaller>? AllowedCallers { get; set; }

        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlVariant154? CacheControl { get; set; }

        /// <summary>
        /// Sparse per-member overrides, keyed by member name. Absent, null, and {} are equivalent; a member's defaults apply wherever its key is absent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        public global::Anthropic.BrowserToolsetConfigs? Configs { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"browser_toolset_20260801"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "browser_toolset_20260801";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserToolset20260801" /> class.
        /// </summary>
        /// <param name="allowedCallers"></param>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="configs">
        /// Sparse per-member overrides, keyed by member name. Absent, null, and {} are equivalent; a member's defaults apply wherever its key is absent.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserToolset20260801(
            global::System.Collections.Generic.IList<global::Anthropic.AllowedCaller>? allowedCallers,
            global::Anthropic.CacheControlVariant154? cacheControl,
            global::Anthropic.BrowserToolsetConfigs? configs,
            string type = "browser_toolset_20260801")
        {
            this.AllowedCallers = allowedCallers;
            this.CacheControl = cacheControl;
            this.Configs = configs;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserToolset20260801" /> class.
        /// </summary>
        public BrowserToolset20260801()
        {
        }

    }
}