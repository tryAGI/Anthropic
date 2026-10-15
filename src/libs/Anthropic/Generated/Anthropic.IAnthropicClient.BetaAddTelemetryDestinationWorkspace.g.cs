#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Add a Telemetry Destination Workspace<br/>
        /// Add one workspace to a destination's workspace list.<br/>
        /// Under `include` the workspace's spans start going to the destination. Under `exclude` they stop. A list holds at most 1,000 workspaces.<br/>
        /// Adding a workspace that is already on the list changes nothing and returns the existing entry. An archived workspace that isn't on the list yet can't be added. A destination whose `workspaces.type` is `all` doesn't have a list, so the API returns 400. To change which workspaces such a destination covers, update its `workspaces`.<br/>
        /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#choose-workspaces-for-a-destination) to learn more about choosing the workspaces of a destination.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `telemetry-destinations-2026-08-11` in this header.
        /// </param>
        /// <param name="destinationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaTelemetryDestinationWorkspace> BetaAddTelemetryDestinationWorkspaceAsync(
            string destinationId,
            string workspaceId,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a Telemetry Destination Workspace<br/>
        /// Add one workspace to a destination's workspace list.<br/>
        /// Under `include` the workspace's spans start going to the destination. Under `exclude` they stop. A list holds at most 1,000 workspaces.<br/>
        /// Adding a workspace that is already on the list changes nothing and returns the existing entry. An archived workspace that isn't on the list yet can't be added. A destination whose `workspaces.type` is `all` doesn't have a list, so the API returns 400. To change which workspaces such a destination covers, update its `workspaces`.<br/>
        /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#choose-workspaces-for-a-destination) to learn more about choosing the workspaces of a destination.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `telemetry-destinations-2026-08-11` in this header.
        /// </param>
        /// <param name="destinationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaTelemetryDestinationWorkspace>> BetaAddTelemetryDestinationWorkspaceAsResponseAsync(
            string destinationId,
            string workspaceId,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}