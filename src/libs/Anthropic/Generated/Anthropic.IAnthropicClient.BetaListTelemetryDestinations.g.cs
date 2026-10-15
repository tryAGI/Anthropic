#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Telemetry Destinations<br/>
        /// List the organization's destinations, newest first, optionally only those that cover given workspaces.<br/>
        /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#set-up-api-tracing) to learn more about destinations.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `telemetry-destinations-2026-08-11` in this header.
        /// </param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaListTelemetryDestinationsResponse> BetaListTelemetryDestinationsAsync(
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Telemetry Destinations<br/>
        /// List the organization's destinations, newest first, optionally only those that cover given workspaces.<br/>
        /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#set-up-api-tracing) to learn more about destinations.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `telemetry-destinations-2026-08-11` in this header.
        /// </param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListTelemetryDestinationsResponse>> BetaListTelemetryDestinationsAsResponseAsync(
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListTelemetryDestinationsAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaTelemetryDestination&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `telemetry-destinations-2026-08-11` in this header.
        /// </param>
        /// <param name="limit"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaTelemetryDestination> BetaListTelemetryDestinationsAutoPagingAsync(
              string? xApiKey = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}