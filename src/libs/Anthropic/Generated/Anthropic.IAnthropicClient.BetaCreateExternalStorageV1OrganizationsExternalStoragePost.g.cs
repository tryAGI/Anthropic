#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create External Storage<br/>
        /// Register a bucket in the organization's own cloud account. It is saved<br/>
        /// as `pending_configuration` and verified when activated.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `efs-2026-10-01` in this header.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaExternalStorage> BetaCreateExternalStorageV1OrganizationsExternalStoragePostAsync(
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,

            global::Anthropic.BetaExternalStorageCreateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create External Storage<br/>
        /// Register a bucket in the organization's own cloud account. It is saved<br/>
        /// as `pending_configuration` and verified when activated.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `efs-2026-10-01` in this header.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaExternalStorage>> BetaCreateExternalStorageV1OrganizationsExternalStoragePostAsResponseAsync(
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,

            global::Anthropic.BetaExternalStorageCreateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create External Storage<br/>
        /// Register a bucket in the organization's own cloud account. It is saved<br/>
        /// as `pending_configuration` and verified when activated.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `efs-2026-10-01` in this header.
        /// </param>
        /// <param name="displayName">
        /// Human-friendly display name.
        /// </param>
        /// <param name="providerConfig"></param>
        /// <param name="userProfileId">
        /// The user profile to bind the storage to. It can't be changed later. The storage can be attached only to Workspaces with this profile, and the bucket's setup must name the same ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaExternalStorage> BetaCreateExternalStorageV1OrganizationsExternalStoragePostAsync(
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            global::Anthropic.ProviderConfig6 providerConfig,
            string? anthropicVersion = default,
            string? displayName = default,
            string? userProfileId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}