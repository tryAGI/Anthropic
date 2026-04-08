
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthUpdateParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMcpOauthUpdateParamsType Type { get; set; }

        /// <summary>
        /// Updated OAuth access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// A timestamp in RFC 3339 format
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
        /// <param name="type"></param>
        /// <param name="accessToken">
        /// Updated OAuth access token.
        /// </param>
        /// <param name="expiresAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="refresh">
        /// Updated refresh token configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMcpOauthUpdateParams(
            global::Anthropic.BetaManagedAgentsMcpOauthUpdateParamsType type,
            string? accessToken,
            global::System.DateTime? expiresAt,
            global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParams? refresh)
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