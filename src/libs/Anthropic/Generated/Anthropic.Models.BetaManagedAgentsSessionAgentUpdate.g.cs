
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Mid-session agent configuration update. Only `tools` and `mcp_servers` are updatable. Full replacement: the provided array becomes the new value. To preserve existing entries, GET the session, modify the array, and POST it back.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionAgentUpdate
    {
        /// <summary>
        /// Replacement tool list. Full replacement: the provided array becomes the new value. Send an empty array to clear; omit to preserve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? Tools { get; set; }

        /// <summary>
        /// Replacement MCP server list. Full replacement: the provided array becomes the new value. Send an empty array to clear; omit to preserve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? McpServers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionAgentUpdate" /> class.
        /// </summary>
        /// <param name="tools">
        /// Replacement tool list. Full replacement: the provided array becomes the new value. Send an empty array to clear; omit to preserve.
        /// </param>
        /// <param name="mcpServers">
        /// Replacement MCP server list. Full replacement: the provided array becomes the new value. Send an empty array to clear; omit to preserve.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionAgentUpdate(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? tools,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? mcpServers)
        {
            this.Tools = tools;
            this.McpServers = mcpServers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionAgentUpdate" /> class.
        /// </summary>
        public BetaManagedAgentsSessionAgentUpdate()
        {
        }

    }
}