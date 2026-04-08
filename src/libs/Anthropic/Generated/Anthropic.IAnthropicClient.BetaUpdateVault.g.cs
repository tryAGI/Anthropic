#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Vault
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="vaultId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsVault> BetaUpdateVaultAsync(
            string vaultId,

            global::Anthropic.BetaManagedAgentsUpdateVaultRequestBody request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Vault
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="vaultId"></param>
        /// <param name="displayName">
        /// Updated human-readable name for the vault. 1-255 characters.
        /// </param>
        /// <param name="metadata">
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omitted keys are preserved.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsVault> BetaUpdateVaultAsync(
            string vaultId,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? displayName = default,
            global::System.Collections.Generic.Dictionary<string, string?>? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}