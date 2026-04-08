
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Parameters for creating an MCP OAuth credential.
    /// </summary>
    public sealed partial class BetaManagedAgentsMcpOauthCreateParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthCreateParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMcpOauthCreateParamsType Type { get; set; }

        /// <summary>
        /// URL of the MCP server this credential authenticates against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerUrl { get; set; }

        /// <summary>
        /// OAuth access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// A timestamp in RFC 3339 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Refresh token configuration, if the credential supports token refresh.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh")]
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParams? Refresh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpOauthCreateParams" /> class.
        /// </summary>
        /// <param name="mcpServerUrl">
        /// URL of the MCP server this credential authenticates against.
        /// </param>
        /// <param name="accessToken">
        /// OAuth access token.
        /// </param>
        /// <param name="type"></param>
        /// <param name="expiresAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="refresh">
        /// Refresh token configuration, if the credential supports token refresh.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMcpOauthCreateParams(
            string mcpServerUrl,
            string accessToken,
            global::Anthropic.BetaManagedAgentsMcpOauthCreateParamsType type,
            global::System.DateTime? expiresAt,
            global::Anthropic.BetaManagedAgentsMcpOauthRefreshParams? refresh)
        {
            this.Type = type;
            this.McpServerUrl = mcpServerUrl ?? throw new global::System.ArgumentNullException(nameof(mcpServerUrl));
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.ExpiresAt = expiresAt;
            this.Refresh = refresh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpOauthCreateParams" /> class.
        /// </summary>
        public BetaManagedAgentsMcpOauthCreateParams()
        {
        }
    }
}