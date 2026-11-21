#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get RBAC Group Claude Code Managed Settings<br/>
        /// Retrieve an RBAC Group's Claude Code managed settings.<br/>
        /// **Accepted credentials:** an organization-level Admin API key with the `read:claude_code_managed_settings` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-claude-code-managed-settings-2026-10-06`. A request without it, or from an organization not enabled for this beta, returns `404`. The Claude Code Managed Settings API is in beta and is available to Claude Enterprise organizations only.
        /// </summary>
        /// <param name="rbacGroupId">
        /// The RBAC Group's ID, prefixed `rbac_group_`.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-claude-code-managed-settings-2026-10-06` in this header.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettings> BetaGetClaudeCodeRbacGroupManagedSettingsV1OrganizationsClaudeCodeManagedSettingsRbacGroupsRbacGroupIdGetAsync(
            string rbacGroupId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get RBAC Group Claude Code Managed Settings<br/>
        /// Retrieve an RBAC Group's Claude Code managed settings.<br/>
        /// **Accepted credentials:** an organization-level Admin API key with the `read:claude_code_managed_settings` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-claude-code-managed-settings-2026-10-06`. A request without it, or from an organization not enabled for this beta, returns `404`. The Claude Code Managed Settings API is in beta and is available to Claude Enterprise organizations only.
        /// </summary>
        /// <param name="rbacGroupId">
        /// The RBAC Group's ID, prefixed `rbac_group_`.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-claude-code-managed-settings-2026-10-06` in this header.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettings>> BetaGetClaudeCodeRbacGroupManagedSettingsV1OrganizationsClaudeCodeManagedSettingsRbacGroupsRbacGroupIdGetAsResponseAsync(
            string rbacGroupId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}