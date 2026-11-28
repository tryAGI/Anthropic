#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Google-Managed Data Controls<br/>
        /// Turn a control on or off, or change the key or bucket set for a region. Controls and regions that you leave out stay as they are.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `google-managed-data-controls-2026-09-01` in this header.
        /// </param>
        /// <param name="userProfileId"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaGoogleManagedDataControls> BetaUpdateGoogleManagedDataControlsAsync(
            string userProfileId,

            global::Anthropic.BetaUpdateGoogleManagedDataControlsRequestBody request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Google-Managed Data Controls<br/>
        /// Turn a control on or off, or change the key or bucket set for a region. Controls and regions that you leave out stay as they are.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `google-managed-data-controls-2026-09-01` in this header.
        /// </param>
        /// <param name="userProfileId"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaGoogleManagedDataControls>> BetaUpdateGoogleManagedDataControlsAsResponseAsync(
            string userProfileId,

            global::Anthropic.BetaUpdateGoogleManagedDataControlsRequestBody request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Google-Managed Data Controls<br/>
        /// Turn a control on or off, or change the key or bucket set for a region. Controls and regions that you leave out stay as they are.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `google-managed-data-controls-2026-09-01` in this header.
        /// </param>
        /// <param name="userProfileId"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="cmek">
        /// The customer-managed encryption key control. Leave it out to keep the control as it is. Send `cmek`, `storage`, or both.
        /// </param>
        /// <param name="storage">
        /// The customer-owned storage control. Leave it out to keep the control as it is. Send `cmek`, `storage`, or both.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaGoogleManagedDataControls> BetaUpdateGoogleManagedDataControlsAsync(
            string userProfileId,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.BetaGoogleManagedCmekControlParams? cmek = default,
            global::Anthropic.BetaGoogleManagedStorageControlParams? storage = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}