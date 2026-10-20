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
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaUserProfile> BetaCreateUserProfileAsync(

            global::Anthropic.BetaCreateUserProfileRequest request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
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
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaUserProfile>> BetaCreateUserProfileAsResponseAsync(

            global::Anthropic.BetaCreateUserProfileRequest request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
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
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="externalId">
        /// Platform's own identifier for this user. Not enforced unique. Maximum 255 characters. Legacy field, accepted only under the `user-profiles-2026-03-24` and `user-profiles-2026-08-18` beta headers; without one of them, send `external_user_details.reference_id`.
        /// </param>
        /// <param name="name">
        /// Optional for all profiles. Real-world name of the entity this profile represents (company or individual); for a company the platform resells Claude access to (`access_type` `passthrough`), that company's name where known. Maximum 255 characters.
        /// </param>
        /// <param name="accessType">
        /// How the platform uses the API for this entity. `application` (default): the profile represents an individual end-user of the platform's product. `passthrough`: the profile identifies a company the platform resells Claude access to.
        /// </param>
        /// <param name="externalUserOnboardedAt">
        /// When the entity this profile represents opened its account with the platform, in RFC 3339 format: for an `application` profile, when the end-user signed up; for a `passthrough` profile, when the company became the platform's customer. Must be a complete timestamp no more than 1 minute in the future. Optional. Legacy field, accepted only under the `user-profiles-2026-08-18` beta header; without a legacy header, send `external_user_details.onboarded_at`.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaUserProfile> BetaCreateUserProfileAsync(
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicWorkspaceId = default,
            string? externalId = default,
            string? name = default,
            global::Anthropic.BetaUserProfileAccessType? accessType = default,
            global::System.DateTime? externalUserOnboardedAt = default,
            global::Anthropic.BetaUserProfileExternalUserDetailsParams? externalUserDetails = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}