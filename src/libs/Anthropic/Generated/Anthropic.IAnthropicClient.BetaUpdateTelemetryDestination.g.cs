#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update a Telemetry Destination<br/>
        /// Change a telemetry destination's settings, its state, or which workspaces it covers.<br/>
        /// Send at least one field. Omitted fields keep their stored values, except the registered headers, which a change of the endpoint's hostname or port removes. Only `display_name`, `traces`, `traces.endpoint_url`, `traces.content_mode`, `traces.max_content_bytes`, and individual `headers` values accept `null`.<br/>
        /// If another request changes the destination while the update runs, the API returns a 409 `conflict_error`. Read the destination again, then retry the update.<br/>
        /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#delivery-and-health) to learn more about changing a destination.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `telemetry-destinations-2026-08-11` in this header.
        /// </param>
        /// <param name="destinationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaTelemetryDestination> BetaUpdateTelemetryDestinationAsync(
            string destinationId,

            global::Anthropic.BetaUpdateTelemetryDestinationRequestBody request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Telemetry Destination<br/>
        /// Change a telemetry destination's settings, its state, or which workspaces it covers.<br/>
        /// Send at least one field. Omitted fields keep their stored values, except the registered headers, which a change of the endpoint's hostname or port removes. Only `display_name`, `traces`, `traces.endpoint_url`, `traces.content_mode`, `traces.max_content_bytes`, and individual `headers` values accept `null`.<br/>
        /// If another request changes the destination while the update runs, the API returns a 409 `conflict_error`. Read the destination again, then retry the update.<br/>
        /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#delivery-and-health) to learn more about changing a destination.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `telemetry-destinations-2026-08-11` in this header.
        /// </param>
        /// <param name="destinationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaTelemetryDestination>> BetaUpdateTelemetryDestinationAsResponseAsync(
            string destinationId,

            global::Anthropic.BetaUpdateTelemetryDestinationRequestBody request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Telemetry Destination<br/>
        /// Change a telemetry destination's settings, its state, or which workspaces it covers.<br/>
        /// Send at least one field. Omitted fields keep their stored values, except the registered headers, which a change of the endpoint's hostname or port removes. Only `display_name`, `traces`, `traces.endpoint_url`, `traces.content_mode`, `traces.max_content_bytes`, and individual `headers` values accept `null`.<br/>
        /// If another request changes the destination while the update runs, the API returns a 409 `conflict_error`. Read the destination again, then retry the update.<br/>
        /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#delivery-and-health) to learn more about changing a destination.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `telemetry-destinations-2026-08-11` in this header.
        /// </param>
        /// <param name="destinationId"></param>
        /// <param name="displayName">
        /// New human-readable name, 1 to 255 characters. Null clears it.
        /// </param>
        /// <param name="endpointUrl">
        /// The new base URL of the destination's OTLP/HTTP endpoint. The same rules as on create apply.<br/>
        /// A change of hostname or port first removes every registered header, so send the headers for the new endpoint in the same request. When the destination has a `traces.endpoint_url`, such a change must also set `traces.endpoint_url` to a URL with the new hostname and port, or to `null`. A change of the path alone keeps the headers.
        /// </param>
        /// <param name="headers">
        /// Headers to set or remove. The API merges them into the destination's headers by name.<br/>
        /// Names compare case-insensitively. A string value sets or replaces that header. A `null` value removes it. Headers that you omit don't change. The field itself can't be `null`.<br/>
        /// A request that sets a header value must also include `endpoint_url`. The current URL is accepted.<br/>
        /// The resulting set must stay within the same limits as on create. When the request sets a value, each stored value that it doesn't set counts as 4,096 bytes toward the 16,384-byte limit, because you can't read its real length. So to change one header of a destination that has four or more other headers, send the values of the others again in the same request.
        /// </param>
        /// <param name="traces">
        /// The traces settings to change. Omitted settings keep their stored values.<br/>
        /// `null` sets every traces setting to its create default.
        /// </param>
        /// <param name="state">
        /// Whether the destination receives deliveries after the update. The field can't be `null`.
        /// </param>
        /// <param name="workspaces">
        /// The new workspace scope, in the same form as on create. The field can't be `null`.<br/>
        /// The API refuses an update that changes the type or sends `workspace_ids` while the destination's list has more than 750 workspaces. Remove workspaces one at a time until 750 or fewer remain, then send the update again.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaTelemetryDestination> BetaUpdateTelemetryDestinationAsync(
            string destinationId,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? displayName = default,
            string? endpointUrl = default,
            object? headers = default,
            global::Anthropic.BetaTelemetryDestinationTracesParams? traces = default,
            global::Anthropic.BetaTelemetryDestinationStateParams? state = default,
            global::Anthropic.BetaTelemetryDestinationWorkspacesParams? workspaces = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}