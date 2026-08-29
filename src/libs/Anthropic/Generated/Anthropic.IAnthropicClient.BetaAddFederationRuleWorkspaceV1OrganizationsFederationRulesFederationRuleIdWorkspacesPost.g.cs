#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Add Federation Rule Workspace<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Enable a federation rule for a workspace.<br/>
        /// Idempotent; re-enabling returns the existing enablement. The rule and<br/>
        /// workspace must both belong to your organization. Membership of the<br/>
        /// rule's target service account in this workspace is not checked at<br/>
        /// enablement: token exchange into this workspace is rejected unless the<br/>
        /// target is a member (it is implicitly a member of the default workspace).<br/>
        /// Archived rules are rejected with 400. OAuth callers may only manage rules<br/>
        /// whose `oauth_scope` is `workspace:developer` or `workspace:inference`;<br/>
        /// other scopes require a Console session.
        /// </summary>
        /// <param name="federationRuleId">
        /// ID of the federation rule.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFederationRuleWorkspace> BetaAddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostAsync(
            string federationRuleId,

            global::Anthropic.BetaAddFederationRuleWorkspaceParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Federation Rule Workspace<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Enable a federation rule for a workspace.<br/>
        /// Idempotent; re-enabling returns the existing enablement. The rule and<br/>
        /// workspace must both belong to your organization. Membership of the<br/>
        /// rule's target service account in this workspace is not checked at<br/>
        /// enablement: token exchange into this workspace is rejected unless the<br/>
        /// target is a member (it is implicitly a member of the default workspace).<br/>
        /// Archived rules are rejected with 400. OAuth callers may only manage rules<br/>
        /// whose `oauth_scope` is `workspace:developer` or `workspace:inference`;<br/>
        /// other scopes require a Console session.
        /// </summary>
        /// <param name="federationRuleId">
        /// ID of the federation rule.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaFederationRuleWorkspace>> BetaAddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostAsResponseAsync(
            string federationRuleId,

            global::Anthropic.BetaAddFederationRuleWorkspaceParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Federation Rule Workspace<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Enable a federation rule for a workspace.<br/>
        /// Idempotent; re-enabling returns the existing enablement. The rule and<br/>
        /// workspace must both belong to your organization. Membership of the<br/>
        /// rule's target service account in this workspace is not checked at<br/>
        /// enablement: token exchange into this workspace is rejected unless the<br/>
        /// target is a member (it is implicitly a member of the default workspace).<br/>
        /// Archived rules are rejected with 400. OAuth callers may only manage rules<br/>
        /// whose `oauth_scope` is `workspace:developer` or `workspace:inference`;<br/>
        /// other scopes require a Console session.
        /// </summary>
        /// <param name="federationRuleId">
        /// ID of the federation rule.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="workspaceId">
        /// Tagged ID of the workspace to enable this rule for.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFederationRuleWorkspace> BetaAddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostAsync(
            string federationRuleId,
            string workspaceId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}