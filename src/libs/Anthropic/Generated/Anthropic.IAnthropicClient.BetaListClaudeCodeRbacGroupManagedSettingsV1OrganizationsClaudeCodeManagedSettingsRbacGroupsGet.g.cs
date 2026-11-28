#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List RBAC Group Claude Code Managed Settings<br/>
        /// List the RBAC Groups that have Claude Code managed settings, highest precedence first.<br/>
        /// Each entry gives the group's status and timestamps, not its settings. The list includes deleted groups that still have settings, and leaves out the default settings. If the order changes between pages, the request returns `409`: list again from the first page.<br/>
        /// **Accepted credentials:** an organization-level Admin API key with the `read:claude_code_managed_settings` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-claude-code-managed-settings-2026-10-06`. A request without it, or from an organization not enabled for this beta, returns `404`. The Claude Code Managed Settings API is in beta and is available to Claude Enterprise organizations only.
        /// </summary>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="limit"></param>
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsList> BetaListClaudeCodeRbacGroupManagedSettingsV1OrganizationsClaudeCodeManagedSettingsRbacGroupsGetAsync(
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            string? page = default,
            int? limit = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List RBAC Group Claude Code Managed Settings<br/>
        /// List the RBAC Groups that have Claude Code managed settings, highest precedence first.<br/>
        /// Each entry gives the group's status and timestamps, not its settings. The list includes deleted groups that still have settings, and leaves out the default settings. If the order changes between pages, the request returns `409`: list again from the first page.<br/>
        /// **Accepted credentials:** an organization-level Admin API key with the `read:claude_code_managed_settings` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-claude-code-managed-settings-2026-10-06`. A request without it, or from an organization not enabled for this beta, returns `404`. The Claude Code Managed Settings API is in beta and is available to Claude Enterprise organizations only.
        /// </summary>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="limit"></param>
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsList>> BetaListClaudeCodeRbacGroupManagedSettingsV1OrganizationsClaudeCodeManagedSettingsRbacGroupsGetAsResponseAsync(
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            string? page = default,
            int? limit = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListClaudeCodeRbacGroupManagedSettingsV1OrganizationsClaudeCodeManagedSettingsRbacGroupsGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSummary&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-claude-code-managed-settings-2026-10-06` in this header.
        /// </param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSummary> BetaListClaudeCodeRbacGroupManagedSettingsV1OrganizationsClaudeCodeManagedSettingsRbacGroupsGetAutoPagingAsync(
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,             int? limit = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}