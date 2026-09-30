#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Federation Rules<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// List federation rules in your organization.<br/>
        /// Optionally filter by issuer with `issuer_id`. Archived rules are excluded<br/>
        /// unless `include_archived=true`.
        /// </summary>
        /// <param name="limit">
        /// Number of results per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page`.
        /// </param>
        /// <param name="issuerId">
        /// Filter to rules referencing this federation issuer.
        /// </param>
        /// <param name="includeArchived">
        /// Include archived resources. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.FederationRuleListResponse> ListFederationRulesV1OrganizationsFederationRulesGetAsync(
            int? limit = default,
            string? page = default,
            string? issuerId = default,
            bool? includeArchived = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Federation Rules<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// List federation rules in your organization.<br/>
        /// Optionally filter by issuer with `issuer_id`. Archived rules are excluded<br/>
        /// unless `include_archived=true`.
        /// </summary>
        /// <param name="limit">
        /// Number of results per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page`.
        /// </param>
        /// <param name="issuerId">
        /// Filter to rules referencing this federation issuer.
        /// </param>
        /// <param name="includeArchived">
        /// Include archived resources. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.FederationRuleListResponse>> ListFederationRulesV1OrganizationsFederationRulesGetAsResponseAsync(
            int? limit = default,
            string? page = default,
            string? issuerId = default,
            bool? includeArchived = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListFederationRulesV1OrganizationsFederationRulesGetAsync as an IAsyncEnumerable&lt;global::Anthropic.FederationRule&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Number of results per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="issuerId">
        /// Filter to rules referencing this federation issuer.
        /// </param>
        /// <param name="includeArchived">
        /// Include archived resources. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.FederationRule> ListFederationRulesV1OrganizationsFederationRulesGetAutoPagingAsync(
              int? limit = default,
            string? issuerId = default,
            bool? includeArchived = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}