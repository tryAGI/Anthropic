#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create a Memory
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `agent-memory-2026-07-22` or `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="memoryStoreId"></param>
        /// <param name="view">
        /// Whether a `memory` or `memory_version` in the response includes its `content`. Defaults to `full` on retrieve operations and to `basic` on list, create, and update operations.<br/>
        /// With `full`, list operations return at most 20 items per page.
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsMemory> BetaCreateMemoryAsync(
            string memoryStoreId,

            global::Anthropic.BetaManagedAgentsCreateMemoryParams request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.BetaManagedAgentsMemoryView? view = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Memory
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `agent-memory-2026-07-22` or `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="memoryStoreId"></param>
        /// <param name="view">
        /// Whether a `memory` or `memory_version` in the response includes its `content`. Defaults to `full` on retrieve operations and to `basic` on list, create, and update operations.<br/>
        /// With `full`, list operations return at most 20 items per page.
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaManagedAgentsMemory>> BetaCreateMemoryAsResponseAsync(
            string memoryStoreId,

            global::Anthropic.BetaManagedAgentsCreateMemoryParams request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.BetaManagedAgentsMemoryView? view = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Memory
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `agent-memory-2026-07-22` or `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="memoryStoreId"></param>
        /// <param name="view">
        /// Whether a `memory` or `memory_version` in the response includes its `content`. Defaults to `full` on retrieve operations and to `basic` on list, create, and update operations.<br/>
        /// With `full`, list operations return at most 20 items per page.
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="path">
        /// The path of the new memory, such as `/projects/foo/notes.md`. Paths are case-sensitive.<br/>
        /// A path starts with `/` and has 1 to 20 segments. A segment can't be empty and can't be `.` or `..`. A path can't contain control characters, format characters, or the line and paragraph separators U+2028 and U+2029. It must be in Unicode Normalization Form C and at most 1,024 bytes long.
        /// </param>
        /// <param name="content">
        /// The UTF-8 text content of the new memory. Pass `""` to create an empty memory.<br/>
        /// The maximum size is 100 kB (102,400 bytes).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsMemory> BetaCreateMemoryAsync(
            string memoryStoreId,
            string path,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.BetaManagedAgentsMemoryView? view = default,
            string? anthropicWorkspaceId = default,
            string? content = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}