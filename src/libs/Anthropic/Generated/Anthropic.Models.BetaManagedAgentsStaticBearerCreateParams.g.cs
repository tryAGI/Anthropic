
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Parameters for creating a static bearer token credential.<br/>
    /// Example: {"type":"static_bearer","token":"bearer_exampletoken","mcp_server_url":"https://example-server.modelcontextprotocol.io/sse"}
    /// </summary>
    public sealed partial class BetaManagedAgentsStaticBearerCreateParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsStaticBearerCreateParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsStaticBearerCreateParamsType Type { get; set; }

        /// <summary>
        /// Static bearer token value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// URL of the MCP server this credential authenticates against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsStaticBearerCreateParams" /> class.
        /// </summary>
        /// <param name="token">
        /// Static bearer token value.
        /// </param>
        /// <param name="mcpServerUrl">
        /// URL of the MCP server this credential authenticates against.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsStaticBearerCreateParams(
            string token,
            string mcpServerUrl,
            global::Anthropic.BetaManagedAgentsStaticBearerCreateParamsType type)
        {
            this.Type = type;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.McpServerUrl = mcpServerUrl ?? throw new global::System.ArgumentNullException(nameof(mcpServerUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsStaticBearerCreateParams" /> class.
        /// </summary>
        public BetaManagedAgentsStaticBearerCreateParams()
        {
        }
    }
}