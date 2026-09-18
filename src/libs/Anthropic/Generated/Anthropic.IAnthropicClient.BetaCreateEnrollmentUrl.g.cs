#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Enrollment URL
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="userProfileId"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaEnrollmentUrl> BetaCreateEnrollmentUrlAsync(
            string userProfileId,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Enrollment URL
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="userProfileId"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaEnrollmentUrl>> BetaCreateEnrollmentUrlAsResponseAsync(
            string userProfileId,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}