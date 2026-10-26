#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Sessions
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="includeArchived"></param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="agentVersion"></param>
        /// <param name="order"></param>
        /// <param name="memoryStoreId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="statuses"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsListSessions> BetaListSessionsAsync(
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            int? limit = default,
            string? page = default,
            bool? includeArchived = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            string? agentId = default,
            int? agentVersion = default,
            global::Anthropic.BetaManagedAgentsListOrder? order = default,
            string? memoryStoreId = default,
            string? deploymentId = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionStatus>? statuses = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Sessions
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="includeArchived"></param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="agentVersion"></param>
        /// <param name="order"></param>
        /// <param name="memoryStoreId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="statuses"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaManagedAgentsListSessions>> BetaListSessionsAsResponseAsync(
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            int? limit = default,
            string? page = default,
            bool? includeArchived = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            string? agentId = default,
            int? agentVersion = default,
            global::Anthropic.BetaManagedAgentsListOrder? order = default,
            string? memoryStoreId = default,
            string? deploymentId = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionStatus>? statuses = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListSessionsAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaManagedAgentsSession&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="limit"></param>
        /// <param name="includeArchived"></param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="agentVersion"></param>
        /// <param name="order"></param>
        /// <param name="memoryStoreId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="statuses"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaManagedAgentsSession> BetaListSessionsAutoPagingAsync(
              string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            int? limit = default,
            bool? includeArchived = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            string? agentId = default,
            int? agentVersion = default,
            global::Anthropic.BetaManagedAgentsListOrder? order = default,
            string? memoryStoreId = default,
            string? deploymentId = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionStatus>? statuses = default,
            string? anthropicWorkspaceId = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}