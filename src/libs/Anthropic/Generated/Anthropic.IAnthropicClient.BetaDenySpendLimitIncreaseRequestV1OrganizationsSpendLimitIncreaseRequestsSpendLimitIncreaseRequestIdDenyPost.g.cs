#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Deny Spend Limit Increase Request<br/>
        /// Deny a pending spend limit increase request.<br/>
        /// Idempotent on `denied`; denying an already-`approved` request returns<br/>
        /// 400. Anthropic emails the requester unless `suppress_notification` is set.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaSpendLimitIncreaseRequestSchema> BetaDenySpendLimitIncreaseRequestV1OrganizationsSpendLimitIncreaseRequestsSpendLimitIncreaseRequestIdDenyPostAsync(
            string spendLimitIncreaseRequestId,

            global::Anthropic.BetaDenySpendLimitIncreaseRequestParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deny Spend Limit Increase Request<br/>
        /// Deny a pending spend limit increase request.<br/>
        /// Idempotent on `denied`; denying an already-`approved` request returns<br/>
        /// 400. Anthropic emails the requester unless `suppress_notification` is set.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaSpendLimitIncreaseRequestSchema>> BetaDenySpendLimitIncreaseRequestV1OrganizationsSpendLimitIncreaseRequestsSpendLimitIncreaseRequestIdDenyPostAsResponseAsync(
            string spendLimitIncreaseRequestId,

            global::Anthropic.BetaDenySpendLimitIncreaseRequestParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deny Spend Limit Increase Request<br/>
        /// Deny a pending spend limit increase request.<br/>
        /// Idempotent on `denied`; denying an already-`approved` request returns<br/>
        /// 400. Anthropic emails the requester unless `suppress_notification` is set.
        /// </summary>
        /// <param name="spendLimitIncreaseRequestId">
        /// ID of the spend limit increase request.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="suppressNotification"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaSpendLimitIncreaseRequestSchema> BetaDenySpendLimitIncreaseRequestV1OrganizationsSpendLimitIncreaseRequestsSpendLimitIncreaseRequestIdDenyPostAsync(
            string spendLimitIncreaseRequestId,
            string? anthropicVersion = default,
            bool? suppressNotification = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}