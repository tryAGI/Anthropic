#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Memory Versions
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `agent-memory-2026-07-22` or `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="memoryStoreId"></param>
        /// <param name="memoryId"></param>
        /// <param name="sessionId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="operation">
        /// The kind of change that a memory version records.<br/>
        /// Every change to a memory adds one version. If you update a memory and nothing changes, the memory doesn't get a new version.
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
        /// Whether a `memory` or `memory_version` in the response includes its `content`. Defaults to `full` on retrieve operations and to `basic` on list, create, and update operations.<br/>
        /// With `full`, list operations return at most 20 items per page.
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsListMemoryVersionsResult> BetaListMemoryVersionsAsync(
            string memoryStoreId,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? memoryId = default,
            string? sessionId = default,
            string? apiKeyId = default,
            string? serviceAccountId = default,
            global::Anthropic.BetaManagedAgentsMemoryVersionOperation? operation = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaManagedAgentsMemoryView? view = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Memory Versions
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `agent-memory-2026-07-22` or `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="memoryStoreId"></param>
        /// <param name="memoryId"></param>
        /// <param name="sessionId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="operation">
        /// The kind of change that a memory version records.<br/>
        /// Every change to a memory adds one version. If you update a memory and nothing changes, the memory doesn't get a new version.
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
        /// Whether a `memory` or `memory_version` in the response includes its `content`. Defaults to `full` on retrieve operations and to `basic` on list, create, and update operations.<br/>
        /// With `full`, list operations return at most 20 items per page.
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaManagedAgentsListMemoryVersionsResult>> BetaListMemoryVersionsAsResponseAsync(
            string memoryStoreId,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? memoryId = default,
            string? sessionId = default,
            string? apiKeyId = default,
            string? serviceAccountId = default,
            global::Anthropic.BetaManagedAgentsMemoryVersionOperation? operation = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaManagedAgentsMemoryView? view = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListMemoryVersionsAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaManagedAgentsMemoryVersion&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `agent-memory-2026-07-22` or `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="memoryStoreId"></param>
        /// <param name="memoryId"></param>
        /// <param name="sessionId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="operation">
        /// The kind of change that a memory version records.<br/>
        /// Every change to a memory adds one version. If you update a memory and nothing changes, the memory doesn't get a new version.
        /// </param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="limit"></param>
        /// <param name="view">
        /// Whether a `memory` or `memory_version` in the response includes its `content`. Defaults to `full` on retrieve operations and to `basic` on list, create, and update operations.<br/>
        /// With `full`, list operations return at most 20 items per page.
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaManagedAgentsMemoryVersion> BetaListMemoryVersionsAutoPagingAsync(
            string memoryStoreId,             string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? memoryId = default,
            string? sessionId = default,
            string? apiKeyId = default,
            string? serviceAccountId = default,
            global::Anthropic.BetaManagedAgentsMemoryVersionOperation? operation = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            int? limit = default,
            global::Anthropic.BetaManagedAgentsMemoryView? view = default,
            string? anthropicWorkspaceId = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}