#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Review Notices<br/>
        /// List Anthropic's notices to the organizations that the API key can reach, newest first by default. A notice is returned only if the API key can read every case in its `case_ids`.<br/>
        /// To poll, store the largest `created_at` you have read, and send it as the at-or-after filter on `created_at`. Read every page, match results by `id`, and store the new largest value after the last page.<br/>
        /// An Admin API key with the `read:compliance_review_cases` scope can call this endpoint.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="caseId"></param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="order">
        /// A sort direction: `asc` or `desc`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaListReviewNoticesResponse> BetaListReviewNoticesAsync(
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? caseId = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaComplianceReviewOrder? order = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Review Notices<br/>
        /// List Anthropic's notices to the organizations that the API key can reach, newest first by default. A notice is returned only if the API key can read every case in its `case_ids`.<br/>
        /// To poll, store the largest `created_at` you have read, and send it as the at-or-after filter on `created_at`. Read every page, match results by `id`, and store the new largest value after the last page.<br/>
        /// An Admin API key with the `read:compliance_review_cases` scope can call this endpoint.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="caseId"></param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="order">
        /// A sort direction: `asc` or `desc`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListReviewNoticesResponse>> BetaListReviewNoticesAsResponseAsync(
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? caseId = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaComplianceReviewOrder? order = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListReviewNoticesAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaComplianceReviewNotice&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="caseId"></param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="limit"></param>
        /// <param name="order">
        /// A sort direction: `asc` or `desc`.
        /// </param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaComplianceReviewNotice> BetaListReviewNoticesAutoPagingAsync(
              string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? caseId = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            int? limit = default,
            global::Anthropic.BetaComplianceReviewOrder? order = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}