
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Parameters for updating an MCP OAuth credential. The `mcp_server_url` is immutable.
    /// </summary>
    public sealed partial class BetaManagedAgentsMcpOauthUpdateParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"mcp_oauth"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "mcp_oauth";

        /// <summary>
        /// The new OAuth access token to replace the stored one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// When the credential's access token expires, in RFC 3339. Leave it out to keep the stored expiry.<br/>
        /// If you send a new `access_token`, send its `expires_at` too, or the new token keeps the old expiry.<br/>
        /// Must be in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Updated refresh token configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh")]
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParams? Refresh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpOauthUpdateParams" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// The new OAuth access token to replace the stored one.
        /// </param>
        /// <param name="expiresAt">
        /// When the credential's access token expires, in RFC 3339. Leave it out to keep the stored expiry.<br/>
        /// If you send a new `access_token`, send its `expires_at` too, or the new token keeps the old expiry.<br/>
        /// Must be in the future.
        /// </param>
        /// <param name="refresh">
        /// Updated refresh token configuration.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMcpOauthUpdateParams(
            string? accessToken,
            global::System.DateTime? expiresAt,
            global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParams? refresh,
            string type = "mcp_oauth")
        {
            this.Type = type;
            this.AccessToken = accessToken;
            this.ExpiresAt = expiresAt;
            this.Refresh = refresh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpOauthUpdateParams" /> class.
        /// </summary>
        public BetaManagedAgentsMcpOauthUpdateParams()
        {
        }

    }
}