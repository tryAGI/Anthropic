#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Deployment Runs
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="deploymentId"></param>
        /// <param name="triggerType">
        /// What triggered a deployment run.
        /// </param>
        /// <param name="hasError"></param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsListDeploymentRunsData> BetaListDeploymentRunsAsync(
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            int? limit = default,
            string? page = default,
            string? deploymentId = default,
            global::Anthropic.BetaManagedAgentsTriggerType? triggerType = default,
            bool? hasError = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLt = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Deployment Runs
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="deploymentId"></param>
        /// <param name="triggerType">
        /// What triggered a deployment run.
        /// </param>
        /// <param name="hasError"></param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaManagedAgentsListDeploymentRunsData>> BetaListDeploymentRunsAsResponseAsync(
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            int? limit = default,
            string? page = default,
            string? deploymentId = default,
            global::Anthropic.BetaManagedAgentsTriggerType? triggerType = default,
            bool? hasError = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLt = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListDeploymentRunsAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaManagedAgentsDeploymentRun&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="limit"></param>
        /// <param name="deploymentId"></param>
        /// <param name="triggerType">
        /// What triggered a deployment run.
        /// </param>
        /// <param name="hasError"></param>
        /// <param name="createdAtGte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLte">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtGt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="createdAtLt">
        /// A timestamp in RFC 3339 format
        /// </param> 
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaManagedAgentsDeploymentRun> BetaListDeploymentRunsAutoPagingAsync(
              string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            int? limit = default,
            string? deploymentId = default,
            global::Anthropic.BetaManagedAgentsTriggerType? triggerType = default,
            bool? hasError = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLt = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}