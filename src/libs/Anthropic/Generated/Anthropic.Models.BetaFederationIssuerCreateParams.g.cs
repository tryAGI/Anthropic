
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaFederationIssuerCreateParams
    {
        /// <summary>
        /// Whether the jwt-bearer exchange enforces JTI single-use (replay protection) for tokens from this issuer. Defaults to true. Applies only to assertions carrying a `jti` claim; tokens without one are accepted without single-use enforcement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_jti")]
        public bool? CheckJti { get; set; }

        /// <summary>
        /// The `iss` claim value to match against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuerUrl { get; set; }

        /// <summary>
        /// How signing keys are obtained. Defaults to OIDC discovery.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Jwks2JsonConverter))]
        public global::Anthropic.Jwks2? Jwks { get; set; }

        /// <summary>
        /// Maximum allowed iat→exp spread for assertions from this issuer (1-176400 seconds, i.e. up to 49h). Defaults to 3600 (1h). Assertions must carry both `iat` and `exp`; a missing `iat` is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_jwt_lifetime_seconds")]
        public int? MaxJwtLifetimeSeconds { get; set; }

        /// <summary>
        /// Slug identifier (lowercase, digits, hyphens). Unique within the organization; a duplicate name returns 409.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationIssuerCreateParams" /> class.
        /// </summary>
        /// <param name="issuerUrl">
        /// The `iss` claim value to match against.
        /// </param>
        /// <param name="name">
        /// Slug identifier (lowercase, digits, hyphens). Unique within the organization; a duplicate name returns 409.
        /// </param>
        /// <param name="checkJti">
        /// Whether the jwt-bearer exchange enforces JTI single-use (replay protection) for tokens from this issuer. Defaults to true. Applies only to assertions carrying a `jti` claim; tokens without one are accepted without single-use enforcement.
        /// </param>
        /// <param name="jwks">
        /// How signing keys are obtained. Defaults to OIDC discovery.
        /// </param>
        /// <param name="maxJwtLifetimeSeconds">
        /// Maximum allowed iat→exp spread for assertions from this issuer (1-176400 seconds, i.e. up to 49h). Defaults to 3600 (1h). Assertions must carry both `iat` and `exp`; a missing `iat` is rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFederationIssuerCreateParams(
            string issuerUrl,
            string name,
            bool? checkJti,
            global::Anthropic.Jwks2? jwks,
            int? maxJwtLifetimeSeconds)
        {
            this.CheckJti = checkJti;
            this.IssuerUrl = issuerUrl ?? throw new global::System.ArgumentNullException(nameof(issuerUrl));
            this.Jwks = jwks;
            this.MaxJwtLifetimeSeconds = maxJwtLifetimeSeconds;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationIssuerCreateParams" /> class.
        /// </summary>
        public BetaFederationIssuerCreateParams()
        {
        }

    }
}