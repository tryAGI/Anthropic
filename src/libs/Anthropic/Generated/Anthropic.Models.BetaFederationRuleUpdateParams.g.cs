
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Partial update. Set fields are applied; omitted fields are unchanged.<br/>
    /// `issuer_id` is immutable. `match` and `target` are replaced as whole<br/>
    /// objects when set. Explicit `null` clears `description` and `attributes`;<br/>
    /// other fields can only be replaced, not cleared.
    /// </summary>
    public sealed partial class BetaFederationRuleUpdateParams
    {
        /// <summary>
        /// When true, enables this rule for every workspace in the org (including workspaces created later). Setting `false` is rejected with 400 if no workspace would remain enabled; a rule with only a legacy `workspace_id` binding continues to mint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applies_to_all_workspaces")]
        public bool? AppliesToAllWorkspaces { get; set; }

        /// <summary>
        /// Replaces the CEL expressions `{name: expr}` extracting named values from claims. Send null to clear them. Not yet supported; any non-empty value is rejected with 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

        /// <summary>
        /// Replaces the description. Omit to leave unchanged; send `null` to clear (the field is stored as an empty string).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Replaces the entire match object. All populated matcher fields must pass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        public global::Anthropic.BetaRuleMatch? Match { get; set; }

        /// <summary>
        /// Replaces the slug identifier (lowercase, digits, hyphens). Unique within the organization; a duplicate name returns 409.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Replaces the space-separated OAuth scopes granted on minted tokens. OAuth callers may only set `workspace:developer` or `workspace:inference`; other scopes (such as `org:admin`) require a Console session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_scope")]
        public string? OauthScope { get; set; }

        /// <summary>
        /// Replaces the entire target object. Currently always a `service_account` target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::Anthropic.BetaServiceAccountTarget? Target { get; set; }

        /// <summary>
        /// Replaces the lifetime in seconds for access tokens minted via this rule (60-86400). Minted tokens are capped at `max(60, min(this value, 2 × remaining assertion validity))` seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_lifetime_seconds")]
        public int? TokenLifetimeSeconds { get; set; }

        /// <summary>
        /// Replaces the existing single workspace enablement (the previous one is removed). Rejected with 400 if the rule is enabled for more than one workspace; use the `/federation_rules/{federation_rule_id}/workspaces` sub-resource instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationRuleUpdateParams" /> class.
        /// </summary>
        /// <param name="appliesToAllWorkspaces">
        /// When true, enables this rule for every workspace in the org (including workspaces created later). Setting `false` is rejected with 400 if no workspace would remain enabled; a rule with only a legacy `workspace_id` binding continues to mint.
        /// </param>
        /// <param name="attributes">
        /// Replaces the CEL expressions `{name: expr}` extracting named values from claims. Send null to clear them. Not yet supported; any non-empty value is rejected with 400.
        /// </param>
        /// <param name="description">
        /// Replaces the description. Omit to leave unchanged; send `null` to clear (the field is stored as an empty string).
        /// </param>
        /// <param name="match">
        /// Replaces the entire match object. All populated matcher fields must pass.
        /// </param>
        /// <param name="name">
        /// Replaces the slug identifier (lowercase, digits, hyphens). Unique within the organization; a duplicate name returns 409.
        /// </param>
        /// <param name="oauthScope">
        /// Replaces the space-separated OAuth scopes granted on minted tokens. OAuth callers may only set `workspace:developer` or `workspace:inference`; other scopes (such as `org:admin`) require a Console session.
        /// </param>
        /// <param name="target">
        /// Replaces the entire target object. Currently always a `service_account` target.
        /// </param>
        /// <param name="tokenLifetimeSeconds">
        /// Replaces the lifetime in seconds for access tokens minted via this rule (60-86400). Minted tokens are capped at `max(60, min(this value, 2 × remaining assertion validity))` seconds.
        /// </param>
        /// <param name="workspaceId">
        /// Replaces the existing single workspace enablement (the previous one is removed). Rejected with 400 if the rule is enabled for more than one workspace; use the `/federation_rules/{federation_rule_id}/workspaces` sub-resource instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFederationRuleUpdateParams(
            bool? appliesToAllWorkspaces,
            global::System.Collections.Generic.Dictionary<string, string>? attributes,
            string? description,
            global::Anthropic.BetaRuleMatch? match,
            string? name,
            string? oauthScope,
            global::Anthropic.BetaServiceAccountTarget? target,
            int? tokenLifetimeSeconds,
            string? workspaceId)
        {
            this.AppliesToAllWorkspaces = appliesToAllWorkspaces;
            this.Attributes = attributes;
            this.Description = description;
            this.Match = match;
            this.Name = name;
            this.OauthScope = oauthScope;
            this.Target = target;
            this.TokenLifetimeSeconds = tokenLifetimeSeconds;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationRuleUpdateParams" /> class.
        /// </summary>
        public BetaFederationRuleUpdateParams()
        {
        }

    }
}