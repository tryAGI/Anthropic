#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Spend Limit Increase Requests<br/>
        /// List spend limit increase requests, most recent first.<br/>
        /// Pending requests include a live `spend_summary` for the requester.<br/>
        /// Requests whose requester is no longer a member are excluded.
        /// </summary>
        /// <param name="status">
        /// Filter by status. Omit to return all.
        /// </param>
        /// <param name="actorIds">
        /// Filter by requester, as `user_...` tagged IDs.
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page`.
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaSpendLimitIncreaseRequestListResponse> BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetAsync(
            global::System.Collections.Generic.IList<global::Anthropic.BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetStatusVariant1Item>? status = default,
            global::System.Collections.Generic.IList<string>? actorIds = default,
            string? page = default,
            int? limit = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Spend Limit Increase Requests<br/>
        /// List spend limit increase requests, most recent first.<br/>
        /// Pending requests include a live `spend_summary` for the requester.<br/>
        /// Requests whose requester is no longer a member are excluded.
        /// </summary>
        /// <param name="status">
        /// Filter by status. Omit to return all.
        /// </param>
        /// <param name="actorIds">
        /// Filter by requester, as `user_...` tagged IDs.
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page`.
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaSpendLimitIncreaseRequestListResponse>> BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetAsResponseAsync(
            global::System.Collections.Generic.IList<global::Anthropic.BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetStatusVariant1Item>? status = default,
            global::System.Collections.Generic.IList<string>? actorIds = default,
            string? page = default,
            int? limit = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaSpendLimitIncreaseRequestSchema&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="status">
        /// Filter by status. Omit to return all.
        /// </param>
        /// <param name="actorIds">
        /// Filter by requester, as `user_...` tagged IDs.
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaSpendLimitIncreaseRequestSchema> BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetAutoPagingAsync(
              global::System.Collections.Generic.IList<global::Anthropic.BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetStatusVariant1Item>? status = default,
            global::System.Collections.Generic.IList<string>? actorIds = default,
            int? limit = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}