#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update User Profile
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="userProfileId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaUserProfile> BetaUpdateUserProfileAsync(
            string userProfileId,

            global::Anthropic.BetaUpdateUserProfileRequestBody request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update User Profile
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="userProfileId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaUserProfile>> BetaUpdateUserProfileAsResponseAsync(
            string userProfileId,

            global::Anthropic.BetaUpdateUserProfileRequestBody request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update User Profile
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="userProfileId"></param>
        /// <param name="externalId">
        /// If present, replaces the stored external_id. Omit to leave unchanged. Maximum 255 characters.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs to merge into the stored metadata. Keys provided overwrite existing values. To remove a key, set its value to an empty string. Keys not provided are left unchanged. Maximum 16 keys, with keys up to 64 characters and values up to 512 characters.
        /// </param>
        /// <param name="name">
        /// If present, replaces the stored name. Omit to leave unchanged. Maximum 255 characters.
        /// </param>
        /// <param name="accessType">
        /// If present, replaces the stored access type. Omit to leave unchanged.
        /// </param>
        /// <param name="externalUserOnboardedAt">
        /// If present, replaces the stored account creation time. Omit to leave unchanged; once set, the value cannot be cleared and `null` is rejected. Must be a complete RFC 3339 timestamp no more than 1 minute in the future.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaUserProfile> BetaUpdateUserProfileAsync(
            string userProfileId,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? externalId = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? name = default,
            global::Anthropic.BetaUserProfileAccessType? accessType = default,
            global::System.DateTime? externalUserOnboardedAt = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}