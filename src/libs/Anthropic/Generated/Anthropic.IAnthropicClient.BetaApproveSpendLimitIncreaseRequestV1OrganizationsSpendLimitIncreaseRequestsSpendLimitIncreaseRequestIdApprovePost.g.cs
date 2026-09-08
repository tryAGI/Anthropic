#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Approve Spend Limit Increase Request<br/>
        /// Approve a pending spend limit increase request.<br/>
        /// Writes a per-user spend limit at `amount` for the requester and<br/>
        /// transitions the request to `approved`. `period` defaults to the period<br/>
        /// the member was blocked on. Anthropic emails the requester unless<br/>
        /// `suppress_notification` is set.
        /// </summary>
        /// <param name="spendLimitIncreaseRequestId">
        /// ID of the spend limit increase request.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponse> BetaApproveSpendLimitIncreaseRequestV1OrganizationsSpendLimitIncreaseRequestsSpendLimitIncreaseRequestIdApprovePostAsync(
            string spendLimitIncreaseRequestId,

            global::Anthropic.BetaApproveSpendLimitIncreaseRequestParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Approve Spend Limit Increase Request<br/>
        /// Approve a pending spend limit increase request.<br/>
        /// Writes a per-user spend limit at `amount` for the requester and<br/>
        /// transitions the request to `approved`. `period` defaults to the period<br/>
        /// the member was blocked on. Anthropic emails the requester unless<br/>
        /// `suppress_notification` is set.
        /// </summary>
        /// <param name="spendLimitIncreaseRequestId">
        /// ID of the spend limit increase request.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponse>> BetaApproveSpendLimitIncreaseRequestV1OrganizationsSpendLimitIncreaseRequestsSpendLimitIncreaseRequestIdApprovePostAsResponseAsync(
            string spendLimitIncreaseRequestId,

            global::Anthropic.BetaApproveSpendLimitIncreaseRequestParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Approve Spend Limit Increase Request<br/>
        /// Approve a pending spend limit increase request.<br/>
        /// Writes a per-user spend limit at `amount` for the requester and<br/>
        /// transitions the request to `approved`. `period` defaults to the period<br/>
        /// the member was blocked on. Anthropic emails the requester unless<br/>
        /// `suppress_notification` is set.
        /// </summary>
        /// <param name="spendLimitIncreaseRequestId">
        /// ID of the spend limit increase request.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="amount">
        /// New per-user spend limit as a non-negative integer decimal string (minor units).
        /// </param>
        /// <param name="period"></param>
        /// <param name="suppressNotification"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponse> BetaApproveSpendLimitIncreaseRequestV1OrganizationsSpendLimitIncreaseRequestsSpendLimitIncreaseRequestIdApprovePostAsync(
            string spendLimitIncreaseRequestId,
            string amount,
            string? anthropicVersion = default,
            global::Anthropic.BetaApproveSpendLimitIncreaseRequestParamsPeriod? period = default,
            bool? suppressNotification = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}