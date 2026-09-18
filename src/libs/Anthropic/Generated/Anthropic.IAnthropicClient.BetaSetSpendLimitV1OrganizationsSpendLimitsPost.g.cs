#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Set Spend Limit<br/>
        /// Set a spend limit.<br/>
        /// Upsert keyed on (scope, period): setting a limit that already exists<br/>
        /// overwrites it in place. A Claude Enterprise organization sets `user`<br/>
        /// limits. Its seat-tier, group, and organization-level defaults are configured<br/>
        /// in claude.ai. A Claude Console organization sets `organization` and<br/>
        /// `workspace` limits, which are monthly and always carry an amount. Setting those<br/>
        /// limits is in an early access preview. To request access, contact your<br/>
        /// Anthropic account team.
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
        /// Set a spend limit.<br/>
        /// Upsert keyed on (scope, period): setting a limit that already exists<br/>
        /// overwrites it in place. A Claude Enterprise organization sets `user`<br/>
        /// limits. Its seat-tier, group, and organization-level defaults are configured<br/>
        /// in claude.ai. A Claude Console organization sets `organization` and<br/>
        /// `workspace` limits, which are monthly and always carry an amount. Setting those<br/>
        /// limits is in an early access preview. To request access, contact your<br/>
        /// Anthropic account team.
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
        /// Set a spend limit.<br/>
        /// Upsert keyed on (scope, period): setting a limit that already exists<br/>
        /// overwrites it in place. A Claude Enterprise organization sets `user`<br/>
        /// limits. Its seat-tier, group, and organization-level defaults are configured<br/>
        /// in claude.ai. A Claude Console organization sets `organization` and<br/>
        /// `workspace` limits, which are monthly and always carry an amount. Setting those<br/>
        /// limits is in an early access preview. To request access, contact your<br/>
        /// Anthropic account team.
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
        /// What the limit applies to. Claude Enterprise organizations set `user` limits. Claude Console organizations set `organization` and `workspace` limits. Any other combination returns 400. Setting `organization` and `workspace` limits through the API is in an early access preview. To request access, contact your Anthropic account team.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaSpendLimit> BetaSetSpendLimitV1OrganizationsSpendLimitsPostAsync(
            global::Anthropic.Scope2 scope,
            string? anthropicVersion = default,
            string? amount = default,
            global::Anthropic.BetaSetSpendLimitParamsPeriod? period = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}