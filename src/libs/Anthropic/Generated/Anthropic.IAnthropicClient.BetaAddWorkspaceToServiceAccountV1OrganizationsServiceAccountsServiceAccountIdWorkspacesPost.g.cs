#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Add Workspace To Service Account<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Add a service account to a workspace with the given `workspace_role`.<br/>
        /// Mirror of `POST /workspaces/{workspace_id}/service_accounts`, addressed<br/>
        /// from the service-account side; both create the same membership. If the<br/>
        /// service account is already an explicit member of the workspace, its<br/>
        /// `workspace_role` is replaced with the value supplied here. Archived<br/>
        /// workspaces return 400. Archived service accounts cannot be added and are<br/>
        /// rejected.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaServiceAccountWorkspaceMember> BetaAddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostAsync(
            string serviceAccountId,

            global::Anthropic.BetaServiceAccountWorkspaceMemberCreateFromSAParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Workspace To Service Account<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Add a service account to a workspace with the given `workspace_role`.<br/>
        /// Mirror of `POST /workspaces/{workspace_id}/service_accounts`, addressed<br/>
        /// from the service-account side; both create the same membership. If the<br/>
        /// service account is already an explicit member of the workspace, its<br/>
        /// `workspace_role` is replaced with the value supplied here. Archived<br/>
        /// workspaces return 400. Archived service accounts cannot be added and are<br/>
        /// rejected.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaServiceAccountWorkspaceMember>> BetaAddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostAsResponseAsync(
            string serviceAccountId,

            global::Anthropic.BetaServiceAccountWorkspaceMemberCreateFromSAParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Workspace To Service Account<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Add a service account to a workspace with the given `workspace_role`.<br/>
        /// Mirror of `POST /workspaces/{workspace_id}/service_accounts`, addressed<br/>
        /// from the service-account side; both create the same membership. If the<br/>
        /// service account is already an explicit member of the workspace, its<br/>
        /// `workspace_role` is replaced with the value supplied here. Archived<br/>
        /// workspaces return 400. Archived service accounts cannot be added and are<br/>
        /// rejected.
        /// </summary>
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
        /// <param name="workspaceId">
        /// Tagged workspace ID to add the service account to.
        /// </param>
        /// <param name="workspaceRole">
        /// Role to assign to the service account in this workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaServiceAccountWorkspaceMember> BetaAddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostAsync(
            string serviceAccountId,
            string workspaceId,
            global::Anthropic.BetaNoBillingWorkspaceRoleSchema workspaceRole,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}