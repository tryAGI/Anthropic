#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Credentials
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="vaultId"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="includeArchived"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsListCredentialsResponse> BetaListCredentialsAsync(
            string vaultId,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            int? limit = default,
            string? page = default,
            bool? includeArchived = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}