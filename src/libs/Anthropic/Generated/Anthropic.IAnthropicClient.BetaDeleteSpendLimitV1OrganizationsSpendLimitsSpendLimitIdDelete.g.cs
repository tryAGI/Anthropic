#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Delete Spend Limit<br/>
        /// Delete a spend limit.<br/>
        /// For a Claude Enterprise organization, this deletes a per-user override, and<br/>
        /// the member falls back to any inherited spend limit at that period. Its<br/>
        /// seat-tier, group, and organization-level rows cannot be deleted via this<br/>
        /// endpoint. A Claude Console organization deletes its organization and<br/>
        /// workspace limits. Deleting them through the API is in an early access preview.
        /// </summary>
        /// <param name="spendLimitId">
        /// ID of the Spend Limit.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaDeleteSpendLimitResponse> BetaDeleteSpendLimitV1OrganizationsSpendLimitsSpendLimitIdDeleteAsync(
            string spendLimitId,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Spend Limit<br/>
        /// Delete a spend limit.<br/>
        /// For a Claude Enterprise organization, this deletes a per-user override, and<br/>
        /// the member falls back to any inherited spend limit at that period. Its<br/>
        /// seat-tier, group, and organization-level rows cannot be deleted via this<br/>
        /// endpoint. A Claude Console organization deletes its organization and<br/>
        /// workspace limits. Deleting them through the API is in an early access preview.
        /// </summary>
        /// <param name="spendLimitId">
        /// ID of the Spend Limit.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaDeleteSpendLimitResponse>> BetaDeleteSpendLimitV1OrganizationsSpendLimitsSpendLimitIdDeleteAsResponseAsync(
            string spendLimitId,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}