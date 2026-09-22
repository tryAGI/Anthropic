
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Reference to every tool in the named MCP server's toolset, as a<br/>
    /// ``compaction`` block's ``tool_changes`` entry reports it. Send it back<br/>
    /// unchanged with the block.
    /// </summary>
    public sealed partial class BetaResponseToolChangeMCPToolsetReference
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerName { get; set; }

        /// <summary>
        /// Default Value: mcp_toolset_reference
        /// </summary>
        /// <default>"mcp_toolset_reference"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "mcp_toolset_reference";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolChangeMCPToolsetReference" /> class.
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="type">
        /// Default Value: mcp_toolset_reference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseToolChangeMCPToolsetReference(
            string serverName,
            string type = "mcp_toolset_reference")
        {
            this.ServerName = serverName ?? throw new global::System.ArgumentNullException(nameof(serverName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolChangeMCPToolsetReference" /> class.
        /// </summary>
        public BetaResponseToolChangeMCPToolsetReference()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaResponseToolChangeMCPToolsetReference"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaResponseToolChangeMCPToolsetReference FromServerName(string serverName)
        {
            return new BetaResponseToolChangeMCPToolsetReference
            {
                ServerName = serverName,
            };
        }

    }
}