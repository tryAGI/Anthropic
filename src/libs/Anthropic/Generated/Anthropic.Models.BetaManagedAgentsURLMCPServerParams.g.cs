
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// URL-based MCP server connection.<br/>
    /// Example: {"type":"url","name":"example-mcp","url":"https://example-server.modelcontextprotocol.io/sse"}
    /// </summary>
    public sealed partial class BetaManagedAgentsURLMCPServerParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsURLMCPServerParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsURLMCPServerParamsType Type { get; set; }

        /// <summary>
        /// Unique name for this server, referenced by mcp_toolset configurations. 1-255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Endpoint URL for the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsURLMCPServerParams" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique name for this server, referenced by mcp_toolset configurations. 1-255 characters.
        /// </param>
        /// <param name="url">
        /// Endpoint URL for the MCP server.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsURLMCPServerParams(
            string name,
            string url,
            global::Anthropic.BetaManagedAgentsURLMCPServerParamsType type)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsURLMCPServerParams" /> class.
        /// </summary>
        public BetaManagedAgentsURLMCPServerParams()
        {
        }
    }
}