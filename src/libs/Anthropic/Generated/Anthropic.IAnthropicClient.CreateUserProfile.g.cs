#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create User Profile
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.UserProfile> CreateUserProfileAsync(

            global::Anthropic.CreateUserProfileRequest request,
            string? anthropicVersion = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create User Profile
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.UserProfile>> CreateUserProfileAsResponseAsync(

            global::Anthropic.CreateUserProfileRequest request,
            string? anthropicVersion = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create User Profile
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="name">
        /// Optional for all profiles. Real-world name of the entity this profile represents (company or individual); for a company the platform resells Claude access to (`access_type` `passthrough`), that company's name where known. Maximum 255 characters.
        /// </param>
        /// <param name="accessType">
        /// How the platform uses the API for this entity. `application` (default): the profile represents an individual end-user of the platform's product. `passthrough`: the profile identifies a company the platform resells Claude access to.
        /// </param>
        /// <param name="externalUserDetails">
        /// Details about the entity this profile represents, as the platform states them. Every field is optional. Not accepted under the legacy `user-profiles-2026-03-24` and `user-profiles-2026-08-18` beta headers, which take the top-level `external_id` (and, under `user-profiles-2026-08-18`, `external_user_onboarded_at`) instead.
        /// </param>
        /// <param name="metadata">
        /// Free-form key-value data to attach to this user profile. Maximum 16 keys, with keys up to 64 characters and values up to 512 characters. Values must be non-empty strings.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.UserProfile> CreateUserProfileAsync(
            string? anthropicVersion = default,
            string? anthropicWorkspaceId = default,
            string? name = default,
            global::Anthropic.UserProfileAccessType? accessType = default,
            global::Anthropic.UserProfileExternalUserDetailsParams? externalUserDetails = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}