#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Effective Spend Limits<br/>
        /// List each member's effective spend limit and period-to-date spend.<br/>
        /// Returns one row per (member, period) the member resolves a spend limit<br/>
        /// for, with the `source` scope the spend limit was inherited from.<br/>
        /// Paginates by member, so a member's periods never split across pages.
        /// </summary>
        /// <param name="userIds">
        /// Restrict the report to these members, by tagged user ID (`user_...`). At most 100 entries.
        /// </param>
        /// <param name="period">
        /// Restrict the report to these limit periods. Omit to return one row per period each member resolves a spend limit for.
        /// </param>
        /// <param name="limit">
        /// Maximum number of members per page. A member's period rows never split across pages, so a page may carry more rows than this. Defaults to `20`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaListEffectiveSpendLimitsResponse> BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetAsync(
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item>? period = default,
            int? limit = default,
            string? page = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Effective Spend Limits<br/>
        /// List each member's effective spend limit and period-to-date spend.<br/>
        /// Returns one row per (member, period) the member resolves a spend limit<br/>
        /// for, with the `source` scope the spend limit was inherited from.<br/>
        /// Paginates by member, so a member's periods never split across pages.
        /// </summary>
        /// <param name="userIds">
        /// Restrict the report to these members, by tagged user ID (`user_...`). At most 100 entries.
        /// </param>
        /// <param name="period">
        /// Restrict the report to these limit periods. Omit to return one row per period each member resolves a spend limit for.
        /// </param>
        /// <param name="limit">
        /// Maximum number of members per page. A member's period rows never split across pages, so a page may carry more rows than this. Defaults to `20`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListEffectiveSpendLimitsResponse>> BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetAsResponseAsync(
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item>? period = default,
            int? limit = default,
            string? page = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaSpendSummary&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="userIds">
        /// Restrict the report to these members, by tagged user ID (`user_...`). At most 100 entries.
        /// </param>
        /// <param name="period">
        /// Restrict the report to these limit periods. Omit to return one row per period each member resolves a spend limit for.
        /// </param>
        /// <param name="limit">
        /// Maximum number of members per page. A member's period rows never split across pages, so a page may carry more rows than this. Defaults to `20`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaSpendSummary> BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetAutoPagingAsync(
              global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item>? period = default,
            int? limit = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}