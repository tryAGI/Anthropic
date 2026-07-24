
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Reference to every tool in the named MCP server's toolset.
    /// </summary>
    public sealed partial class BetaToolChangeMCPToolsetReference
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerName { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="BetaToolChangeMCPToolsetReference" /> class.
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaToolChangeMCPToolsetReference(
            string serverName,
            string type = "mcp_toolset_reference")
        {
            this.ServerName = serverName ?? throw new global::System.ArgumentNullException(nameof(serverName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolChangeMCPToolsetReference" /> class.
        /// </summary>
        public BetaToolChangeMCPToolsetReference()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaToolChangeMCPToolsetReference"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaToolChangeMCPToolsetReference FromServerName(string serverName)
        {
            return new BetaToolChangeMCPToolsetReference
            {
                ServerName = serverName,
            };
        }

    }
}