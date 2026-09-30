#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Delete Plugin<br/>
        /// Permanently delete a Plugin and every version it holds, exactly as when an<br/>
        /// administrator deletes it in claude.ai. The Plugin may belong to the organization or<br/>
        /// to a member, including a member who has since left the organization.<br/>
        /// An organization-owned Plugin's installation settings go with it; a member-owned<br/>
        /// Plugin's shares are withdrawn and its owner no longer has it.<br/>
        /// To take an organization-owned Plugin out of use reversibly, set its<br/>
        /// organization-wide installation setting to `not_available` instead (and<br/>
        /// remove or change any group settings, which override it for their members). Only a<br/>
        /// Plugin in a `manual` marketplace can be deleted here; one synchronized from a<br/>
        /// repository is removed by removing it from the repository (400).<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginDeleted> BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteAsync(
            string pluginId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Plugin<br/>
        /// Permanently delete a Plugin and every version it holds, exactly as when an<br/>
        /// administrator deletes it in claude.ai. The Plugin may belong to the organization or<br/>
        /// to a member, including a member who has since left the organization.<br/>
        /// An organization-owned Plugin's installation settings go with it; a member-owned<br/>
        /// Plugin's shares are withdrawn and its owner no longer has it.<br/>
        /// To take an organization-owned Plugin out of use reversibly, set its<br/>
        /// organization-wide installation setting to `not_available` instead (and<br/>
        /// remove or change any group settings, which override it for their members). Only a<br/>
        /// Plugin in a `manual` marketplace can be deleted here; one synchronized from a<br/>
        /// repository is removed by removing it from the repository (400).<br/>
        /// **Accepted credentials:** an Admin API key with the `write:plugins` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="pluginId">
        /// ID of the Plugin (prefixed `plugin_`).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `ce-plugins-2026-09-01` in this header.
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPluginDeleted>> BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteAsResponseAsync(
            string pluginId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}