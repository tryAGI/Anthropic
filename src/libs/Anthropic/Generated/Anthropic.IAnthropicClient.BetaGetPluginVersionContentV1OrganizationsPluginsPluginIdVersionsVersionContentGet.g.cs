#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Download Plugin Version Archive<br/>
        /// Download one version's `.zip` archive, exactly as stored. Each download of a<br/>
        /// Plugin from a member's personal plugin marketplace is recorded on the Compliance API<br/>
        /// activity feed.<br/>
        /// The response body is the archive (`Content-Type: application/zip`), sent as an<br/>
        /// attachment whose filename is derived from the Plugin's name; name saved files from<br/>
        /// the IDs in the request path, since that filename is not unique.<br/>
        /// **Accepted credentials:** an Admin API key with the `read:plugins` or `read:org_audit` scope, or a Compliance Access Key with the `read:compliance_org_data` scope.<br/>
        /// Every read scope above (`read:plugins`, `read:org_audit`, and<br/>
        /// `read:compliance_org_data`) can download the files of plugins in members' personal<br/>
        /// marketplaces, including files that claude.ai's admin settings do not show, and a<br/>
        /// `read:org_audit` or `read:compliance_org_data` key created for all of your parent<br/>
        /// organization's linked organizations can do this in any organization under it that has<br/>
        /// access to this API, by passing `organization_id`. Each such download records a<br/>
        /// `claude_plugin_archive_accessed` event on the Compliance API activity feed,<br/>
        /// identifying the key, the plugin, the version, and the member. Downloads of<br/>
        /// organization-owned plugins are not recorded.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="version">
        /// ID of the Plugin Version (prefixed `pluginver_`). `latest` is not accepted here.
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
        global::System.Threading.Tasks.Task<byte[]> BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetAsync(
            string pluginId,
            string version,
            string? organizationId = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download Plugin Version Archive<br/>
        /// Download one version's `.zip` archive, exactly as stored. Each download of a<br/>
        /// Plugin from a member's personal plugin marketplace is recorded on the Compliance API<br/>
        /// activity feed.<br/>
        /// The response body is the archive (`Content-Type: application/zip`), sent as an<br/>
        /// attachment whose filename is derived from the Plugin's name; name saved files from<br/>
        /// the IDs in the request path, since that filename is not unique.<br/>
        /// **Accepted credentials:** an Admin API key with the `read:plugins` or `read:org_audit` scope, or a Compliance Access Key with the `read:compliance_org_data` scope.<br/>
        /// Every read scope above (`read:plugins`, `read:org_audit`, and<br/>
        /// `read:compliance_org_data`) can download the files of plugins in members' personal<br/>
        /// marketplaces, including files that claude.ai's admin settings do not show, and a<br/>
        /// `read:org_audit` or `read:compliance_org_data` key created for all of your parent<br/>
        /// organization's linked organizations can do this in any organization under it that has<br/>
        /// access to this API, by passing `organization_id`. Each such download records a<br/>
        /// `claude_plugin_archive_accessed` event on the Compliance API activity feed,<br/>
        /// identifying the key, the plugin, the version, and the member. Downloads of<br/>
        /// organization-owned plugins are not recorded.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="version">
        /// ID of the Plugin Version (prefixed `pluginver_`). `latest` is not accepted here.
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
        global::System.Threading.Tasks.Task<global::System.IO.Stream> BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetAsStreamAsync(
            string pluginId,
            string version,
            string? organizationId = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download Plugin Version Archive<br/>
        /// Download one version's `.zip` archive, exactly as stored. Each download of a<br/>
        /// Plugin from a member's personal plugin marketplace is recorded on the Compliance API<br/>
        /// activity feed.<br/>
        /// The response body is the archive (`Content-Type: application/zip`), sent as an<br/>
        /// attachment whose filename is derived from the Plugin's name; name saved files from<br/>
        /// the IDs in the request path, since that filename is not unique.<br/>
        /// **Accepted credentials:** an Admin API key with the `read:plugins` or `read:org_audit` scope, or a Compliance Access Key with the `read:compliance_org_data` scope.<br/>
        /// Every read scope above (`read:plugins`, `read:org_audit`, and<br/>
        /// `read:compliance_org_data`) can download the files of plugins in members' personal<br/>
        /// marketplaces, including files that claude.ai's admin settings do not show, and a<br/>
        /// `read:org_audit` or `read:compliance_org_data` key created for all of your parent<br/>
        /// organization's linked organizations can do this in any organization under it that has<br/>
        /// access to this API, by passing `organization_id`. Each such download records a<br/>
        /// `claude_plugin_archive_accessed` event on the Compliance API activity feed,<br/>
        /// identifying the key, the plugin, the version, and the member. Downloads of<br/>
        /// organization-owned plugins are not recorded.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="version">
        /// ID of the Plugin Version (prefixed `pluginver_`). `latest` is not accepted here.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<byte[]>> BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetAsResponseAsync(
            string pluginId,
            string version,
            string? organizationId = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}