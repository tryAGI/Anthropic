#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Plugin<br/>
        /// Change which stored version of an organization-owned Plugin is served to members,<br/>
        /// for example to roll back to an earlier one. This pins the served version: later<br/>
        /// uploads are stored but no longer change what is served, and pinning cannot currently<br/>
        /// be undone, here or in claude.ai.<br/>
        /// Pass the version as `served_version_id`: an earlier one to roll back, a later one to<br/>
        /// start serving a version that was stored without being served, or the one already<br/>
        /// served to pin it without changing what is served. No new version is created.<br/>
        /// When the organization has content scanning enabled, a version whose scan is still<br/>
        /// running is refused with a 409 (`error_code` `scan_pending`; retry once the scan<br/>
        /// finishes) and one whose scan failed, errored or reached no verdict with a 400<br/>
        /// (`scan_failed`; a `warn` is accepted). When the Plugin is in the organization's<br/>
        /// library marketplace, a version other than the one served is also refused with a 409<br/>
        /// when one of its skills has a name that an organization skill (one an administrator<br/>
        /// uploaded for the whole organization in claude.ai) has since taken: `error_code`<br/>
        /// `skill_name_taken`, with that name in `details.skill_name`. A member-owned Plugin<br/>
        /// cannot be updated here (403).<br/>
        /// This endpoint does not write installation settings; they are written at<br/>
        /// `/v1/organizations/plugins/{plugin_id}/installation_settings/{target}`.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPlugin> BetaUpdatePluginV1OrganizationsPluginsPluginIdPostAsync(
            string pluginId,

            global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Plugin<br/>
        /// Change which stored version of an organization-owned Plugin is served to members,<br/>
        /// for example to roll back to an earlier one. This pins the served version: later<br/>
        /// uploads are stored but no longer change what is served, and pinning cannot currently<br/>
        /// be undone, here or in claude.ai.<br/>
        /// Pass the version as `served_version_id`: an earlier one to roll back, a later one to<br/>
        /// start serving a version that was stored without being served, or the one already<br/>
        /// served to pin it without changing what is served. No new version is created.<br/>
        /// When the organization has content scanning enabled, a version whose scan is still<br/>
        /// running is refused with a 409 (`error_code` `scan_pending`; retry once the scan<br/>
        /// finishes) and one whose scan failed, errored or reached no verdict with a 400<br/>
        /// (`scan_failed`; a `warn` is accepted). When the Plugin is in the organization's<br/>
        /// library marketplace, a version other than the one served is also refused with a 409<br/>
        /// when one of its skills has a name that an organization skill (one an administrator<br/>
        /// uploaded for the whole organization in claude.ai) has since taken: `error_code`<br/>
        /// `skill_name_taken`, with that name in `details.skill_name`. A member-owned Plugin<br/>
        /// cannot be updated here (403).<br/>
        /// This endpoint does not write installation settings; they are written at<br/>
        /// `/v1/organizations/plugins/{plugin_id}/installation_settings/{target}`.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPlugin>> BetaUpdatePluginV1OrganizationsPluginsPluginIdPostAsResponseAsync(
            string pluginId,

            global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Plugin<br/>
        /// Change which stored version of an organization-owned Plugin is served to members,<br/>
        /// for example to roll back to an earlier one. This pins the served version: later<br/>
        /// uploads are stored but no longer change what is served, and pinning cannot currently<br/>
        /// be undone, here or in claude.ai.<br/>
        /// Pass the version as `served_version_id`: an earlier one to roll back, a later one to<br/>
        /// start serving a version that was stored without being served, or the one already<br/>
        /// served to pin it without changing what is served. No new version is created.<br/>
        /// When the organization has content scanning enabled, a version whose scan is still<br/>
        /// running is refused with a 409 (`error_code` `scan_pending`; retry once the scan<br/>
        /// finishes) and one whose scan failed, errored or reached no verdict with a 400<br/>
        /// (`scan_failed`; a `warn` is accepted). When the Plugin is in the organization's<br/>
        /// library marketplace, a version other than the one served is also refused with a 409<br/>
        /// when one of its skills has a name that an organization skill (one an administrator<br/>
        /// uploaded for the whole organization in claude.ai) has since taken: `error_code`<br/>
        /// `skill_name_taken`, with that name in `details.skill_name`. A member-owned Plugin<br/>
        /// cannot be updated here (403).<br/>
        /// This endpoint does not write installation settings; they are written at<br/>
        /// `/v1/organizations/plugins/{plugin_id}/installation_settings/{target}`.<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="servedVersionId">
        /// Serve this version of the Plugin (prefixed `pluginver_`) and pin the served version to it; `latest` is not accepted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPlugin> BetaUpdatePluginV1OrganizationsPluginsPluginIdPostAsync(
            string pluginId,
            string servedVersionId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}