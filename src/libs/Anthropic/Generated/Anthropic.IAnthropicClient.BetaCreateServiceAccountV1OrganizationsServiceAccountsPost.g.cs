#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Service Account<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Create a service account.<br/>
        /// A service account is a named workload identity that federation rules<br/>
        /// target. `organization_role` is `developer` (default) or `admin`; a rule<br/>
        /// may only be created or retargeted to grant `org:admin` scope when the<br/>
        /// target's `organization_role` is `admin`. Creating an `admin`-role service<br/>
        /// account requires an interactive credential (a user OAuth token or a<br/>
        /// Console session) — a workload may only create `developer`-role service<br/>
        /// accounts.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaServiceAccount> BetaCreateServiceAccountV1OrganizationsServiceAccountsPostAsync(

            global::Anthropic.BetaServiceAccountCreateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Service Account<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Create a service account.<br/>
        /// A service account is a named workload identity that federation rules<br/>
        /// target. `organization_role` is `developer` (default) or `admin`; a rule<br/>
        /// may only be created or retargeted to grant `org:admin` scope when the<br/>
        /// target's `organization_role` is `admin`. Creating an `admin`-role service<br/>
        /// account requires an interactive credential (a user OAuth token or a<br/>
        /// Console session) — a workload may only create `developer`-role service<br/>
        /// accounts.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaServiceAccount>> BetaCreateServiceAccountV1OrganizationsServiceAccountsPostAsResponseAsync(

            global::Anthropic.BetaServiceAccountCreateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Service Account<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Create a service account.<br/>
        /// A service account is a named workload identity that federation rules<br/>
        /// target. `organization_role` is `developer` (default) or `admin`; a rule<br/>
        /// may only be created or retargeted to grant `org:admin` scope when the<br/>
        /// target's `organization_role` is `admin`. Creating an `admin`-role service<br/>
        /// account requires an interactive credential (a user OAuth token or a<br/>
        /// Console session) — a workload may only create `developer`-role service<br/>
        /// accounts.
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="description">
        /// Optional free-text description.
        /// </param>
        /// <param name="name">
        /// Slug identifier (lowercase, digits, hyphens). Unique within the organization; a duplicate name returns 409.
        /// </param>
        /// <param name="organizationRole">
        /// Org-level role. Defaults to `developer`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaServiceAccount> BetaCreateServiceAccountV1OrganizationsServiceAccountsPostAsync(
            string name,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? description = default,
            global::Anthropic.BetaServiceAccountCreateParamsOrganizationRole? organizationRole = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}