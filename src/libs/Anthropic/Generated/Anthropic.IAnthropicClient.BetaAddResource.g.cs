#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Add Session Resource
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsAddSessionResource> BetaAddResourceAsync(
            string sessionId,

            global::Anthropic.BetaManagedAgentsAddSessionResourceParams request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}