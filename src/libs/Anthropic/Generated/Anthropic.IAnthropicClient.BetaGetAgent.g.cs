#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Agent
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="agentId"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsAgent> BetaGetAgentAsync(
            string agentId,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            int? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}