#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Federation Rule<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Create a federation rule owned by your organization.<br/>
        /// The referenced issuer and the target service account must already exist<br/>
        /// in the same organization; invalid references are rejected with a 400<br/>
        /// error. The workspace reference is validated. Membership is not checked<br/>
        /// at rule creation: token exchange resolves a single enabled workspace per<br/>
        /// call and is rejected unless the target service account is a member of<br/>
        /// that workspace (it is implicitly a member of the default workspace).<br/>
        /// Rules on well-known shared issuers (GitHub Actions, GitLab, Buildkite,<br/>
        /// Terraform Cloud, Google) must constrain tenant identity via an<br/>
        /// identity-bearing claim, a tenant-pinning subject prefix (such as<br/>
        /// `repo:YOUR_ORG/...`), or a CEL condition referencing one of those<br/>
        /// identity claims (e.g. `claims.repository_owner`). OAuth callers may only<br/>
        /// manage rules whose `oauth_scope` is `workspace:developer` or<br/>
        /// `workspace:inference`; other scopes require a Console session.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFederationRule> BetaCreateFederationRuleV1OrganizationsFederationRulesPostAsync(

            global::Anthropic.BetaFederationRuleCreateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Federation Rule<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Create a federation rule owned by your organization.<br/>
        /// The referenced issuer and the target service account must already exist<br/>
        /// in the same organization; invalid references are rejected with a 400<br/>
        /// error. The workspace reference is validated. Membership is not checked<br/>
        /// at rule creation: token exchange resolves a single enabled workspace per<br/>
        /// call and is rejected unless the target service account is a member of<br/>
        /// that workspace (it is implicitly a member of the default workspace).<br/>
        /// Rules on well-known shared issuers (GitHub Actions, GitLab, Buildkite,<br/>
        /// Terraform Cloud, Google) must constrain tenant identity via an<br/>
        /// identity-bearing claim, a tenant-pinning subject prefix (such as<br/>
        /// `repo:YOUR_ORG/...`), or a CEL condition referencing one of those<br/>
        /// identity claims (e.g. `claims.repository_owner`). OAuth callers may only<br/>
        /// manage rules whose `oauth_scope` is `workspace:developer` or<br/>
        /// `workspace:inference`; other scopes require a Console session.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaFederationRule>> BetaCreateFederationRuleV1OrganizationsFederationRulesPostAsResponseAsync(

            global::Anthropic.BetaFederationRuleCreateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Federation Rule<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Create a federation rule owned by your organization.<br/>
        /// The referenced issuer and the target service account must already exist<br/>
        /// in the same organization; invalid references are rejected with a 400<br/>
        /// error. The workspace reference is validated. Membership is not checked<br/>
        /// at rule creation: token exchange resolves a single enabled workspace per<br/>
        /// call and is rejected unless the target service account is a member of<br/>
        /// that workspace (it is implicitly a member of the default workspace).<br/>
        /// Rules on well-known shared issuers (GitHub Actions, GitLab, Buildkite,<br/>
        /// Terraform Cloud, Google) must constrain tenant identity via an<br/>
        /// identity-bearing claim, a tenant-pinning subject prefix (such as<br/>
        /// `repo:YOUR_ORG/...`), or a CEL condition referencing one of those<br/>
        /// identity claims (e.g. `claims.repository_owner`). OAuth callers may only<br/>
        /// manage rules whose `oauth_scope` is `workspace:developer` or<br/>
        /// `workspace:inference`; other scopes require a Console session.
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
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
        /// <param name="tokenLifetimeSeconds">
        /// Lifetime in seconds for access tokens minted via this rule (60-86400). Defaults to 3600 (1h). Minted tokens are capped at `max(60, min(this value, 2 × remaining assertion validity))` seconds.
        /// </param>
        /// <param name="workspaceId">
        /// Tagged ID of the workspace to enable this rule for. Required unless `applies_to_all_workspaces` is true. Additional workspaces can be added via the `/federation_rules/{federation_rule_id}/workspaces` sub-resource.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFederationRule> BetaCreateFederationRuleV1OrganizationsFederationRulesPostAsync(
            string issuerId,
            global::Anthropic.BetaRuleMatch match,
            string name,
            string oauthScope,
            global::Anthropic.BetaServiceAccountTarget target,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            bool? appliesToAllWorkspaces = default,
            global::System.Collections.Generic.Dictionary<string, string>? attributes = default,
            string? description = default,
            int? tokenLifetimeSeconds = default,
            string? workspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}