
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration for tools from an MCP server defined in `mcp_servers`.
    /// </summary>
    public sealed partial class BetaManagedAgentsMCPToolsetParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"mcp_toolset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "mcp_toolset";

        /// <summary>
        /// Name of the MCP server. Must match a server name from the mcp_servers array. 1-255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerName { get; set; }

        /// <summary>
        /// Default configuration for all tools from this server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_config")]
        public global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfigParams? DefaultConfig { get; set; }

        /// <summary>
        /// Per-tool configuration overrides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfigParams>? Configs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMCPToolsetParams" /> class.
        /// </summary>
        /// <param name="mcpServerName">
        /// Name of the MCP server. Must match a server name from the mcp_servers array. 1-255 characters.
        /// </param>
        /// <param name="defaultConfig">
        /// Default configuration for all tools from this server.
        /// </param>
        /// <param name="configs">
        /// Per-tool configuration overrides.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMCPToolsetParams(
            string mcpServerName,
            global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfigParams? defaultConfig,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfigParams>? configs,
            string type = "mcp_toolset")
        {
            this.Type = type;
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
            this.DefaultConfig = defaultConfig;
            this.Configs = configs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMCPToolsetParams" /> class.
        /// </summary>
        public BetaManagedAgentsMCPToolsetParams()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsMCPToolsetParams"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsMCPToolsetParams FromMcpServerName(string mcpServerName)
        {
            return new BetaManagedAgentsMCPToolsetParams
            {
                McpServerName = mcpServerName,
            };
        }

    }
}