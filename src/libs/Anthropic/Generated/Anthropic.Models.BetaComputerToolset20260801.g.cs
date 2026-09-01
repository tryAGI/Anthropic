
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The computer toolset: a single ``tools[]`` entry (carrying no<br/>
    /// ``name``) that declares the computer tool family. The model is<br/>
    /// served the family's tool with any members disabled via ``configs``<br/>
    /// removed from its schema. Every member is enabled by default, zoom<br/>
    /// included. The single-tool options ``display_number`` and<br/>
    /// ``enable_zoom`` are not fields of a toolset entry — it carries only<br/>
    /// ``type``, ``configs``, and ``cache_control``; zoom is controlled<br/>
    /// via ``configs.zoom.enabled``.
    /// </summary>
    public sealed partial class BetaComputerToolset20260801
    {
        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlVariant110? CacheControl { get; set; }

        /// <summary>
        /// Sparse per-member overrides, keyed by member name. Absent, null, and {} are equivalent; a member's defaults apply wherever its key is absent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        public global::Anthropic.BetaComputerToolsetConfigs? Configs { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"computer_toolset_20260801"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "computer_toolset_20260801";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerToolset20260801" /> class.
        /// </summary>
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
        public BetaComputerToolset20260801(
            global::Anthropic.CacheControlVariant110? cacheControl,
            global::Anthropic.BetaComputerToolsetConfigs? configs,
            string type = "computer_toolset_20260801")
        {
            this.CacheControl = cacheControl;
            this.Configs = configs;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerToolset20260801" /> class.
        /// </summary>
        public BetaComputerToolset20260801()
        {
        }

    }
}