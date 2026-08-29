#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Workspace Member
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the Workspace.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaWorkspaceMemberSchema> BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostAsync(
            string workspaceId,

            global::Anthropic.BetaCreateWorkspaceMemberParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace Member
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the Workspace.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaWorkspaceMemberSchema>> BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostAsResponseAsync(
            string workspaceId,

            global::Anthropic.BetaCreateWorkspaceMemberParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace Member
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the Workspace.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="userId">
        /// ID of the User.
        /// </param>
        /// <param name="workspaceRole">
        /// Role of the new Workspace Member. Cannot be `workspace_billing`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaWorkspaceMemberSchema> BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostAsync(
            string workspaceId,
            string userId,
            global::Anthropic.BetaNoBillingWorkspaceRoleSchema workspaceRole,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}