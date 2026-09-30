#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Plugin Version<br/>
        /// Retrieve one version of a Plugin by its ID, or the Plugin's newest version.<br/>
        /// **Accepted credentials:** an Admin API key with the `read:plugins` or `read:org_audit` scope, or a Compliance Access Key with the `read:compliance_org_data` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="version">
        /// ID of the Plugin Version (prefixed `pluginver_`), or `latest` for the newest one.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginVersion> BetaGetPluginVersionV1OrganizationsPluginsPluginIdVersionsVersionGetAsync(
            string pluginId,
            string version,
            string? organizationId = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Plugin Version<br/>
        /// Retrieve one version of a Plugin by its ID, or the Plugin's newest version.<br/>
        /// **Accepted credentials:** an Admin API key with the `read:plugins` or `read:org_audit` scope, or a Compliance Access Key with the `read:compliance_org_data` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="version">
        /// ID of the Plugin Version (prefixed `pluginver_`), or `latest` for the newest one.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPluginVersion>> BetaGetPluginVersionV1OrganizationsPluginsPluginIdVersionsVersionGetAsResponseAsync(
            string pluginId,
            string version,
            string? organizationId = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}