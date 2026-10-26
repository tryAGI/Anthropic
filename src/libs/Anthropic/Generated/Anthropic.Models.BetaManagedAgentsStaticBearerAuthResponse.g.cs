
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Static bearer token credential details for an MCP server.<br/>
    /// Example: {"type":"static_bearer","mcp_server_url":"https://example-server.modelcontextprotocol.io/sse"}
    /// </summary>
    public sealed partial class BetaManagedAgentsStaticBearerAuthResponse
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"static_bearer"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "static_bearer";

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsStaticBearerAuthResponse" /> class.
        /// </summary>
        /// <param name="mcpServerUrl">
        /// URL of the MCP server this credential authenticates against.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsStaticBearerAuthResponse(
            string mcpServerUrl,
            string type = "static_bearer")
        {
            this.Type = type;
            this.McpServerUrl = mcpServerUrl ?? throw new global::System.ArgumentNullException(nameof(mcpServerUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsStaticBearerAuthResponse" /> class.
        /// </summary>
        public BetaManagedAgentsStaticBearerAuthResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsStaticBearerAuthResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsStaticBearerAuthResponse FromMcpServerUrl(string mcpServerUrl)
        {
            return new BetaManagedAgentsStaticBearerAuthResponse
            {
                McpServerUrl = mcpServerUrl,
            };
        }

    }
}