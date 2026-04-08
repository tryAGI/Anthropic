#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Credential
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="vaultId"></param>
        /// <param name="credentialId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsCredential> BetaUpdateCredentialAsync(
            string vaultId,
            string credentialId,

            global::Anthropic.BetaManagedAgentsUpdateCredentialRequestBody request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Credential
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="vaultId"></param>
        /// <param name="credentialId"></param>
        /// <param name="displayName">
        /// Updated human-readable name for the credential. 1-255 characters.
        /// </param>
        /// <param name="metadata">
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omitted keys are preserved.
        /// </param>
        /// <param name="auth">
        /// Updated authentication configuration. The `type` is immutable; the variant sent must match the stored credential's type.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsCredential> BetaUpdateCredentialAsync(
            string vaultId,
            string credentialId,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? displayName = default,
            global::System.Collections.Generic.Dictionary<string, string?>? metadata = default,
            global::Anthropic.BetaManagedAgentsCredentialUpdateAuth? auth = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}