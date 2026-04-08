#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Session
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsSession> BetaCreateSessionAsync(

            global::Anthropic.BetaManagedAgentsCreateSessionParams request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Session
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="agent">
        /// Agent identifier. Accepts the `agent` ID string, which pins the latest version for the session, or an `agent` object with both id and version specified.
        /// </param>
        /// <param name="environmentId">
        /// ID of the `environment` defining the container configuration for this session.
        /// </param>
        /// <param name="title">
        /// Human-readable session title.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata attached to the session. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </param>
        /// <param name="resources">
        /// Resources (e.g. repositories, files) to mount into the session's container.
        /// </param>
        /// <param name="vaultIds">
        /// Vault IDs for stored credentials the agent can use during the session.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsSession> BetaCreateSessionAsync(
            global::Anthropic.BetaManagedAgentsAgentUnionParams agent,
            string environmentId,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? title = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? resources = default,
            global::System.Collections.Generic.IList<string>? vaultIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}