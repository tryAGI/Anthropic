
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A tunnel's connector token.
    /// </summary>
    public sealed partial class BetaTunnelToken
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"tunnel_token"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tunnel_token";

        /// <summary>
        /// Stable identifier for the current token value. Changes when the token is rotated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The connector token used to run the tunnel. Treat as a credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tunnel_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TunnelToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTunnelToken" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier for the current token value. Changes when the token is rotated.
        /// </param>
        /// <param name="tunnelToken">
        /// The connector token used to run the tunnel. Treat as a credential.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTunnelToken(
            string id,
            string tunnelToken,
            string type = "tunnel_token")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TunnelToken = tunnelToken ?? throw new global::System.ArgumentNullException(nameof(tunnelToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTunnelToken" /> class.
        /// </summary>
        public BetaTunnelToken()
        {
        }

    }
}