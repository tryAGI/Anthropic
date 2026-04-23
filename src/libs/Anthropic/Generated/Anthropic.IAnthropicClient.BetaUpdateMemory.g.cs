#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// UpdateMemory
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="memoryStoreId"></param>
        /// <param name="memoryId"></param>
        /// <param name="view">
        /// MemoryView enum
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsMemory> BetaUpdateMemoryAsync(
            string memoryStoreId,
            string memoryId,

            global::Anthropic.BetaManagedAgentsUpdateMemoryParams request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.BetaManagedAgentsMemoryView? view = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// UpdateMemory
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="memoryStoreId"></param>
        /// <param name="memoryId"></param>
        /// <param name="view">
        /// MemoryView enum
        /// </param>
        /// <param name="content"></param>
        /// <param name="path"></param>
        /// <param name="precondition"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsMemory> BetaUpdateMemoryAsync(
            string memoryStoreId,
            string memoryId,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.BetaManagedAgentsMemoryView? view = default,
            string? content = default,
            string? path = default,
            global::Anthropic.BetaManagedAgentsContentSha256Precondition? precondition = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}