#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update a memory store
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="memoryStoreId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponse> BetaUpdateMemoryStoreAsync(
            string memoryStoreId,

            global::Anthropic.BetaManagedAgentsUpdateMemoryStoreRequestBody request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a memory store
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="memoryStoreId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponse>> BetaUpdateMemoryStoreAsResponseAsync(
            string memoryStoreId,

            global::Anthropic.BetaManagedAgentsUpdateMemoryStoreRequestBody request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a memory store
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="memoryStoreId"></param>
        /// <param name="name">
        /// New human-readable name for the store. 1–255 characters; no control characters. Renaming changes the slug used for the store's `mount_path` in sessions created after the update.
        /// </param>
        /// <param name="description">
        /// New description for the store, up to 1024 characters. Pass an empty string to clear it.
        /// </param>
        /// <param name="metadata">
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omit the field to preserve. The stored bag is limited to 16 keys (up to 64 chars each) with values up to 512 chars.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponse> BetaUpdateMemoryStoreAsync(
            string memoryStoreId,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string?>? metadata = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}