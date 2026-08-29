#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Service Account Workspace Members<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// List the service accounts that are members of a workspace.<br/>
        /// Each entry includes the service account's `workspace_role`. Use `limit`<br/>
        /// and the `next_page` cursor to paginate. Archived workspaces return 400;<br/>
        /// use `GET /service_accounts/{id}/workspaces` to audit memberships of an<br/>
        /// archived workspace. The implicit default-workspace membership is not<br/>
        /// included in this list. Memberships of archived service accounts are<br/>
        /// omitted from the results.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the workspace.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaServiceAccountWorkspaceMemberListResponse> BetaListServiceAccountWorkspaceMembersV1OrganizationsWorkspacesWorkspaceIdServiceAccountsGetAsync(
            string workspaceId,
            int? limit = default,
            string? page = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Service Account Workspace Members<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// List the service accounts that are members of a workspace.<br/>
        /// Each entry includes the service account's `workspace_role`. Use `limit`<br/>
        /// and the `next_page` cursor to paginate. Archived workspaces return 400;<br/>
        /// use `GET /service_accounts/{id}/workspaces` to audit memberships of an<br/>
        /// archived workspace. The implicit default-workspace membership is not<br/>
        /// included in this list. Memberships of archived service accounts are<br/>
        /// omitted from the results.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the workspace.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaServiceAccountWorkspaceMemberListResponse>> BetaListServiceAccountWorkspaceMembersV1OrganizationsWorkspacesWorkspaceIdServiceAccountsGetAsResponseAsync(
            string workspaceId,
            int? limit = default,
            string? page = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListServiceAccountWorkspaceMembersV1OrganizationsWorkspacesWorkspaceIdServiceAccountsGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaServiceAccountWorkspaceMember&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the workspace.
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
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaServiceAccountWorkspaceMember> BetaListServiceAccountWorkspaceMembersV1OrganizationsWorkspacesWorkspaceIdServiceAccountsGetAutoPagingAsync(
            string workspaceId,             int? limit = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}