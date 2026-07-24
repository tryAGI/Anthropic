#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Deployment
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsDeployment> BetaCreateDeploymentAsync(

            global::Anthropic.BetaManagedAgentsCreateDeploymentParams request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Deployment
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaManagedAgentsDeployment>> BetaCreateDeploymentAsResponseAsync(

            global::Anthropic.BetaManagedAgentsCreateDeploymentParams request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Deployment
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="name">
        /// Human-readable name for the deployment.
        /// </param>
        /// <param name="description">
        /// Description of what the deployment does.
        /// </param>
        /// <param name="agent">
        /// Agent to deploy. Accepts the `agent` ID string, which pins the latest version, or an `agent` object with both id and version specified. The agent must exist and not be archived.
        /// </param>
        /// <param name="environmentId">
        /// ID of the `environment` defining the container configuration for sessions created from this deployment.
        /// </param>
        /// <param name="vaultIds">
        /// Vault IDs for stored credentials the agent can use during sessions created from this deployment. Maximum 50.
        /// </param>
        /// <param name="initialEvents">
        /// Events to send to each session immediately after creation. At least 1, maximum 50.
        /// </param>
        /// <param name="resources">
        /// Resources (e.g. repositories, files) to mount into each session's container. Maximum 500.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </param>
        /// <param name="schedule">
        /// Optional recurring cron schedule. When present, the deployment fires automatically. Both expression and timezone are required when schedule is set.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsDeployment> BetaCreateDeploymentAsync(
            string name,
            global::Anthropic.BetaManagedAgentsAgentUnionParams agent,
            string environmentId,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams> initialEvents,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? vaultIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? resources = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Anthropic.BetaManagedAgentsScheduleParams? schedule = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}