#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Spend Limit Increase Request<br/>
        /// Retrieve a spend limit increase request.<br/>
        /// While `pending`, the response includes a live `spend_summary` for the<br/>
        /// requester at the request's period.
        /// </summary>
        /// <param name="spendLimitIncreaseRequestId">
        /// ID of the spend limit increase request.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaSpendLimitIncreaseRequestSchema> BetaGetSpendLimitIncreaseRequestV1OrganizationsSpendLimitIncreaseRequestsSpendLimitIncreaseRequestIdGetAsync(
            string spendLimitIncreaseRequestId,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Spend Limit Increase Request<br/>
        /// Retrieve a spend limit increase request.<br/>
        /// While `pending`, the response includes a live `spend_summary` for the<br/>
        /// requester at the request's period.
        /// </summary>
        /// <param name="spendLimitIncreaseRequestId">
        /// ID of the spend limit increase request.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaSpendLimitIncreaseRequestSchema>> BetaGetSpendLimitIncreaseRequestV1OrganizationsSpendLimitIncreaseRequestsSpendLimitIncreaseRequestIdGetAsResponseAsync(
            string spendLimitIncreaseRequestId,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}