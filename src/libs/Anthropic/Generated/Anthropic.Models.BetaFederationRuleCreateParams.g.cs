
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaFederationRuleCreateParams
    {
        /// <summary>
        /// When true, enable this rule for every workspace in the org (including workspaces created later).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applies_to_all_workspaces")]
        public bool? AppliesToAllWorkspaces { get; set; }

        /// <summary>
        /// CEL expressions `{name: expr}` extracting named values from claims. Not yet supported; any non-empty value is rejected with 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

        /// <summary>
        /// Optional free-text description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Tagged ID of the federation issuer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuerId { get; set; }

        /// <summary>
        /// Conditions the verified JWT must satisfy for this rule to apply. At least one of `subject_prefix` (other than a wildcard-only value like `*`), `claims`, or `condition` is required; `audience` alone is not sufficient.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaRuleMatch Match { get; set; }

        /// <summary>
        /// Slug identifier (lowercase, digits, hyphens). Unique within the organization; a duplicate name returns 409.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Space-separated OAuth scopes. OAuth callers may only set `workspace:developer` or `workspace:inference`; other scopes (such as `org:admin`) require a Console session.
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
        /// Lifetime in seconds for access tokens minted via this rule (60-86400). Defaults to 3600 (1h). Minted tokens are capped at `max(60, min(this value, 2 × remaining assertion validity))` seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_lifetime_seconds")]
        public int? TokenLifetimeSeconds { get; set; }

        /// <summary>
        /// Tagged ID of the workspace to enable this rule for. Required unless `applies_to_all_workspaces` is true. Additional workspaces can be added via the `/federation_rules/{federation_rule_id}/workspaces` sub-resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationRuleCreateParams" /> class.
        /// </summary>
        /// <param name="issuerId">
        /// Tagged ID of the federation issuer.
        /// </param>
        /// <param name="match">
        /// Conditions the verified JWT must satisfy for this rule to apply. At least one of `subject_prefix` (other than a wildcard-only value like `*`), `claims`, or `condition` is required; `audience` alone is not sufficient.
        /// </param>
        /// <param name="name">
        /// Slug identifier (lowercase, digits, hyphens). Unique within the organization; a duplicate name returns 409.
        /// </param>
        /// <param name="oauthScope">
        /// Space-separated OAuth scopes. OAuth callers may only set `workspace:developer` or `workspace:inference`; other scopes (such as `org:admin`) require a Console session.
        /// </param>
        /// <param name="target">
        /// Identity that tokens minted via this rule act as. Currently always a `service_account` target.
        /// </param>
        /// <param name="appliesToAllWorkspaces">
        /// When true, enable this rule for every workspace in the org (including workspaces created later).
        /// </param>
        /// <param name="attributes">
        /// CEL expressions `{name: expr}` extracting named values from claims. Not yet supported; any non-empty value is rejected with 400.
        /// </param>
        /// <param name="description">
        /// Optional free-text description.
        /// </param>
        /// <param name="tokenLifetimeSeconds">
        /// Lifetime in seconds for access tokens minted via this rule (60-86400). Defaults to 3600 (1h). Minted tokens are capped at `max(60, min(this value, 2 × remaining assertion validity))` seconds.
        /// </param>
        /// <param name="workspaceId">
        /// Tagged ID of the workspace to enable this rule for. Required unless `applies_to_all_workspaces` is true. Additional workspaces can be added via the `/federation_rules/{federation_rule_id}/workspaces` sub-resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFederationRuleCreateParams(
            string issuerId,
            global::Anthropic.BetaRuleMatch match,
            string name,
            string oauthScope,
            global::Anthropic.BetaServiceAccountTarget target,
            bool? appliesToAllWorkspaces,
            global::System.Collections.Generic.Dictionary<string, string>? attributes,
            string? description,
            int? tokenLifetimeSeconds,
            string? workspaceId)
        {
            this.AppliesToAllWorkspaces = appliesToAllWorkspaces;
            this.Attributes = attributes;
            this.Description = description;
            this.IssuerId = issuerId ?? throw new global::System.ArgumentNullException(nameof(issuerId));
            this.Match = match ?? throw new global::System.ArgumentNullException(nameof(match));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OauthScope = oauthScope ?? throw new global::System.ArgumentNullException(nameof(oauthScope));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.TokenLifetimeSeconds = tokenLifetimeSeconds;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationRuleCreateParams" /> class.
        /// </summary>
        public BetaFederationRuleCreateParams()
        {
        }

    }
}