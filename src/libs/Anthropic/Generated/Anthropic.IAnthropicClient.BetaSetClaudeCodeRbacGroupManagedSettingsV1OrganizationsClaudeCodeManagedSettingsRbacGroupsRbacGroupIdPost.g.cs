#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Set RBAC Group Claude Code Managed Settings<br/>
        /// Create or replace an RBAC Group's Claude Code managed settings.<br/>
        /// New settings join the end of `rbac_group_order`, and existing settings keep their place. Until the group is moved up, its members who also belong to an earlier group keep that group's settings. In `organization` mode a write changes no member's settings until the organization switches to `rbac_groups` mode. Once a group has settings, that switch no longer copies the organization settings into default settings, so members in no RBAC Group in `rbac_group_order` receive no settings unless you set the default settings before the switch.<br/>
        /// Get the group's ID from the RBAC Groups API. One key can hold `read:rbac_groups` and `write:claude_code_managed_settings`.<br/>
        /// **Accepted credentials:** an organization-level Admin API key with the `write:claude_code_managed_settings` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-claude-code-managed-settings-2026-10-06`. A request without it, or from an organization not enabled for this beta, returns `404`. The Claude Code Managed Settings API is in beta and is available to Claude Enterprise organizations only.<br/>
        /// A write that returns `503` may have applied. Retrying it is safe.
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettings> BetaSetClaudeCodeRbacGroupManagedSettingsV1OrganizationsClaudeCodeManagedSettingsRbacGroupsRbacGroupIdPostAsync(
            string rbacGroupId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,

            global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSetParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set RBAC Group Claude Code Managed Settings<br/>
        /// Create or replace an RBAC Group's Claude Code managed settings.<br/>
        /// New settings join the end of `rbac_group_order`, and existing settings keep their place. Until the group is moved up, its members who also belong to an earlier group keep that group's settings. In `organization` mode a write changes no member's settings until the organization switches to `rbac_groups` mode. Once a group has settings, that switch no longer copies the organization settings into default settings, so members in no RBAC Group in `rbac_group_order` receive no settings unless you set the default settings before the switch.<br/>
        /// Get the group's ID from the RBAC Groups API. One key can hold `read:rbac_groups` and `write:claude_code_managed_settings`.<br/>
        /// **Accepted credentials:** an organization-level Admin API key with the `write:claude_code_managed_settings` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-claude-code-managed-settings-2026-10-06`. A request without it, or from an organization not enabled for this beta, returns `404`. The Claude Code Managed Settings API is in beta and is available to Claude Enterprise organizations only.<br/>
        /// A write that returns `503` may have applied. Retrying it is safe.
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettings>> BetaSetClaudeCodeRbacGroupManagedSettingsV1OrganizationsClaudeCodeManagedSettingsRbacGroupsRbacGroupIdPostAsResponseAsync(
            string rbacGroupId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,

            global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSetParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set RBAC Group Claude Code Managed Settings<br/>
        /// Create or replace an RBAC Group's Claude Code managed settings.<br/>
        /// New settings join the end of `rbac_group_order`, and existing settings keep their place. Until the group is moved up, its members who also belong to an earlier group keep that group's settings. In `organization` mode a write changes no member's settings until the organization switches to `rbac_groups` mode. Once a group has settings, that switch no longer copies the organization settings into default settings, so members in no RBAC Group in `rbac_group_order` receive no settings unless you set the default settings before the switch.<br/>
        /// Get the group's ID from the RBAC Groups API. One key can hold `read:rbac_groups` and `write:claude_code_managed_settings`.<br/>
        /// **Accepted credentials:** an organization-level Admin API key with the `write:claude_code_managed_settings` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-claude-code-managed-settings-2026-10-06`. A request without it, or from an organization not enabled for this beta, returns `404`. The Claude Code Managed Settings API is in beta and is available to Claude Enterprise organizations only.<br/>
        /// A write that returns `503` may have applied. Retrying it is safe.
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
        /// <param name="settings">
        /// The whole settings document, a JSON object of Claude Code managed settings. It replaces any stored document. At most 1 MiB as the server stores it, which can be larger than the request body.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettings> BetaSetClaudeCodeRbacGroupManagedSettingsV1OrganizationsClaudeCodeManagedSettingsRbacGroupsRbacGroupIdPostAsync(
            string rbacGroupId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            object settings,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}