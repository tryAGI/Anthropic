#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create External Key<br/>
        /// Create an external key config owned by the caller's organization.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaExternalKey> BetaCreateExternalKeyV1OrganizationsExternalKeysPostAsync(

            global::Anthropic.BetaExternalKeyCreateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create External Key<br/>
        /// Create an external key config owned by the caller's organization.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaExternalKey>> BetaCreateExternalKeyV1OrganizationsExternalKeysPostAsResponseAsync(

            global::Anthropic.BetaExternalKeyCreateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create External Key<br/>
        /// Create an external key config owned by the caller's organization.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="displayName">
        /// Human-friendly display name.
        /// </param>
        /// <param name="geo">
        /// Data residency geo. Only `us` is supported.
        /// </param>
        /// <param name="providerConfig">
        /// KMS provider identity and auth coordinates.
        /// </param>
        /// <param name="userProfileId">
        /// ID of a user profile to bind the key to. A user profile represents one of your customers: bind a customer's key to that customer's user profile. A key bound to a user profile can only be attached to a Workspace that has the same user profile, and the binding cannot be changed later. Omit this field only for your organization's own key, because a key created without a user profile ID can be attached to any Workspace, including another customer's.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaExternalKey> BetaCreateExternalKeyV1OrganizationsExternalKeysPostAsync(
            global::Anthropic.ProviderConfig2 providerConfig,
            string? anthropicVersion = default,
            string? displayName = default,
            string? geo = default,
            string? userProfileId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}