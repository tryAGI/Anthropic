#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Remove Plugin Installation Setting<br/>
        /// Remove an organization-owned Plugin's own installation setting for the whole<br/>
        /// organization or for one RBAC Group.<br/>
        /// Removing the `organization` target returns the Plugin to its marketplace's default<br/>
        /// installation setting and leaves the groups' settings in place. Removing a group's<br/>
        /// setting makes the group's members fall back to the Plugin's organization-wide setting<br/>
        /// or to the settings of their other groups.<br/>
        /// A target that holds no setting of its own returns 404 (a Plugin that already inherits<br/>
        /// its marketplace's default holds no `organization` setting), and so does a member-owned<br/>
        /// Plugin.<br/>
        /// A removal counts as one of the Plugin's installation-setting writes: send all of those<br/>
        /// writes one at a time. If several arrive for the same Plugin at the same time, the server<br/>
        /// handles them one after another and can answer some of them with `503` and<br/>
        /// `x-should-retry: true` instead of applying them; wait a second or two and send the<br/>
        /// removal again. A `404` on the repeat means the setting is already gone.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="target">
        /// The target whose own setting is removed: the literal `organization` for the Plugin's organization-wide setting, or an RBAC Group's ID (prefixed `rbac_group_`) for that group's own setting. Removing the `organization` setting returns the Plugin to its marketplace's default.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginInstallationSettingDeleted> BetaRemovePluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetDeleteAsync(
            string pluginId,
            string target,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Plugin Installation Setting<br/>
        /// Remove an organization-owned Plugin's own installation setting for the whole<br/>
        /// organization or for one RBAC Group.<br/>
        /// Removing the `organization` target returns the Plugin to its marketplace's default<br/>
        /// installation setting and leaves the groups' settings in place. Removing a group's<br/>
        /// setting makes the group's members fall back to the Plugin's organization-wide setting<br/>
        /// or to the settings of their other groups.<br/>
        /// A target that holds no setting of its own returns 404 (a Plugin that already inherits<br/>
        /// its marketplace's default holds no `organization` setting), and so does a member-owned<br/>
        /// Plugin.<br/>
        /// A removal counts as one of the Plugin's installation-setting writes: send all of those<br/>
        /// writes one at a time. If several arrive for the same Plugin at the same time, the server<br/>
        /// handles them one after another and can answer some of them with `503` and<br/>
        /// `x-should-retry: true` instead of applying them; wait a second or two and send the<br/>
        /// removal again. A `404` on the repeat means the setting is already gone.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="target">
        /// The target whose own setting is removed: the literal `organization` for the Plugin's organization-wide setting, or an RBAC Group's ID (prefixed `rbac_group_`) for that group's own setting. Removing the `organization` setting returns the Plugin to its marketplace's default.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPluginInstallationSettingDeleted>> BetaRemovePluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetDeleteAsResponseAsync(
            string pluginId,
            string target,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}