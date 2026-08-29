
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Authorization rule binding an external OIDC identity to Anthropic.<br/>
    /// Evaluates the match conditions and mints an OAuth access token for the<br/>
    /// resolved target, scoped to a single workspace where the rule is enabled<br/>
    /// (chosen by the caller at exchange time when the rule is enabled for more<br/>
    /// than one). For rules enabled via `workspace_ids` or<br/>
    /// `applies_to_all_workspaces`, the target service account must be a member<br/>
    /// of that workspace (it is implicitly a member of the default workspace);<br/>
    /// rules carrying only the legacy `workspace_id` binding do not enforce<br/>
    /// this.
    /// </summary>
    public sealed partial class BetaFederationRule
    {
        /// <summary>
        /// When true, this rule is enabled for every workspace in the org (including ones created after the rule). `workspace_ids` is ignored at exchange time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applies_to_all_workspaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AppliesToAllWorkspaces { get; set; }

        /// <summary>
        /// If set, this rule is archived and rejects token exchange.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Tagged ID (`user_`/`svac_`) of the actor that archived this rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_by_actor_id")]
        public string? ArchivedByActorId { get; set; }

        /// <summary>
        /// CEL expressions extracting named values from claims. Not yet supported; always null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

        /// <summary>
        /// When this rule was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Tagged ID (`user_`/`svac_`) of the actor that created this rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_actor_id")]
        public string? CreatedByActorId { get; set; }

        /// <summary>
        /// Optional free-text description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Tagged ID of the federation rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Tagged ID of the issuer whose tokens this rule accepts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuerId { get; set; }

        /// <summary>
        /// Issuer's display name at read time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_name")]
        public string? IssuerName { get; set; }

        /// <summary>
        /// Conditions the verified JWT must satisfy for this rule to apply. All populated matcher fields must pass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaRuleMatch Match { get; set; }

        /// <summary>
        /// Admin-chosen slug identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Space-separated OAuth scopes granted on the minted token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OauthScope { get; set; }

        /// <summary>
        /// Identity that tokens minted via this rule act as. Currently always a `service_account` target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaServiceAccountTarget Target { get; set; }

        /// <summary>
        /// Lifetime in seconds of access tokens minted via this rule. Minted tokens are capped at `max(60, min(this value, 2 × remaining assertion validity))` seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_lifetime_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TokenLifetimeSeconds { get; set; }

        /// <summary>
        /// Default Value: federation_rule
        /// </summary>
        /// <default>"federation_rule"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "federation_rule";

        /// <summary>
        /// When this rule was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Tagged ID (`user_`/`svac_`) of the actor that last updated this rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by_actor_id")]
        public string? UpdatedByActorId { get; set; }

        /// <summary>
        /// Legacy single-workspace binding. Prefer `workspace_ids` and the `/federation_rules/{federation_rule_id}/workspaces` sub-resource for managing workspace enablement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Tagged IDs of the workspaces this rule is enabled for. May be empty for older rules that only carry the legacy `workspace_id` binding. Ignored at exchange time when `applies_to_all_workspaces` is true (the list may still be non-empty).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> WorkspaceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationRule" /> class.
        /// </summary>
        /// <param name="appliesToAllWorkspaces">
        /// When true, this rule is enabled for every workspace in the org (including ones created after the rule). `workspace_ids` is ignored at exchange time.
        /// </param>
        /// <param name="createdAt">
        /// When this rule was created.
        /// </param>
        /// <param name="id">
        /// Tagged ID of the federation rule.
        /// </param>
        /// <param name="issuerId">
        /// Tagged ID of the issuer whose tokens this rule accepts.
        /// </param>
        /// <param name="match">
        /// Conditions the verified JWT must satisfy for this rule to apply. All populated matcher fields must pass.
        /// </param>
        /// <param name="name">
        /// Admin-chosen slug identifier.
        /// </param>
        /// <param name="oauthScope">
        /// Space-separated OAuth scopes granted on the minted token.
        /// </param>
        /// <param name="target">
        /// Identity that tokens minted via this rule act as. Currently always a `service_account` target.
        /// </param>
        /// <param name="tokenLifetimeSeconds">
        /// Lifetime in seconds of access tokens minted via this rule. Minted tokens are capped at `max(60, min(this value, 2 × remaining assertion validity))` seconds.
        /// </param>
        /// <param name="updatedAt">
        /// When this rule was last updated.
        /// </param>
        /// <param name="workspaceIds">
        /// Tagged IDs of the workspaces this rule is enabled for. May be empty for older rules that only carry the legacy `workspace_id` binding. Ignored at exchange time when `applies_to_all_workspaces` is true (the list may still be non-empty).
        /// </param>
        /// <param name="archivedAt">
        /// If set, this rule is archived and rejects token exchange.
        /// </param>
        /// <param name="archivedByActorId">
        /// Tagged ID (`user_`/`svac_`) of the actor that archived this rule.
        /// </param>
        /// <param name="attributes">
        /// CEL expressions extracting named values from claims. Not yet supported; always null.
        /// </param>
        /// <param name="createdByActorId">
        /// Tagged ID (`user_`/`svac_`) of the actor that created this rule.
        /// </param>
        /// <param name="description">
        /// Optional free-text description.
        /// </param>
        /// <param name="issuerName">
        /// Issuer's display name at read time.
        /// </param>
        /// <param name="updatedByActorId">
        /// Tagged ID (`user_`/`svac_`) of the actor that last updated this rule.
        /// </param>
        /// <param name="workspaceId">
        /// Legacy single-workspace binding. Prefer `workspace_ids` and the `/federation_rules/{federation_rule_id}/workspaces` sub-resource for managing workspace enablement.
        /// </param>
        /// <param name="type">
        /// Default Value: federation_rule
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFederationRule(
            bool appliesToAllWorkspaces,
            global::System.DateTime createdAt,
            string id,
            string issuerId,
            global::Anthropic.BetaRuleMatch match,
            string name,
            string oauthScope,
            global::Anthropic.BetaServiceAccountTarget target,
            int tokenLifetimeSeconds,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<string> workspaceIds,
            global::System.DateTime? archivedAt,
            string? archivedByActorId,
            global::System.Collections.Generic.Dictionary<string, string>? attributes,
            string? createdByActorId,
            string? description,
            string? issuerName,
            string? updatedByActorId,
            string? workspaceId,
            string type = "federation_rule")
        {
            this.AppliesToAllWorkspaces = appliesToAllWorkspaces;
            this.ArchivedAt = archivedAt;
            this.ArchivedByActorId = archivedByActorId;
            this.Attributes = attributes;
            this.CreatedAt = createdAt;
            this.CreatedByActorId = createdByActorId;
            this.Description = description;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IssuerId = issuerId ?? throw new global::System.ArgumentNullException(nameof(issuerId));
            this.IssuerName = issuerName;
            this.Match = match ?? throw new global::System.ArgumentNullException(nameof(match));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OauthScope = oauthScope ?? throw new global::System.ArgumentNullException(nameof(oauthScope));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.TokenLifetimeSeconds = tokenLifetimeSeconds;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.UpdatedByActorId = updatedByActorId;
            this.WorkspaceId = workspaceId;
            this.WorkspaceIds = workspaceIds ?? throw new global::System.ArgumentNullException(nameof(workspaceIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationRule" /> class.
        /// </summary>
        public BetaFederationRule()
        {
        }

    }
}