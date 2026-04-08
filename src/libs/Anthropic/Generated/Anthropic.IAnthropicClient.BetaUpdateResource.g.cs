#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Session Resource
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="sessionId"></param>
        /// <param name="resourceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsUpdateSessionResource> BetaUpdateResourceAsync(
            string sessionId,
            string resourceId,

            global::Anthropic.BetaManagedAgentsUpdateSessionResourceParams request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Session Resource
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="sessionId"></param>
        /// <param name="resourceId"></param>
        /// <param name="authorizationToken">
        /// New authorization token for the resource. Currently only `github_repository` resources support token rotation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsUpdateSessionResource> BetaUpdateResourceAsync(
            string sessionId,
            string resourceId,
            string authorizationToken,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}