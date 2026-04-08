#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Vault
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="vaultId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsVault> BetaGetVaultAsync(
            string vaultId,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}