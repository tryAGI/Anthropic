#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Archive Federation Rule<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Archive a federation rule.<br/>
        /// Token exchange through this rule stops immediately. Idempotent;<br/>
        /// re-archiving returns the rule with its original `archived_at`. Archiving<br/>
        /// clears the rule's workspace targeting (`workspace_id` and<br/>
        /// `workspace_ids` are emptied). Tokens already minted before archive<br/>
        /// remain valid until they expire. OAuth callers may only manage rules<br/>
        /// whose `oauth_scope` is `workspace:developer` or `workspace:inference`;<br/>
        /// other scopes require a Console session.
        /// </summary>
        /// <param name="federationRuleId">
        /// ID of the federation rule to archive.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFederationRule> BetaArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostAsync(
            string federationRuleId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Archive Federation Rule<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Archive a federation rule.<br/>
        /// Token exchange through this rule stops immediately. Idempotent;<br/>
        /// re-archiving returns the rule with its original `archived_at`. Archiving<br/>
        /// clears the rule's workspace targeting (`workspace_id` and<br/>
        /// `workspace_ids` are emptied). Tokens already minted before archive<br/>
        /// remain valid until they expire. OAuth callers may only manage rules<br/>
        /// whose `oauth_scope` is `workspace:developer` or `workspace:inference`;<br/>
        /// other scopes require a Console session.
        /// </summary>
        /// <param name="federationRuleId">
        /// ID of the federation rule to archive.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaFederationRule>> BetaArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostAsResponseAsync(
            string federationRuleId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}