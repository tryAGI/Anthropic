#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Set Spend Limit<br/>
        /// Set a per-user spend limit override.<br/>
        /// Upsert keyed on (scope, period): setting a limit that already exists<br/>
        /// overwrites it in place. Only `scope.type: "user"` is accepted; seat-tier,<br/>
        /// group, and organization-level defaults are configured in claude.ai.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaSpendLimit> BetaSetSpendLimitV1OrganizationsSpendLimitsPostAsync(

            global::Anthropic.BetaSetSpendLimitParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Spend Limit<br/>
        /// Set a per-user spend limit override.<br/>
        /// Upsert keyed on (scope, period): setting a limit that already exists<br/>
        /// overwrites it in place. Only `scope.type: "user"` is accepted; seat-tier,<br/>
        /// group, and organization-level defaults are configured in claude.ai.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaSpendLimit>> BetaSetSpendLimitV1OrganizationsSpendLimitsPostAsResponseAsync(

            global::Anthropic.BetaSetSpendLimitParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Spend Limit<br/>
        /// Set a per-user spend limit override.<br/>
        /// Upsert keyed on (scope, period): setting a limit that already exists<br/>
        /// overwrites it in place. Only `scope.type: "user"` is accepted; seat-tier,<br/>
        /// group, and organization-level defaults are configured in claude.ai.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="amount">
        /// Limit amount as a non-negative integer decimal string in the minor unit of the organization's billing currency (cents for USD): "50000" is $500.00. `null` sets an explicit no-limit override for this scope and `period` only — each period resolves independently, so caps for other periods still apply.
        /// </param>
        /// <param name="period"></param>
        /// <param name="scope">
        /// Scope selecting a single member of the organization.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaSpendLimit> BetaSetSpendLimitV1OrganizationsSpendLimitsPostAsync(
            global::Anthropic.BetaUserScope scope,
            string? anthropicVersion = default,
            string? amount = default,
            global::Anthropic.BetaSetSpendLimitParamsPeriod? period = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}