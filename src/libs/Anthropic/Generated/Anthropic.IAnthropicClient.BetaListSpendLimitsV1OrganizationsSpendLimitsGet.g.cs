#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Spend Limits<br/>
        /// List the organization's spend limits.<br/>
        /// A Claude Console organization's limits come in an order that is stable across<br/>
        /// pages. A Claude Enterprise organization's are grouped by scope type,<br/>
        /// in the order `organization`, `seat_tier`, `rbac_group`,<br/>
        /// `organization_service`, `user`; within a type they come in a fixed order that<br/>
        /// is not creation order.
        /// </summary>
        /// <param name="scopeType">
        /// Return only limits with these scope types. A Claude Console organization has `organization` and `workspace` limits; a Claude Enterprise organization has `organization`, `seat_tier`, `rbac_group`, `organization_service` and `user` limits. Omit for all.
        /// </param>
        /// <param name="limit">
        /// Maximum number of limits per page. Defaults to `20`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `spend-limit-reads-2026-09-26` in this header.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaListSpendLimitsResponse> BetaListSpendLimitsV1OrganizationsSpendLimitsGetAsync(
            global::System.Collections.Generic.IList<global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item>? scopeType = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Spend Limits<br/>
        /// List the organization's spend limits.<br/>
        /// A Claude Console organization's limits come in an order that is stable across<br/>
        /// pages. A Claude Enterprise organization's are grouped by scope type,<br/>
        /// in the order `organization`, `seat_tier`, `rbac_group`,<br/>
        /// `organization_service`, `user`; within a type they come in a fixed order that<br/>
        /// is not creation order.
        /// </summary>
        /// <param name="scopeType">
        /// Return only limits with these scope types. A Claude Console organization has `organization` and `workspace` limits; a Claude Enterprise organization has `organization`, `seat_tier`, `rbac_group`, `organization_service` and `user` limits. Omit for all.
        /// </param>
        /// <param name="limit">
        /// Maximum number of limits per page. Defaults to `20`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `spend-limit-reads-2026-09-26` in this header.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListSpendLimitsResponse>> BetaListSpendLimitsV1OrganizationsSpendLimitsGetAsResponseAsync(
            global::System.Collections.Generic.IList<global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item>? scopeType = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListSpendLimitsV1OrganizationsSpendLimitsGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaSpendLimit&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="scopeType">
        /// Return only limits with these scope types. A Claude Console organization has `organization` and `workspace` limits; a Claude Enterprise organization has `organization`, `seat_tier`, `rbac_group`, `organization_service` and `user` limits. Omit for all.
        /// </param>
        /// <param name="limit">
        /// Maximum number of limits per page. Defaults to `20`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `spend-limit-reads-2026-09-26` in this header.
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
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaSpendLimit> BetaListSpendLimitsV1OrganizationsSpendLimitsGetAutoPagingAsync(
              global::System.Collections.Generic.IList<global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item>? scopeType = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}