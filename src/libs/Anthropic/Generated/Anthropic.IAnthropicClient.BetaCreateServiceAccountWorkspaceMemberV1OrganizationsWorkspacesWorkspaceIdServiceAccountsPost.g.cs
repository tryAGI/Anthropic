#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Service Account Workspace Member<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Add a service account to a workspace with the given `workspace_role`.<br/>
        /// The role determines what the service account can do in the workspace and<br/>
        /// which workspace-scoped permissions it can be granted when authenticating<br/>
        /// through federation. Every service account is already an implicit<br/>
        /// `workspace_user` member of the default workspace; adding it explicitly<br/>
        /// assigns a chosen role. If the service account is already an explicit<br/>
        /// member of the workspace, its `workspace_role` is replaced with the<br/>
        /// value supplied here. Archived workspaces return 400. Archived service<br/>
        /// accounts cannot be added and are rejected.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the workspace.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaServiceAccountWorkspaceMember> BetaCreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostAsync(
            string workspaceId,

            global::Anthropic.BetaServiceAccountWorkspaceMemberCreateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Service Account Workspace Member<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Add a service account to a workspace with the given `workspace_role`.<br/>
        /// The role determines what the service account can do in the workspace and<br/>
        /// which workspace-scoped permissions it can be granted when authenticating<br/>
        /// through federation. Every service account is already an implicit<br/>
        /// `workspace_user` member of the default workspace; adding it explicitly<br/>
        /// assigns a chosen role. If the service account is already an explicit<br/>
        /// member of the workspace, its `workspace_role` is replaced with the<br/>
        /// value supplied here. Archived workspaces return 400. Archived service<br/>
        /// accounts cannot be added and are rejected.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the workspace.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaServiceAccountWorkspaceMember>> BetaCreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostAsResponseAsync(
            string workspaceId,

            global::Anthropic.BetaServiceAccountWorkspaceMemberCreateParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Service Account Workspace Member<br/>
        /// **Requires an OAuth access token with the `org:admin` scope**, from `ant auth login --scope org:admin` or a workload identity federation rule; Admin API keys are not accepted. See [Manage WIF with the Admin API](/docs/en/manage-claude/wif-admin-api).<br/>
        /// Add a service account to a workspace with the given `workspace_role`.<br/>
        /// The role determines what the service account can do in the workspace and<br/>
        /// which workspace-scoped permissions it can be granted when authenticating<br/>
        /// through federation. Every service account is already an implicit<br/>
        /// `workspace_user` member of the default workspace; adding it explicitly<br/>
        /// assigns a chosen role. If the service account is already an explicit<br/>
        /// member of the workspace, its `workspace_role` is replaced with the<br/>
        /// value supplied here. Archived workspaces return 400. Archived service<br/>
        /// accounts cannot be added and are rejected.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the workspace.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="serviceAccountId">
        /// Tagged service account ID to add.
        /// </param>
        /// <param name="workspaceRole">
        /// Role to assign to the service account in this workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaServiceAccountWorkspaceMember> BetaCreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostAsync(
            string workspaceId,
            string serviceAccountId,
            global::Anthropic.BetaNoBillingWorkspaceRoleSchema workspaceRole,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}