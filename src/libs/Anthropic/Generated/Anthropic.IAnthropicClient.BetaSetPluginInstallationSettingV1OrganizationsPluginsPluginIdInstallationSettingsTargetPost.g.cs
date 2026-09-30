#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Set Plugin Installation Setting<br/>
        /// Set or change an organization-owned Plugin's installation setting for the whole<br/>
        /// organization or for one RBAC Group.<br/>
        /// Writing the value a target already holds of its own changes nothing.<br/>
        /// A member-owned Plugin has shares instead of installation settings, so this path<br/>
        /// returns 404 for one.<br/>
        /// Send a Plugin's installation-setting writes one at a time. If several writes for the<br/>
        /// same Plugin arrive at the same time, the server handles them one after another and<br/>
        /// can answer some of them with `503` instead of applying them. That `503` carries<br/>
        /// `x-should-retry: true`, and the write is safe to repeat: wait a second or two, then<br/>
        /// send it again.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="target">
        /// The target whose setting is written: the literal `organization` for the Plugin's organization-wide setting, or an RBAC Group's ID (prefixed `rbac_group_`) for that group's own setting. Writing the `organization` target stops the Plugin from inheriting its marketplace's default, even when the value written equals that default.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginInstallationSetting> BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostAsync(
            string pluginId,
            string target,

            global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Plugin Installation Setting<br/>
        /// Set or change an organization-owned Plugin's installation setting for the whole<br/>
        /// organization or for one RBAC Group.<br/>
        /// Writing the value a target already holds of its own changes nothing.<br/>
        /// A member-owned Plugin has shares instead of installation settings, so this path<br/>
        /// returns 404 for one.<br/>
        /// Send a Plugin's installation-setting writes one at a time. If several writes for the<br/>
        /// same Plugin arrive at the same time, the server handles them one after another and<br/>
        /// can answer some of them with `503` instead of applying them. That `503` carries<br/>
        /// `x-should-retry: true`, and the write is safe to repeat: wait a second or two, then<br/>
        /// send it again.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="target">
        /// The target whose setting is written: the literal `organization` for the Plugin's organization-wide setting, or an RBAC Group's ID (prefixed `rbac_group_`) for that group's own setting. Writing the `organization` target stops the Plugin from inheriting its marketplace's default, even when the value written equals that default.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPluginInstallationSetting>> BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostAsResponseAsync(
            string pluginId,
            string target,

            global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Plugin Installation Setting<br/>
        /// Set or change an organization-owned Plugin's installation setting for the whole<br/>
        /// organization or for one RBAC Group.<br/>
        /// Writing the value a target already holds of its own changes nothing.<br/>
        /// A member-owned Plugin has shares instead of installation settings, so this path<br/>
        /// returns 404 for one.<br/>
        /// Send a Plugin's installation-setting writes one at a time. If several writes for the<br/>
        /// same Plugin arrive at the same time, the server handles them one after another and<br/>
        /// can answer some of them with `503` instead of applying them. That `503` carries<br/>
        /// `x-should-retry: true`, and the write is safe to repeat: wait a second or two, then<br/>
        /// send it again.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="target">
        /// The target whose setting is written: the literal `organization` for the Plugin's organization-wide setting, or an RBAC Group's ID (prefixed `rbac_group_`) for that group's own setting. Writing the `organization` target stops the Plugin from inheriting its marketplace's default, even when the value written equals that default.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="installationPreference">
        /// The installation setting the target is to hold for this Plugin: one of `required`, `auto_install`, `available`, `not_available`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginInstallationSetting> BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostAsync(
            string pluginId,
            string target,
            global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequestInstallationPreference installationPreference,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}