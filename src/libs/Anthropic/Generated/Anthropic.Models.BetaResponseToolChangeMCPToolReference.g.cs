
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Reference to a single MCP tool, by its server and its name on that<br/>
    /// server, as a ``compaction`` block's ``tool_changes`` entry reports it.<br/>
    /// Send it back unchanged with the block.
    /// </summary>
    public sealed partial class BetaResponseToolChangeMCPToolReference
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerName { get; set; }

        /// <summary>
        /// Default Value: mcp_tool_reference
        /// </summary>
        /// <default>"mcp_tool_reference"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "mcp_tool_reference";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolChangeMCPToolReference" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serverName"></param>
        /// <param name="type">
        /// Default Value: mcp_tool_reference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseToolChangeMCPToolReference(
            string name,
            string serverName,
            string type = "mcp_tool_reference")
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ServerName = serverName ?? throw new global::System.ArgumentNullException(nameof(serverName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolChangeMCPToolReference" /> class.
        /// </summary>
        public BetaResponseToolChangeMCPToolReference()
        {
        }

    }
}