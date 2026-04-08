#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Agents
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="includeArchived"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsListAgents> BetaListAgentsAsync(
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            int? limit = default,
            string? page = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            bool? includeArchived = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}