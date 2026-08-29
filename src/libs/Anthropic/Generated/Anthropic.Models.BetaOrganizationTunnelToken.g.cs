
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaOrganizationTunnelToken
    {
        /// <summary>
        /// Stable identifier for the current token value. Changes when the token is<br/>
        /// rotated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The tunnel's connection token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tunnel_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TunnelToken { get; set; }

        /// <summary>
        /// Object type. Always `tunnel_token` for Tunnel Tokens.<br/>
        /// Default Value: tunnel_token
        /// </summary>
        /// <default>"tunnel_token"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tunnel_token";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationTunnelToken" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier for the current token value. Changes when the token is<br/>
        /// rotated.
        /// </param>
        /// <param name="tunnelToken">
        /// The tunnel's connection token.
        /// </param>
        /// <param name="type">
        /// Object type. Always `tunnel_token` for Tunnel Tokens.<br/>
        /// Default Value: tunnel_token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOrganizationTunnelToken(
            string id,
            string tunnelToken,
            string type = "tunnel_token")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TunnelToken = tunnelToken ?? throw new global::System.ArgumentNullException(nameof(tunnelToken));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationTunnelToken" /> class.
        /// </summary>
        public BetaOrganizationTunnelToken()
        {
        }

    }
}