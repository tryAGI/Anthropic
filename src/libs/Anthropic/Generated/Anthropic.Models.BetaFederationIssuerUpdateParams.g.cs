
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Partial update. Set fields are applied; omitted fields are unchanged.<br/>
    /// Setting `jwks` replaces the whole JWKS configuration at once.
    /// </summary>
    public sealed partial class BetaFederationIssuerUpdateParams
    {
        /// <summary>
        /// Whether the jwt-bearer exchange enforces JTI single-use (replay protection) for tokens from this issuer. Applies only to assertions carrying a `jti` claim; tokens without one are accepted without single-use enforcement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_jti")]
        public bool? CheckJti { get; set; }

        /// <summary>
        /// Replaces the `iss` claim value to match against. For discovery-mode issuers without a `discovery_base`, this is also the URL Anthropic fetches the OIDC discovery document and signing keys from, so changing it repoints the JWKS source. Changing the issuer URL to a well-known shared platform is rejected while any live rule under this issuer would not constrain tenant identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_url")]
        public string? IssuerUrl { get; set; }

        /// <summary>
        /// Replaces the entire JWKS configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks")]
        public global::Anthropic.JwksVariant1? Jwks { get; set; }

        /// <summary>
        /// Only `false` is accepted, to re-enable polling after the system pauses it. Polling is paused automatically; sending `true` is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_polling_disabled")]
        public bool? JwksPollingDisabled { get; set; }

        /// <summary>
        /// Maximum allowed iat→exp spread for assertions from this issuer (1-176400 seconds, i.e. up to 49h). Assertions must carry both `iat` and `exp`; a missing `iat` is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_jwt_lifetime_seconds")]
        public int? MaxJwtLifetimeSeconds { get; set; }

        /// <summary>
        /// Replaces the slug identifier (lowercase, digits, hyphens). Unique within the organization; a duplicate name returns 409.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationIssuerUpdateParams" /> class.
        /// </summary>
        /// <param name="checkJti">
        /// Whether the jwt-bearer exchange enforces JTI single-use (replay protection) for tokens from this issuer. Applies only to assertions carrying a `jti` claim; tokens without one are accepted without single-use enforcement.
        /// </param>
        /// <param name="issuerUrl">
        /// Replaces the `iss` claim value to match against. For discovery-mode issuers without a `discovery_base`, this is also the URL Anthropic fetches the OIDC discovery document and signing keys from, so changing it repoints the JWKS source. Changing the issuer URL to a well-known shared platform is rejected while any live rule under this issuer would not constrain tenant identity.
        /// </param>
        /// <param name="jwks">
        /// Replaces the entire JWKS configuration.
        /// </param>
        /// <param name="jwksPollingDisabled">
        /// Only `false` is accepted, to re-enable polling after the system pauses it. Polling is paused automatically; sending `true` is rejected.
        /// </param>
        /// <param name="maxJwtLifetimeSeconds">
        /// Maximum allowed iat→exp spread for assertions from this issuer (1-176400 seconds, i.e. up to 49h). Assertions must carry both `iat` and `exp`; a missing `iat` is rejected.
        /// </param>
        /// <param name="name">
        /// Replaces the slug identifier (lowercase, digits, hyphens). Unique within the organization; a duplicate name returns 409.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFederationIssuerUpdateParams(
            bool? checkJti,
            string? issuerUrl,
            global::Anthropic.JwksVariant1? jwks,
            bool? jwksPollingDisabled,
            int? maxJwtLifetimeSeconds,
            string? name)
        {
            this.CheckJti = checkJti;
            this.IssuerUrl = issuerUrl;
            this.Jwks = jwks;
            this.JwksPollingDisabled = jwksPollingDisabled;
            this.MaxJwtLifetimeSeconds = maxJwtLifetimeSeconds;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationIssuerUpdateParams" /> class.
        /// </summary>
        public BetaFederationIssuerUpdateParams()
        {
        }

    }
}