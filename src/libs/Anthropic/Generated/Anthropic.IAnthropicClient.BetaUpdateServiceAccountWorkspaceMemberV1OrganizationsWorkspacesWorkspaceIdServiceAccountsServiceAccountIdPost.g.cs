#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Service Account Workspace Member<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Change a service account's role in a workspace.<br/>
        /// The new `workspace_role` replaces the current one. Only explicit<br/>
        /// memberships can be updated; to set a role on the implicit<br/>
        /// default-workspace membership, add the service account explicitly with<br/>
        /// `POST /workspaces/{workspace_id}/service_accounts`. Archived workspaces<br/>
        /// return 400. Archived service accounts cannot be updated and are<br/>
        /// rejected.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the workspace.
        /// </param>
        /// <param name="serviceAccountId">
        /// ID of the service account.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaServiceAccountWorkspaceMember> BetaUpdateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsServiceAccountIdPostAsync(
            string workspaceId,
            string serviceAccountId,

            global::Anthropic.BetaServiceAccountWorkspaceMemberUpdateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Service Account Workspace Member<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Change a service account's role in a workspace.<br/>
        /// The new `workspace_role` replaces the current one. Only explicit<br/>
        /// memberships can be updated; to set a role on the implicit<br/>
        /// default-workspace membership, add the service account explicitly with<br/>
        /// `POST /workspaces/{workspace_id}/service_accounts`. Archived workspaces<br/>
        /// return 400. Archived service accounts cannot be updated and are<br/>
        /// rejected.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the workspace.
        /// </param>
        /// <param name="serviceAccountId">
        /// ID of the service account.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaServiceAccountWorkspaceMember>> BetaUpdateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsServiceAccountIdPostAsResponseAsync(
            string workspaceId,
            string serviceAccountId,

            global::Anthropic.BetaServiceAccountWorkspaceMemberUpdateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Service Account Workspace Member<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Change a service account's role in a workspace.<br/>
        /// The new `workspace_role` replaces the current one. Only explicit<br/>
        /// memberships can be updated; to set a role on the implicit<br/>
        /// default-workspace membership, add the service account explicitly with<br/>
        /// `POST /workspaces/{workspace_id}/service_accounts`. Archived workspaces<br/>
        /// return 400. Archived service accounts cannot be updated and are<br/>
        /// rejected.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the workspace.
        /// </param>
        /// <param name="serviceAccountId">
        /// ID of the service account.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="workspaceRole">
        /// New role for the service account in this workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaServiceAccountWorkspaceMember> BetaUpdateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsServiceAccountIdPostAsync(
            string workspaceId,
            string serviceAccountId,
            global::Anthropic.BetaNoBillingWorkspaceRoleSchema workspaceRole,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}