#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Review Cases<br/>
        /// List the review cases of every organization that the API key can reach, newest first by default. Both open and closed cases are returned unless `status` is set.<br/>
        /// To sync, store the largest `updated_at` you have read, and send it as the at-or-after filter on `updated_at`, sorted by `updated_at` ascending. That finds new cases, newly closed cases, and cases with a new notice. Read every page, match results by `id`, and store the new largest value after the last page.<br/>
        /// A request with the `anthropic-user-profile-id` header and no `user_profile_id` parameter returns a 400 error.<br/>
        /// An Admin API key with the `read:compliance_review_cases` scope can call this endpoint.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="status">
        /// A review case status to filter by: `open` or `closed`.
        /// </param>
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
        /// <param name="updatedAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="userProfileId"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="orderBy">
        /// The field that a list of review cases is sorted by: `created_at` or `updated_at`.
        /// </param>
        /// <param name="order">
        /// A sort direction: `asc` or `desc`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaListReviewCasesResponse> BetaListReviewCasesAsync(
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.BetaComplianceReviewCaseStatusFilter? status = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? updatedAtGte = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLte = default,
            global::System.DateTime? updatedAtLt = default,
            string? userProfileId = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaComplianceReviewCaseOrderBy? orderBy = default,
            global::Anthropic.BetaComplianceReviewOrder? order = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Review Cases<br/>
        /// List the review cases of every organization that the API key can reach, newest first by default. Both open and closed cases are returned unless `status` is set.<br/>
        /// To sync, store the largest `updated_at` you have read, and send it as the at-or-after filter on `updated_at`, sorted by `updated_at` ascending. That finds new cases, newly closed cases, and cases with a new notice. Read every page, match results by `id`, and store the new largest value after the last page.<br/>
        /// A request with the `anthropic-user-profile-id` header and no `user_profile_id` parameter returns a 400 error.<br/>
        /// An Admin API key with the `read:compliance_review_cases` scope can call this endpoint.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="status">
        /// A review case status to filter by: `open` or `closed`.
        /// </param>
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
        /// <param name="updatedAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="userProfileId"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="orderBy">
        /// The field that a list of review cases is sorted by: `created_at` or `updated_at`.
        /// </param>
        /// <param name="order">
        /// A sort direction: `asc` or `desc`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListReviewCasesResponse>> BetaListReviewCasesAsResponseAsync(
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.BetaComplianceReviewCaseStatusFilter? status = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? updatedAtGte = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLte = default,
            global::System.DateTime? updatedAtLt = default,
            string? userProfileId = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaComplianceReviewCaseOrderBy? orderBy = default,
            global::Anthropic.BetaComplianceReviewOrder? order = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListReviewCasesAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaComplianceReviewCase&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="status">
        /// A review case status to filter by: `open` or `closed`.
        /// </param>
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
        /// <param name="updatedAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="userProfileId"></param>
        /// <param name="limit"></param>
        /// <param name="orderBy">
        /// The field that a list of review cases is sorted by: `created_at` or `updated_at`.
        /// </param>
        /// <param name="order">
        /// A sort direction: `asc` or `desc`.
        /// </param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaComplianceReviewCase> BetaListReviewCasesAutoPagingAsync(
              string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.BetaComplianceReviewCaseStatusFilter? status = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? updatedAtGte = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLte = default,
            global::System.DateTime? updatedAtLt = default,
            string? userProfileId = default,
            int? limit = default,
            global::Anthropic.BetaComplianceReviewCaseOrderBy? orderBy = default,
            global::Anthropic.BetaComplianceReviewOrder? order = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}