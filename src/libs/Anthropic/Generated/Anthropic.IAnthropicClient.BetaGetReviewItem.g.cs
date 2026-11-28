#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Review Item<br/>
        /// Read one message that Anthropic flagged for your organization to review, with its request and response.<br/>
        /// A message that the API key can't read, or that isn't flagged, returns the same 404 as one that doesn't exist. For a message recorded with a user profile, send that profile's ID in the `anthropic-user-profile-id` header. A flagged message can also return 404 if it belongs to another organization than the key's own, or to your end customer's user profile or Workspace.<br/>
        /// If your encryption key or storage bucket refuses the read, the API returns a 400 with `cmek_key_disabled`, `storage_bucket_unreadable` or `customer_storage_refusal_unattributed` in `error.details.error_code`.<br/>
        /// The API key must have the `read:compliance_review_items`, `read:compliance_user_data` or `read:org_audit` scope. A key of an organization with no parent organization must have `read:compliance_review_items`.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="itemId"></param>
        /// <param name="anthropicUserProfileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaComplianceReviewItem> BetaGetReviewItemAsync(
            string itemId,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicUserProfileId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Review Item<br/>
        /// Read one message that Anthropic flagged for your organization to review, with its request and response.<br/>
        /// A message that the API key can't read, or that isn't flagged, returns the same 404 as one that doesn't exist. For a message recorded with a user profile, send that profile's ID in the `anthropic-user-profile-id` header. A flagged message can also return 404 if it belongs to another organization than the key's own, or to your end customer's user profile or Workspace.<br/>
        /// If your encryption key or storage bucket refuses the read, the API returns a 400 with `cmek_key_disabled`, `storage_bucket_unreadable` or `customer_storage_refusal_unattributed` in `error.details.error_code`.<br/>
        /// The API key must have the `read:compliance_review_items`, `read:compliance_user_data` or `read:org_audit` scope. A key of an organization with no parent organization must have `read:compliance_review_items`.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="itemId"></param>
        /// <param name="anthropicUserProfileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaComplianceReviewItem>> BetaGetReviewItemAsResponseAsync(
            string itemId,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicUserProfileId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}