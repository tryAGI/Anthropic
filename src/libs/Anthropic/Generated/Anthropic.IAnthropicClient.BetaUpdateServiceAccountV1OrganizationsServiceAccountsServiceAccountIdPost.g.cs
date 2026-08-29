#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Service Account<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Update a service account.<br/>
        /// Only `description` and `organization_role` are mutable; `name` cannot be<br/>
        /// changed. Archived service accounts cannot be updated; this returns 400.<br/>
        /// Setting `organization_role` to `admin` (even when unchanged) requires an<br/>
        /// interactive credential (a user OAuth token or a Console session).
        /// </summary>
        /// <param name="serviceAccountId">
        /// ID of the service account to update.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaServiceAccount> BetaUpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostAsync(
            string serviceAccountId,

            global::Anthropic.BetaServiceAccountUpdateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Service Account<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Update a service account.<br/>
        /// Only `description` and `organization_role` are mutable; `name` cannot be<br/>
        /// changed. Archived service accounts cannot be updated; this returns 400.<br/>
        /// Setting `organization_role` to `admin` (even when unchanged) requires an<br/>
        /// interactive credential (a user OAuth token or a Console session).
        /// </summary>
        /// <param name="serviceAccountId">
        /// ID of the service account to update.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaServiceAccount>> BetaUpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostAsResponseAsync(
            string serviceAccountId,

            global::Anthropic.BetaServiceAccountUpdateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Service Account<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Update a service account.<br/>
        /// Only `description` and `organization_role` are mutable; `name` cannot be<br/>
        /// changed. Archived service accounts cannot be updated; this returns 400.<br/>
        /// Setting `organization_role` to `admin` (even when unchanged) requires an<br/>
        /// interactive credential (a user OAuth token or a Console session).
        /// </summary>
        /// <param name="serviceAccountId">
        /// ID of the service account to update.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="description">
        /// Replaces the description. Omit to leave unchanged; send `null` to clear (the field is stored as an empty string).
        /// </param>
        /// <param name="organizationRole">
        /// Replaces the org-level role. Omit or send `null` to leave unchanged.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaServiceAccount> BetaUpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostAsync(
            string serviceAccountId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? description = default,
            global::Anthropic.BetaServiceAccountUpdateParamsOrganizationRole2? organizationRole = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}