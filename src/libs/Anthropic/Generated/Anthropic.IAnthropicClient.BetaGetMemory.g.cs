#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Retrieve a memory
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="memoryStoreId"></param>
        /// <param name="memoryId"></param>
        /// <param name="view">
        /// Selects which projection of a `memory` or `memory_version` the server returns. `basic` returns the object with `content` set to `null`; `full` populates `content`. When omitted, the default is endpoint-specific: retrieve operations default to `full`; list, create, and update operations default to `basic`. Listing with `view=full` caps `limit` at 20.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsMemory> BetaGetMemoryAsync(
            string memoryStoreId,
            string memoryId,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.BetaManagedAgentsMemoryView? view = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}