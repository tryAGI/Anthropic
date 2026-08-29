#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Archive Federation Issuer<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Archive a federation issuer.<br/>
        /// Idempotent; re-archiving returns the issuer with its original<br/>
        /// `archived_at`. Rejected with 400 if any live (non-archived) federation<br/>
        /// rule still references the issuer; archive those rules first (a rule's<br/>
        /// issuer cannot be changed), or recreate them against another issuer.
        /// </summary>
        /// <param name="federationIssuerId">
        /// ID of the federation issuer to archive.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFederationIssuer> BetaArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostAsync(
            string federationIssuerId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Archive Federation Issuer<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Archive a federation issuer.<br/>
        /// Idempotent; re-archiving returns the issuer with its original<br/>
        /// `archived_at`. Rejected with 400 if any live (non-archived) federation<br/>
        /// rule still references the issuer; archive those rules first (a rule's<br/>
        /// issuer cannot be changed), or recreate them against another issuer.
        /// </summary>
        /// <param name="federationIssuerId">
        /// ID of the federation issuer to archive.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaFederationIssuer>> BetaArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostAsResponseAsync(
            string federationIssuerId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}