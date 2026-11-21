#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Claude Code Managed Settings Configuration<br/>
        /// Change the organization's Claude Code managed settings mode, the RBAC Group order, or both, in one atomic write.<br/>
        /// To change the order, send `rbac_group_order` with the `rbac_group_order_version` from the read the change is based on. If the order has changed since that read, the request returns `409`: read it again and retry. To switch modes only if the order has not changed, send the current `rbac_group_order` and `rbac_group_order_version` with the new `mode`.<br/>
        /// A switch to `rbac_groups` mode with no RBAC Group settings and no default settings copies the organization settings into a new default, in the same write, so members keep the settings they had. The copy does not follow later changes to the organization settings. If the organization settings cannot be copied, the request returns `400` and changes nothing. If they cannot be read, are over 1 MiB or are not valid, setting the default settings first avoids the copy.<br/>
        /// After a switch to `rbac_groups` mode, a member in no listed RBAC Group receives the default settings, or no settings if no default is set, not the organization settings.<br/>
        /// **Accepted credentials:** an organization-level Admin API key with the `write:claude_code_managed_settings` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-claude-code-managed-settings-2026-10-06`. A request without it, or from an organization not enabled for this beta, returns `404`. The Claude Code Managed Settings API is in beta and is available to Claude Enterprise organizations only.<br/>
        /// A write that returns `503` may have applied. Retrying it is safe.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaClaudeCodeManagedSettingsConfiguration> BetaUpdateClaudeCodeManagedSettingsConfigurationV1OrganizationsClaudeCodeManagedSettingsConfigurationPostAsync(
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,

            global::Anthropic.BetaClaudeCodeManagedSettingsConfigurationUpdateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Claude Code Managed Settings Configuration<br/>
        /// Change the organization's Claude Code managed settings mode, the RBAC Group order, or both, in one atomic write.<br/>
        /// To change the order, send `rbac_group_order` with the `rbac_group_order_version` from the read the change is based on. If the order has changed since that read, the request returns `409`: read it again and retry. To switch modes only if the order has not changed, send the current `rbac_group_order` and `rbac_group_order_version` with the new `mode`.<br/>
        /// A switch to `rbac_groups` mode with no RBAC Group settings and no default settings copies the organization settings into a new default, in the same write, so members keep the settings they had. The copy does not follow later changes to the organization settings. If the organization settings cannot be copied, the request returns `400` and changes nothing. If they cannot be read, are over 1 MiB or are not valid, setting the default settings first avoids the copy.<br/>
        /// After a switch to `rbac_groups` mode, a member in no listed RBAC Group receives the default settings, or no settings if no default is set, not the organization settings.<br/>
        /// **Accepted credentials:** an organization-level Admin API key with the `write:claude_code_managed_settings` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-claude-code-managed-settings-2026-10-06`. A request without it, or from an organization not enabled for this beta, returns `404`. The Claude Code Managed Settings API is in beta and is available to Claude Enterprise organizations only.<br/>
        /// A write that returns `503` may have applied. Retrying it is safe.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaClaudeCodeManagedSettingsConfiguration>> BetaUpdateClaudeCodeManagedSettingsConfigurationV1OrganizationsClaudeCodeManagedSettingsConfigurationPostAsResponseAsync(
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,

            global::Anthropic.BetaClaudeCodeManagedSettingsConfigurationUpdateParams request,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Claude Code Managed Settings Configuration<br/>
        /// Change the organization's Claude Code managed settings mode, the RBAC Group order, or both, in one atomic write.<br/>
        /// To change the order, send `rbac_group_order` with the `rbac_group_order_version` from the read the change is based on. If the order has changed since that read, the request returns `409`: read it again and retry. To switch modes only if the order has not changed, send the current `rbac_group_order` and `rbac_group_order_version` with the new `mode`.<br/>
        /// A switch to `rbac_groups` mode with no RBAC Group settings and no default settings copies the organization settings into a new default, in the same write, so members keep the settings they had. The copy does not follow later changes to the organization settings. If the organization settings cannot be copied, the request returns `400` and changes nothing. If they cannot be read, are over 1 MiB or are not valid, setting the default settings first avoids the copy.<br/>
        /// After a switch to `rbac_groups` mode, a member in no listed RBAC Group receives the default settings, or no settings if no default is set, not the organization settings.<br/>
        /// **Accepted credentials:** an organization-level Admin API key with the `write:claude_code_managed_settings` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-claude-code-managed-settings-2026-10-06`. A request without it, or from an organization not enabled for this beta, returns `404`. The Claude Code Managed Settings API is in beta and is available to Claude Enterprise organizations only.<br/>
        /// A write that returns `503` may have applied. Retrying it is safe.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-claude-code-managed-settings-2026-10-06` in this header.
        /// </param>
        /// <param name="mode">
        /// The new mode, as an object such as `{"type": "rbac_groups"}`.
        /// </param>
        /// <param name="rbacGroupOrder">
        /// Every RBAC Group that has settings, each listed once, in the new order, highest precedence first. Requires `rbac_group_order_version`.
        /// </param>
        /// <param name="rbacGroupOrderVersion">
        /// The `rbac_group_order_version` from the read this change is based on. Requires `rbac_group_order`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaClaudeCodeManagedSettingsConfiguration> BetaUpdateClaudeCodeManagedSettingsConfigurationV1OrganizationsClaudeCodeManagedSettingsConfigurationPostAsync(
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            string? anthropicVersion = default,
            global::Anthropic.BetaClaudeCodeManagedSettingsModeParams? mode = default,
            global::System.Collections.Generic.IList<string>? rbacGroupOrder = default,
            string? rbacGroupOrderVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}