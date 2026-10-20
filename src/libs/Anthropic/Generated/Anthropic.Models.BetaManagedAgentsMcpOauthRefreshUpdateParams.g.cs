
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Parameters for updating OAuth refresh token configuration.
    /// </summary>
    public sealed partial class BetaManagedAgentsMcpOauthRefreshUpdateParams
    {
        /// <summary>
        /// The new OAuth refresh token to replace the stored one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// The new OAuth scope for refresh requests. Send an empty string to clear the stored scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth? TokenEndpointAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpOauthRefreshUpdateParams" /> class.
        /// </summary>
        /// <param name="refreshToken">
        /// The new OAuth refresh token to replace the stored one.
        /// </param>
        /// <param name="scope">
        /// The new OAuth scope for refresh requests. Send an empty string to clear the stored scope.
        /// </param>
        /// <param name="tokenEndpointAuth"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMcpOauthRefreshUpdateParams(
            string? refreshToken,
            string? scope,
            global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth? tokenEndpointAuth)
        {
            this.RefreshToken = refreshToken;
            this.Scope = scope;
            this.TokenEndpointAuth = tokenEndpointAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpOauthRefreshUpdateParams" /> class.
        /// </summary>
        public BetaManagedAgentsMcpOauthRefreshUpdateParams()
        {
        }

    }
}