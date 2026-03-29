
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration for a group of tools from an MCP server.<br/>
    /// Allows configuring enabled status and defer_loading for all tools<br/>
    /// from an MCP server, with optional per-tool overrides.
    /// </summary>
    public sealed partial class BetaMCPToolset
    {
        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlVariant112? CacheControl { get; set; }

        /// <summary>
        /// Configuration overrides for specific tools, keyed by tool name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaMCPToolConfig>? Configs { get; set; }

        /// <summary>
        /// Default configuration applied to all tools from this server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_config")]
        public global::Anthropic.BetaMCPToolDefaultConfig? DefaultConfig { get; set; }

        /// <summary>
        /// Name of the MCP server to configure tools for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"mcp_toolset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "mcp_toolset";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMCPToolset" /> class.
        /// </summary>
        /// <param name="mcpServerName">
        /// Name of the MCP server to configure tools for
        /// </param>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="configs">
        /// Configuration overrides for specific tools, keyed by tool name
        /// </param>
        /// <param name="defaultConfig">
        /// Default configuration applied to all tools from this server
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMCPToolset(
            string mcpServerName,
            global::Anthropic.CacheControlVariant112? cacheControl,
            global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaMCPToolConfig>? configs,
            global::Anthropic.BetaMCPToolDefaultConfig? defaultConfig,
            string type = "mcp_toolset")
        {
            this.CacheControl = cacheControl;
            this.Configs = configs;
            this.DefaultConfig = defaultConfig;
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMCPToolset" /> class.
        /// </summary>
        public BetaMCPToolset()
        {
        }
    }
}