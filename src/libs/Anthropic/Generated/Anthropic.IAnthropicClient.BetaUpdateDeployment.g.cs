#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Deployment
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsDeployment> BetaUpdateDeploymentAsync(
            string deploymentId,

            global::Anthropic.BetaManagedAgentsUpdateDeploymentParams request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Deployment
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaManagedAgentsDeployment>> BetaUpdateDeploymentAsResponseAsync(
            string deploymentId,

            global::Anthropic.BetaManagedAgentsUpdateDeploymentParams request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Deployment
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="deploymentId"></param>
        /// <param name="name">
        /// Human-readable name. Must be non-empty. Omit to preserve. Cannot be cleared.
        /// </param>
        /// <param name="description">
        /// Description. Omit to preserve; send empty string or null to clear.
        /// </param>
        /// <param name="agent">
        /// Agent to deploy. Accepts the `agent` ID string, which re-pins to the latest version, or an `agent` object with both id and version specified. Omit to preserve. Cannot be cleared.
        /// </param>
        /// <param name="environmentId">
        /// ID of the `environment` where sessions run. Omit to preserve. Cannot be cleared.
        /// </param>
        /// <param name="vaultIds">
        /// Vault IDs. Full replacement. Omit to preserve; send empty array or null to clear. Maximum 50.
        /// </param>
        /// <param name="initialEvents">
        /// Initial events. Full replacement. Omit to preserve. Cannot be cleared. At least 1, maximum 50.
        /// </param>
        /// <param name="resources">
        /// Session resources. Full replacement. Omit to preserve; send empty array or null to clear. Maximum 500.
        /// </param>
        /// <param name="metadata">
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omit the field to preserve. The stored bag is limited to 16 keys (up to 64 chars each) with values up to 512 chars.
        /// </param>
        /// <param name="schedule">
        /// Cron schedule. Full replacement. Omit to preserve; send null to clear (revert to manual-only).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsDeployment> BetaUpdateDeploymentAsync(
            string deploymentId,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? name = default,
            string? description = default,
            global::Anthropic.BetaManagedAgentsAgentUnionParams? agent = default,
            string? environmentId = default,
            global::System.Collections.Generic.IList<string>? vaultIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams>? initialEvents = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? resources = default,
            global::System.Collections.Generic.Dictionary<string, string?>? metadata = default,
            global::Anthropic.BetaManagedAgentsScheduleParams? schedule = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}