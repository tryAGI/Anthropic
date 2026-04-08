
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaManagedAgentsMCPToolset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPToolsetTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMCPToolsetType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerName { get; set; }

        /// <summary>
        /// Resolved default configuration for all tools from an MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfig DefaultConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfig> Configs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMCPToolset" /> class.
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="defaultConfig">
        /// Resolved default configuration for all tools from an MCP server.
        /// </param>
        /// <param name="configs"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMCPToolset(
            string mcpServerName,
            global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfig defaultConfig,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfig> configs,
            global::Anthropic.BetaManagedAgentsMCPToolsetType type)
        {
            this.Type = type;
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
            this.DefaultConfig = defaultConfig ?? throw new global::System.ArgumentNullException(nameof(defaultConfig));
            this.Configs = configs ?? throw new global::System.ArgumentNullException(nameof(configs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMCPToolset" /> class.
        /// </summary>
        public BetaManagedAgentsMCPToolset()
        {
        }
    }
}