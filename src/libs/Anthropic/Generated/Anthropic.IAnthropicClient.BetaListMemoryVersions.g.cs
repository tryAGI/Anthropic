#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// ListMemoryVersions
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="memoryStoreId"></param>
        /// <param name="memoryId"></param>
        /// <param name="sessionId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="operation">
        /// MemoryVersionOperation enum
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
        /// MemoryView enum
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
    }
}