
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Registered external OIDC identity provider.<br/>
    /// Records an external IdP the organization trusts for the RFC 7523<br/>
    /// jwt-bearer grant. The `issuer_url` must match the JWT `iss` claim exactly.
    /// </summary>
    public sealed partial class BetaFederationIssuer
    {
        /// <summary>
        /// If set, all rules referencing this issuer reject token exchange.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Tagged ID (`user_`/`svac_`) of the actor that archived this issuer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_by_actor_id")]
        public string? ArchivedByActorId { get; set; }

        /// <summary>
        /// Whether the jwt-bearer exchange enforces JTI single-use (replay protection) for tokens from this issuer. Applies only to assertions carrying a `jti` claim; tokens without one are accepted without single-use enforcement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_jti")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CheckJti { get; set; }

        /// <summary>
        /// When this issuer was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Tagged ID (`user_`/`svac_`) of the actor that created this issuer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_actor_id")]
        public string? CreatedByActorId { get; set; }

        /// <summary>
        /// Tagged ID of the federation issuer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The `iss` claim value. Incoming JWTs must match exactly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuerUrl { get; set; }

        /// <summary>
        /// How signing keys are obtained for signature verification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.JwksJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Jwks Jwks { get; set; }

        /// <summary>
        /// If set, Anthropic's JWKS poller has paused polling for this issuer after repeated fetch failures. Re-enable by sending `jwks_polling_disabled: false` via the issuer update endpoint (POST) once the upstream JWKS endpoint is fixed. An OAuth caller cannot send this when the issuer backs a rule with any scope other than `workspace:developer` or `workspace:inference`; use a Console session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_polling_disabled_at")]
        public global::System.DateTime? JwksPollingDisabledAt { get; set; }

        /// <summary>
        /// Maximum allowed iat→exp spread for assertions from this issuer (1-176400 seconds, i.e. up to 49h). Assertions must carry both `iat` and `exp`; a missing `iat` is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_jwt_lifetime_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxJwtLifetimeSeconds { get; set; }

        /// <summary>
        /// Admin-chosen slug identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Live state of Anthropic's JWKS polling for this issuer. Populated on both single-issuer retrieval and list responses, including archived issuers. Typically null for inline-key issuers (no polling), or when poll status is temporarily unavailable or polling has not started yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poll_status")]
        public global::Anthropic.BetaIssuerPollStatus? PollStatus { get; set; }

        /// <summary>
        /// Default Value: federation_issuer
        /// </summary>
        /// <default>"federation_issuer"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "federation_issuer";

        /// <summary>
        /// When this issuer was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Tagged ID (`user_`/`svac_`) of the actor that last updated this issuer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by_actor_id")]
        public string? UpdatedByActorId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationIssuer" /> class.
        /// </summary>
        /// <param name="checkJti">
        /// Whether the jwt-bearer exchange enforces JTI single-use (replay protection) for tokens from this issuer. Applies only to assertions carrying a `jti` claim; tokens without one are accepted without single-use enforcement.
        /// </param>
        /// <param name="createdAt">
        /// When this issuer was created.
        /// </param>
        /// <param name="id">
        /// Tagged ID of the federation issuer.
        /// </param>
        /// <param name="issuerUrl">
        /// The `iss` claim value. Incoming JWTs must match exactly.
        /// </param>
        /// <param name="jwks">
        /// How signing keys are obtained for signature verification.
        /// </param>
        /// <param name="maxJwtLifetimeSeconds">
        /// Maximum allowed iat→exp spread for assertions from this issuer (1-176400 seconds, i.e. up to 49h). Assertions must carry both `iat` and `exp`; a missing `iat` is rejected.
        /// </param>
        /// <param name="name">
        /// Admin-chosen slug identifier.
        /// </param>
        /// <param name="updatedAt">
        /// When this issuer was last updated.
        /// </param>
        /// <param name="archivedAt">
        /// If set, all rules referencing this issuer reject token exchange.
        /// </param>
        /// <param name="archivedByActorId">
        /// Tagged ID (`user_`/`svac_`) of the actor that archived this issuer.
        /// </param>
        /// <param name="createdByActorId">
        /// Tagged ID (`user_`/`svac_`) of the actor that created this issuer.
        /// </param>
        /// <param name="jwksPollingDisabledAt">
        /// If set, Anthropic's JWKS poller has paused polling for this issuer after repeated fetch failures. Re-enable by sending `jwks_polling_disabled: false` via the issuer update endpoint (POST) once the upstream JWKS endpoint is fixed. An OAuth caller cannot send this when the issuer backs a rule with any scope other than `workspace:developer` or `workspace:inference`; use a Console session.
        /// </param>
        /// <param name="pollStatus">
        /// Live state of Anthropic's JWKS polling for this issuer. Populated on both single-issuer retrieval and list responses, including archived issuers. Typically null for inline-key issuers (no polling), or when poll status is temporarily unavailable or polling has not started yet.
        /// </param>
        /// <param name="updatedByActorId">
        /// Tagged ID (`user_`/`svac_`) of the actor that last updated this issuer.
        /// </param>
        /// <param name="type">
        /// Default Value: federation_issuer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFederationIssuer(
            bool checkJti,
            global::System.DateTime createdAt,
            string id,
            string issuerUrl,
            global::Anthropic.Jwks jwks,
            int maxJwtLifetimeSeconds,
            string name,
            global::System.DateTime updatedAt,
            global::System.DateTime? archivedAt,
            string? archivedByActorId,
            string? createdByActorId,
            global::System.DateTime? jwksPollingDisabledAt,
            global::Anthropic.BetaIssuerPollStatus? pollStatus,
            string? updatedByActorId,
            string type = "federation_issuer")
        {
            this.ArchivedAt = archivedAt;
            this.ArchivedByActorId = archivedByActorId;
            this.CheckJti = checkJti;
            this.CreatedAt = createdAt;
            this.CreatedByActorId = createdByActorId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IssuerUrl = issuerUrl ?? throw new global::System.ArgumentNullException(nameof(issuerUrl));
            this.Jwks = jwks;
            this.JwksPollingDisabledAt = jwksPollingDisabledAt;
            this.MaxJwtLifetimeSeconds = maxJwtLifetimeSeconds;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PollStatus = pollStatus;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.UpdatedByActorId = updatedByActorId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationIssuer" /> class.
        /// </summary>
        public BetaFederationIssuer()
        {
        }

    }
}