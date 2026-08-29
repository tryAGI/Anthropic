#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Workspaces For Service Account<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// List the workspaces a service account is a member of.<br/>
        /// Each entry includes the service account's `workspace_role` in that<br/>
        /// workspace. Use `limit` and the `next_page` cursor to paginate. When the<br/>
        /// service account has no explicit default-workspace membership, the<br/>
        /// implicit (`implicit: true`) membership is returned as the first entry on<br/>
        /// the first page; with `limit=1` the first page may return up to 2 entries<br/>
        /// (the implicit entry plus one explicit membership) so a pagination cursor<br/>
        /// can be derived. Memberships are returned only while<br/>
        /// the service account is active. Without a `page` cursor, an archived<br/>
        /// service account returns an empty list. A `page` cursor that does not<br/>
        /// match an active membership returns a 400 invalid-request error. A cursor<br/>
        /// stops matching when the membership is removed, the workspace is deleted,<br/>
        /// or the service account is archived. Restart pagination from the first<br/>
        /// page to recover.
        /// </summary>
        /// <param name="serviceAccountId">
        /// ID of the service account.
        /// </param>
        /// <param name="limit">
        /// Number of results per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page`.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaServiceAccountWorkspaceMemberListResponse> BetaListWorkspacesForServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesGetAsync(
            string serviceAccountId,
            int? limit = default,
            string? page = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Workspaces For Service Account<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// List the workspaces a service account is a member of.<br/>
        /// Each entry includes the service account's `workspace_role` in that<br/>
        /// workspace. Use `limit` and the `next_page` cursor to paginate. When the<br/>
        /// service account has no explicit default-workspace membership, the<br/>
        /// implicit (`implicit: true`) membership is returned as the first entry on<br/>
        /// the first page; with `limit=1` the first page may return up to 2 entries<br/>
        /// (the implicit entry plus one explicit membership) so a pagination cursor<br/>
        /// can be derived. Memberships are returned only while<br/>
        /// the service account is active. Without a `page` cursor, an archived<br/>
        /// service account returns an empty list. A `page` cursor that does not<br/>
        /// match an active membership returns a 400 invalid-request error. A cursor<br/>
        /// stops matching when the membership is removed, the workspace is deleted,<br/>
        /// or the service account is archived. Restart pagination from the first<br/>
        /// page to recover.
        /// </summary>
        /// <param name="serviceAccountId">
        /// ID of the service account.
        /// </param>
        /// <param name="limit">
        /// Number of results per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page`.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaServiceAccountWorkspaceMemberListResponse>> BetaListWorkspacesForServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesGetAsResponseAsync(
            string serviceAccountId,
            int? limit = default,
            string? page = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListWorkspacesForServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaServiceAccountWorkspaceMember&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="serviceAccountId">
        /// ID of the service account.
        /// </param>
        /// <param name="limit">
        /// Number of results per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
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
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaServiceAccountWorkspaceMember> BetaListWorkspacesForServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesGetAutoPagingAsync(
            string serviceAccountId,             int? limit = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}