#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List memory versions
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="memoryStoreId"></param>
        /// <param name="memoryId"></param>
        /// <param name="sessionId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="operation">
        /// The kind of mutation a `memory_version` records. Every non-no-op mutation to a memory appends exactly one version row with one of these values.
        /// </param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="view">
        /// Selects which projection of a `memory` or `memory_version` the server returns. `basic` returns the object with `content` set to `null`; `full` populates `content`. When omitted, the default is endpoint-specific: retrieve operations default to `full`; list, create, and update operations default to `basic`. Listing with `view=full` caps `limit` at 20.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsListMemoryVersionsResult> BetaListMemoryVersionsAsync(
            string memoryStoreId,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? memoryId = default,
            string? sessionId = default,
            string? apiKeyId = default,
            global::Anthropic.BetaManagedAgentsMemoryVersionOperation? operation = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaManagedAgentsMemoryView? view = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List memory versions
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="memoryStoreId"></param>
        /// <param name="memoryId"></param>
        /// <param name="sessionId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="operation">
        /// The kind of mutation a `memory_version` records. Every non-no-op mutation to a memory appends exactly one version row with one of these values.
        /// </param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="view">
        /// Selects which projection of a `memory` or `memory_version` the server returns. `basic` returns the object with `content` set to `null`; `full` populates `content`. When omitted, the default is endpoint-specific: retrieve operations default to `full`; list, create, and update operations default to `basic`. Listing with `view=full` caps `limit` at 20.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaManagedAgentsListMemoryVersionsResult>> BetaListMemoryVersionsAsResponseAsync(
            string memoryStoreId,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? memoryId = default,
            string? sessionId = default,
            string? apiKeyId = default,
            global::Anthropic.BetaManagedAgentsMemoryVersionOperation? operation = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaManagedAgentsMemoryView? view = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}