#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Tunnels<br/>
        /// The Tunnels API is in research preview. It requires the `anthropic-beta: mcp-tunnels-2026-06-22` header and may change without a deprecation period. It supersedes the Admin API endpoints at `/v1/organizations/tunnels`, which remain available during a migration window.<br/>
        /// Lists tunnels. Results are ordered by creation time, newest first; archived tunnels are excluded unless include_archived is set.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="includeArchived"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaListTunnelsResponse> BetaListTunnelsAsync(
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            int? limit = default,
            string? page = default,
            bool? includeArchived = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tunnels<br/>
        /// The Tunnels API is in research preview. It requires the `anthropic-beta: mcp-tunnels-2026-06-22` header and may change without a deprecation period. It supersedes the Admin API endpoints at `/v1/organizations/tunnels`, which remain available during a migration window.<br/>
        /// Lists tunnels. Results are ordered by creation time, newest first; archived tunnels are excluded unless include_archived is set.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="includeArchived"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListTunnelsResponse>> BetaListTunnelsAsResponseAsync(
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            int? limit = default,
            string? page = default,
            bool? includeArchived = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListTunnelsAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaTunnel&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="limit"></param>
        /// <param name="includeArchived"></param> 
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaTunnel> BetaListTunnelsAutoPagingAsync(
              string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            int? limit = default,
            bool? includeArchived = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}