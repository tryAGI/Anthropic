#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Google-Managed Project Data Controls<br/>
        /// Get a Google Cloud project's encryption keys and storage buckets for Claude on Google Cloud's Agent Platform, with each region's status.<br/>
        /// Your organization must have proved that it owns the project.
        /// </summary>
        /// <param name="projectNumber">
        /// The Google Cloud project's number, such as `123456789012`, not its project ID.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `google-managed-data-controls-2026-09-01` in this header.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaGoogleManagedProjectDataControls> BetaGetGoogleManagedProjectDataControlsV1OrganizationsProvidersGoogleProjectsProjectNumberDataControlsGetAsync(
            string projectNumber,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Google-Managed Project Data Controls<br/>
        /// Get a Google Cloud project's encryption keys and storage buckets for Claude on Google Cloud's Agent Platform, with each region's status.<br/>
        /// Your organization must have proved that it owns the project.
        /// </summary>
        /// <param name="projectNumber">
        /// The Google Cloud project's number, such as `123456789012`, not its project ID.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `google-managed-data-controls-2026-09-01` in this header.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaGoogleManagedProjectDataControls>> BetaGetGoogleManagedProjectDataControlsV1OrganizationsProvidersGoogleProjectsProjectNumberDataControlsGetAsResponseAsync(
            string projectNumber,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}