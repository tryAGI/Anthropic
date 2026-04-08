
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// OAuth refresh token parameters for creating a credential with refresh support.
    /// </summary>
    public sealed partial class BetaManagedAgentsMcpOauthRefreshParams
    {
        /// <summary>
        /// OAuth refresh token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RefreshToken { get; set; }

        /// <summary>
        /// Token endpoint URL used to refresh the access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenEndpoint { get; set; }

        /// <summary>
        /// OAuth client ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// OAuth scope for the refresh request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// OAuth resource indicator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth TokenEndpointAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpOauthRefreshParams" /> class.
        /// </summary>
        /// <param name="refreshToken">
        /// OAuth refresh token.
        /// </param>
        /// <param name="tokenEndpoint">
        /// Token endpoint URL used to refresh the access token.
        /// </param>
        /// <param name="clientId">
        /// OAuth client ID.
        /// </param>
        /// <param name="tokenEndpointAuth"></param>
        /// <param name="scope">
        /// OAuth scope for the refresh request.
        /// </param>
        /// <param name="resource">
        /// OAuth resource indicator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMcpOauthRefreshParams(
            string refreshToken,
            string tokenEndpoint,
            string clientId,
            global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth tokenEndpointAuth,
            string? scope,
            string? resource)
        {
            this.RefreshToken = refreshToken ?? throw new global::System.ArgumentNullException(nameof(refreshToken));
            this.TokenEndpoint = tokenEndpoint ?? throw new global::System.ArgumentNullException(nameof(tokenEndpoint));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.Scope = scope;
            this.Resource = resource;
            this.TokenEndpointAuth = tokenEndpointAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpOauthRefreshParams" /> class.
        /// </summary>
        public BetaManagedAgentsMcpOauthRefreshParams()
        {
        }
    }
}