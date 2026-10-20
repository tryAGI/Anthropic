#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update a Memory Store
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `agent-memory-2026-07-22` or `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="memoryStoreId"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponse> BetaUpdateMemoryStoreAsync(
            string memoryStoreId,

            global::Anthropic.BetaManagedAgentsUpdateMemoryStoreRequestBody request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Memory Store
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `agent-memory-2026-07-22` or `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="memoryStoreId"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponse>> BetaUpdateMemoryStoreAsResponseAsync(
            string memoryStoreId,

            global::Anthropic.BetaManagedAgentsUpdateMemoryStoreRequestBody request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Memory Store
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `agent-memory-2026-07-22` or `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="memoryStoreId"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="name">
        /// The new name of the memory store, 1 to 255 characters long, without control characters.<br/>
        /// Sessions created after the change use the new name for the store's directory under `/mnt/memory/`.
        /// </param>
        /// <param name="description">
        /// New description for the store, up to 1,024 characters. Pass an empty string to clear it.
        /// </param>
        /// <param name="metadata">
        /// Changes to apply to the memory store's metadata. Keys you leave out keep their values.<br/>
        /// Set a key to a string to add or replace it, or to `null` to remove it. After the change, the metadata can hold at most 16 key-value pairs. Keys are 1 to 64 characters long and values at most 512 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponse> BetaUpdateMemoryStoreAsync(
            string memoryStoreId,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicWorkspaceId = default,
            string? name = default,
            string? description = default,
            object? metadata = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}