
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// OAuth credential details for an MCP server.
    /// </summary>
    public sealed partial class BetaManagedAgentsMcpOauthAuthResponse
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"mcp_oauth"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "mcp_oauth";

        /// <summary>
        /// URL of the MCP server this credential authenticates against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerUrl { get; set; }

        /// <summary>
        /// When the credential's access token expires, in RFC 3339. Absent if the expiry isn't known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Refresh token configuration, if the credential supports token refresh.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh")]
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponse? Refresh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpOauthAuthResponse" /> class.
        /// </summary>
        /// <param name="mcpServerUrl">
        /// URL of the MCP server this credential authenticates against.
        /// </param>
        /// <param name="expiresAt">
        /// When the credential's access token expires, in RFC 3339. Absent if the expiry isn't known.
        /// </param>
        /// <param name="refresh">
        /// Refresh token configuration, if the credential supports token refresh.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMcpOauthAuthResponse(
            string mcpServerUrl,
            global::System.DateTime? expiresAt,
            global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponse? refresh,
            string type = "mcp_oauth")
        {
            this.Type = type;
            this.McpServerUrl = mcpServerUrl ?? throw new global::System.ArgumentNullException(nameof(mcpServerUrl));
            this.ExpiresAt = expiresAt;
            this.Refresh = refresh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpOauthAuthResponse" /> class.
        /// </summary>
        public BetaManagedAgentsMcpOauthAuthResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsMcpOauthAuthResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsMcpOauthAuthResponse FromMcpServerUrl(string mcpServerUrl)
        {
            return new BetaManagedAgentsMcpOauthAuthResponse
            {
                McpServerUrl = mcpServerUrl,
            };
        }

    }
}