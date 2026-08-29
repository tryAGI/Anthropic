
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// JWKS via the issuer's OIDC discovery document.
    /// </summary>
    public sealed partial class BetaJwksDiscovery
    {
        /// <summary>
        /// Optional custom CA (PEM) for TLS verification of the JWKS fetch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ca_cert_pem")]
        public string? CaCertPem { get; set; }

        /// <summary>
        /// Set when the discovery URL differs from `issuer_url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discovery_base")]
        public string? DiscoveryBase { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"discovery"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "discovery";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaJwksDiscovery" /> class.
        /// </summary>
        /// <param name="caCertPem">
        /// Optional custom CA (PEM) for TLS verification of the JWKS fetch.
        /// </param>
        /// <param name="discoveryBase">
        /// Set when the discovery URL differs from `issuer_url`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaJwksDiscovery(
            string? caCertPem,
            string? discoveryBase,
            string type = "discovery")
        {
            this.CaCertPem = caCertPem;
            this.DiscoveryBase = discoveryBase;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaJwksDiscovery" /> class.
        /// </summary>
        public BetaJwksDiscovery()
        {
        }

    }
}