
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// URL-based MCP server connection as returned in API responses.<br/>
    /// Example: {"type":"url","name":"example-mcp","url":"https://example-server.modelcontextprotocol.io/sse"}
    /// </summary>
    public sealed partial class BetaManagedAgentsMCPServerURLDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPServerURLDefinitionTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMCPServerURLDefinitionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMCPServerURLDefinition" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMCPServerURLDefinition(
            string name,
            string url,
            global::Anthropic.BetaManagedAgentsMCPServerURLDefinitionType type)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMCPServerURLDefinition" /> class.
        /// </summary>
        public BetaManagedAgentsMCPServerURLDefinition()
        {
        }
    }
}