#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Plugin Installation Settings<br/>
        /// List an organization-owned Plugin's installation settings, which say which<br/>
        /// members it is for, most recently created first.<br/>
        /// The list holds the Plugin's own organization-wide setting (absent while the Plugin<br/>
        /// inherits its marketplace's default) and each RBAC Group's own setting. A<br/>
        /// member-owned Plugin has shares instead, so this path returns 404 for one.<br/>
        /// **Accepted credentials:** an Admin API key with the `read:plugins` or `read:org_audit` scope, or a Compliance Access Key with the `read:compliance_org_data` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `100`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="targetType">
        /// Only settings for this kind of target: `organization` (the organization-wide setting) or `rbac_group` (an RBAC Group's).
        /// </param>
        /// <param name="organizationId">
        /// For a `read:org_audit` or `read:compliance_org_data` key created for all of a parent organization's linked organizations: a child organization of that parent to read instead of the organization the key was created in, given as the organization's UUID or its `org_`-prefixed ID. A value that is neither returns a 400; an organization that is not a child of the key's parent, or where the Plugins API is not available, returns a 404. Any other key may pass only its own organization's ID here; another organization returns a 404.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginInstallationSettingList> BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetAsync(
            string pluginId,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType? targetType = default,
            string? organizationId = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Plugin Installation Settings<br/>
        /// List an organization-owned Plugin's installation settings, which say which<br/>
        /// members it is for, most recently created first.<br/>
        /// The list holds the Plugin's own organization-wide setting (absent while the Plugin<br/>
        /// inherits its marketplace's default) and each RBAC Group's own setting. A<br/>
        /// member-owned Plugin has shares instead, so this path returns 404 for one.<br/>
        /// **Accepted credentials:** an Admin API key with the `read:plugins` or `read:org_audit` scope, or a Compliance Access Key with the `read:compliance_org_data` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `100`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="targetType">
        /// Only settings for this kind of target: `organization` (the organization-wide setting) or `rbac_group` (an RBAC Group's).
        /// </param>
        /// <param name="organizationId">
        /// For a `read:org_audit` or `read:compliance_org_data` key created for all of a parent organization's linked organizations: a child organization of that parent to read instead of the organization the key was created in, given as the organization's UUID or its `org_`-prefixed ID. A value that is neither returns a 400; an organization that is not a child of the key's parent, or where the Plugins API is not available, returns a 404. Any other key may pass only its own organization's ID here; another organization returns a 404.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPluginInstallationSettingList>> BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetAsResponseAsync(
            string pluginId,
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType? targetType = default,
            string? organizationId = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaPluginInstallationSetting&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `100`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="targetType">
        /// Only settings for this kind of target: `organization` (the organization-wide setting) or `rbac_group` (an RBAC Group's).
        /// </param>
        /// <param name="organizationId">
        /// For a `read:org_audit` or `read:compliance_org_data` key created for all of a parent organization's linked organizations: a child organization of that parent to read instead of the organization the key was created in, given as the organization's UUID or its `org_`-prefixed ID. A value that is neither returns a 400; an organization that is not a child of the key's parent, or where the Plugins API is not available, returns a 404. Any other key may pass only its own organization's ID here; another organization returns a 404.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaPluginInstallationSetting> BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetAutoPagingAsync(
            string pluginId,             int? limit = default,
            global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType? targetType = default,
            string? organizationId = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}