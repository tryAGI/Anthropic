#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Session
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsSession> BetaUpdateSessionAsync(
            string sessionId,

            global::Anthropic.BetaManagedAgentsUpdateSessionParams request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Session
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaManagedAgentsSession>> BetaUpdateSessionAsResponseAsync(
            string sessionId,

            global::Anthropic.BetaManagedAgentsUpdateSessionParams request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Session
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="sessionId"></param>
        /// <param name="title">
        /// Human-readable session title.
        /// </param>
        /// <param name="metadata">
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omit the field to preserve.
        /// </param>
        /// <param name="vaultIds">
        /// Vault IDs (`vlt_*`) to attach to the session. Not yet supported; requests setting this field are rejected. Reserved for future use.
        /// </param>
        /// <param name="agent">
        /// Agent configuration update. Only `tools` and `mcp_servers` are updatable mid-session. Only valid for sessions created from an agent or deployment reference. The session must not be running.
        /// </param>
        /// <param name="budget">
        /// Enforced spend ceiling for the session. Set an object to replace the budget of a session that was created with one, or `null` to remove it; omit to preserve. A budget cannot be added to a session created without one (rejected with reason `budget_create_only`), and a removed budget cannot be re-added. Allowed in any non-terminated status. Lowering `max_list_cost` to at or below the session's consumed list cost is rejected with reason `budget_not_raised`, and every model the session can run must have a public list price or the request is rejected with reason `model_not_budgetable`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsSession> BetaUpdateSessionAsync(
            string sessionId,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? title = default,
            global::System.Collections.Generic.Dictionary<string, string?>? metadata = default,
            global::System.Collections.Generic.IList<string>? vaultIds = default,
            global::Anthropic.BetaManagedAgentsSessionAgentUpdate? agent = default,
            global::Anthropic.BetaManagedAgentsBudget? budget = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}