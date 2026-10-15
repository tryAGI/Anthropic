#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Deployments
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="agentId"></param>
        /// <param name="status">
        /// Lifecycle status of a deployment.
        /// </param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="includeArchived"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsListDeploymentsData> BetaListDeploymentsAsync(
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            int? limit = default,
            string? page = default,
            string? agentId = default,
            global::Anthropic.BetaManagedAgentsDeploymentStatus? status = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            bool? includeArchived = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Deployments
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="agentId"></param>
        /// <param name="status">
        /// Lifecycle status of a deployment.
        /// </param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="includeArchived"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaManagedAgentsListDeploymentsData>> BetaListDeploymentsAsResponseAsync(
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            int? limit = default,
            string? page = default,
            string? agentId = default,
            global::Anthropic.BetaManagedAgentsDeploymentStatus? status = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            bool? includeArchived = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListDeploymentsAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaManagedAgentsDeployment&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `managed-agents-2026-04-01` in this header.
        /// </param>
        /// <param name="limit"></param>
        /// <param name="agentId"></param>
        /// <param name="status">
        /// Lifecycle status of a deployment.
        /// </param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="includeArchived"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaManagedAgentsDeployment> BetaListDeploymentsAutoPagingAsync(
              string? xApiKey = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            int? limit = default,
            string? agentId = default,
            global::Anthropic.BetaManagedAgentsDeploymentStatus? status = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            bool? includeArchived = default,
            string? anthropicWorkspaceId = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}