#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create a Telemetry Destination<br/>
        /// Register an OpenTelemetry destination for the organization.<br/>
        /// The destination starts in state `enabled`. An organization can have at most 10 destinations, including disabled ones.<br/>
        /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#add-a-destination) to learn more about adding a destination.
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaTelemetryDestination> BetaCreateTelemetryDestinationAsync(

            global::Anthropic.BetaCreateTelemetryDestinationRequest request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Telemetry Destination<br/>
        /// Register an OpenTelemetry destination for the organization.<br/>
        /// The destination starts in state `enabled`. An organization can have at most 10 destinations, including disabled ones.<br/>
        /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#add-a-destination) to learn more about adding a destination.
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaTelemetryDestination>> BetaCreateTelemetryDestinationAsResponseAsync(

            global::Anthropic.BetaCreateTelemetryDestinationRequest request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Telemetry Destination<br/>
        /// Register an OpenTelemetry destination for the organization.<br/>
        /// The destination starts in state `enabled`. An organization can have at most 10 destinations, including disabled ones.<br/>
        /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#add-a-destination) to learn more about adding a destination.
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="displayName">
        /// Human-readable name for the destination. Optional. 1 to 255 characters.
        /// </param>
        /// <param name="endpointUrl">
        /// The base URL of your collector's OTLP/HTTP endpoint, for example `https://gateway.example.com`.<br/>
        /// The URL must use `https` and a hostname, not an IP address. The port, if given, must be 443. The URL must not contain a query string, a fragment, or a username and password. At most 2,048 characters.<br/>
        /// A path prefix, such as `/otlp`, is allowed. Don't include the per-signal path (`/v1/traces`), because the API appends it on delivery. If your collector takes traces on another path, also set `traces.endpoint_url`.
        /// </param>
        /// <param name="headers">
        /// Request headers that the API sends with every delivery, typically your collector's authentication header (for example `authorization`).<br/>
        /// The API stores the values encrypted and never returns them. Reads show only `header_names`.<br/>
        /// At most 20 headers. Names are at most 128 characters. Two names can't differ only in case. Values are printable ASCII, at most 4,096 characters, and can't begin or end with a space. Names and values together are at most 16,384 bytes.<br/>
        /// Reserved names are rejected, for example `host`, `cookie`, `user-agent`, and names that start with `content-`, `proxy-`, `x-forwarded-`, or `anthropic-`. For this check, `_` in a name counts as `-`.
        /// </param>
        /// <param name="traces">
        /// The settings for the traces that the destination receives. If you leave it out, every setting takes its default.
        /// </param>
        /// <param name="workspaces">
        /// Which of the organization's workspaces the destination covers.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaTelemetryDestination> BetaCreateTelemetryDestinationAsync(
            string endpointUrl,
            global::Anthropic.BetaTelemetryDestinationWorkspacesParams workspaces,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? displayName = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::Anthropic.BetaTelemetryDestinationTracesParams? traces = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}