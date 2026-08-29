#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Federation Rule<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Partially update a federation rule.<br/>
        /// `issuer_id` is immutable. `match` and `target` are replaced as whole<br/>
        /// objects when set. Referenced service accounts and workspaces must exist<br/>
        /// in your organization; invalid references are rejected with a 400 error.<br/>
        /// Archived rules cannot be updated; this returns 400. Create a new rule<br/>
        /// instead. Rules on well-known shared issuers (GitHub Actions, GitLab,<br/>
        /// Buildkite, Terraform Cloud, Google) must constrain tenant identity via<br/>
        /// an identity-bearing claim, a tenant-pinning subject prefix (such as<br/>
        /// `repo:YOUR_ORG/...`), or a CEL condition referencing one of those<br/>
        /// identity claims (e.g. `claims.repository_owner`). On these issuers the<br/>
        /// requirement is re-checked on every update; if an existing rule's stored<br/>
        /// match does not yet constrain tenant identity, any update (even a rename<br/>
        /// or description change) must also supply a conforming `match` in the same<br/>
        /// request. OAuth callers may only manage rules whose `oauth_scope` is<br/>
        /// `workspace:developer` or `workspace:inference`; other scopes require a<br/>
        /// Console session.
        /// </summary>
        /// <param name="federationRuleId">
        /// ID of the federation rule to update.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFederationRule> BetaUpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostAsync(
            string federationRuleId,

            global::Anthropic.BetaFederationRuleUpdateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Federation Rule<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Partially update a federation rule.<br/>
        /// `issuer_id` is immutable. `match` and `target` are replaced as whole<br/>
        /// objects when set. Referenced service accounts and workspaces must exist<br/>
        /// in your organization; invalid references are rejected with a 400 error.<br/>
        /// Archived rules cannot be updated; this returns 400. Create a new rule<br/>
        /// instead. Rules on well-known shared issuers (GitHub Actions, GitLab,<br/>
        /// Buildkite, Terraform Cloud, Google) must constrain tenant identity via<br/>
        /// an identity-bearing claim, a tenant-pinning subject prefix (such as<br/>
        /// `repo:YOUR_ORG/...`), or a CEL condition referencing one of those<br/>
        /// identity claims (e.g. `claims.repository_owner`). On these issuers the<br/>
        /// requirement is re-checked on every update; if an existing rule's stored<br/>
        /// match does not yet constrain tenant identity, any update (even a rename<br/>
        /// or description change) must also supply a conforming `match` in the same<br/>
        /// request. OAuth callers may only manage rules whose `oauth_scope` is<br/>
        /// `workspace:developer` or `workspace:inference`; other scopes require a<br/>
        /// Console session.
        /// </summary>
        /// <param name="federationRuleId">
        /// ID of the federation rule to update.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaFederationRule>> BetaUpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostAsResponseAsync(
            string federationRuleId,

            global::Anthropic.BetaFederationRuleUpdateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Federation Rule<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Partially update a federation rule.<br/>
        /// `issuer_id` is immutable. `match` and `target` are replaced as whole<br/>
        /// objects when set. Referenced service accounts and workspaces must exist<br/>
        /// in your organization; invalid references are rejected with a 400 error.<br/>
        /// Archived rules cannot be updated; this returns 400. Create a new rule<br/>
        /// instead. Rules on well-known shared issuers (GitHub Actions, GitLab,<br/>
        /// Buildkite, Terraform Cloud, Google) must constrain tenant identity via<br/>
        /// an identity-bearing claim, a tenant-pinning subject prefix (such as<br/>
        /// `repo:YOUR_ORG/...`), or a CEL condition referencing one of those<br/>
        /// identity claims (e.g. `claims.repository_owner`). On these issuers the<br/>
        /// requirement is re-checked on every update; if an existing rule's stored<br/>
        /// match does not yet constrain tenant identity, any update (even a rename<br/>
        /// or description change) must also supply a conforming `match` in the same<br/>
        /// request. OAuth callers may only manage rules whose `oauth_scope` is<br/>
        /// `workspace:developer` or `workspace:inference`; other scopes require a<br/>
        /// Console session.
        /// </summary>
        /// <param name="federationRuleId">
        /// ID of the federation rule to update.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFederationRule> BetaUpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostAsync(
            string federationRuleId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            bool? appliesToAllWorkspaces = default,
            global::System.Collections.Generic.Dictionary<string, string>? attributes = default,
            string? description = default,
            global::Anthropic.BetaRuleMatch? match = default,
            string? name = default,
            string? oauthScope = default,
            global::Anthropic.BetaServiceAccountTarget? target = default,
            int? tokenLifetimeSeconds = default,
            string? workspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}