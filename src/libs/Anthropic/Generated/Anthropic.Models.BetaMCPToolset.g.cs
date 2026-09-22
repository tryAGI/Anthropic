
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
        public global::Anthropic.CacheControlVariant116? CacheControl { get; set; }

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
        /// The server's tool listing, pinned: when present, the server is not asked for its tools before sampling and exactly these entries, with `default_config` and `configs` applied, are the toolset's tools. Copy it from the `mcp_tool_listing` block of an earlier response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMCPTool>? Tools { get; set; }

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
        /// <param name="tools">
        /// The server's tool listing, pinned: when present, the server is not asked for its tools before sampling and exactly these entries, with `default_config` and `configs` applied, are the toolset's tools. Copy it from the `mcp_tool_listing` block of an earlier response.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMCPToolset(
            string mcpServerName,
            global::Anthropic.CacheControlVariant116? cacheControl,
            global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaMCPToolConfig>? configs,
            global::Anthropic.BetaMCPToolDefaultConfig? defaultConfig,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMCPTool>? tools,
            string type = "mcp_toolset")
        {
            this.CacheControl = cacheControl;
            this.Configs = configs;
            this.DefaultConfig = defaultConfig;
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
            this.Tools = tools;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMCPToolset" /> class.
        /// </summary>
        public BetaMCPToolset()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaMCPToolset"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaMCPToolset FromMcpServerName(string mcpServerName)
        {
            return new BetaMCPToolset
            {
                McpServerName = mcpServerName,
            };
        }

    }
}