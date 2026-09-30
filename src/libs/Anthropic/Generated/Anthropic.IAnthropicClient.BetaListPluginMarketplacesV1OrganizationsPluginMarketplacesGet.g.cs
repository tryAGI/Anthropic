#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Plugin Marketplaces<br/>
        /// List the plugin marketplaces Plugins live in, newest first: the organization's own<br/>
        /// and its members' personal ones.<br/>
        /// Plugin marketplaces are created, connected to a repository and deleted in<br/>
        /// claude.ai, not through this API. The organization's library marketplace, the<br/>
        /// organization-owned `manual` marketplace that uploads go to when no marketplace is<br/>
        /// named, is created the first time something is put in it and is listed from then on.<br/>
        /// **Accepted credentials:** an Admin API key with the `read:plugins` or `read:org_audit` scope, or a Compliance Access Key with the `read:compliance_org_data` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `1000`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="ownerType">
        /// `organization` for the organization's plugin marketplaces, `user` for members' personal plugin marketplaces.
        /// </param>
        /// <param name="source">
        /// Only plugin marketplaces with this `source`: `manual` for those whose Plugins are uploaded; `github`, `gitlab` or `public_git` for those synchronized from a Git repository. `directory` (Anthropic's catalog) is never listed here.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaPluginMarketplaceList> BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetAsync(
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType? ownerType = default,
            global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource? source = default,
            string? organizationId = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Plugin Marketplaces<br/>
        /// List the plugin marketplaces Plugins live in, newest first: the organization's own<br/>
        /// and its members' personal ones.<br/>
        /// Plugin marketplaces are created, connected to a repository and deleted in<br/>
        /// claude.ai, not through this API. The organization's library marketplace, the<br/>
        /// organization-owned `manual` marketplace that uploads go to when no marketplace is<br/>
        /// named, is created the first time something is put in it and is listed from then on.<br/>
        /// **Accepted credentials:** an Admin API key with the `read:plugins` or `read:org_audit` scope, or a Compliance Access Key with the `read:compliance_org_data` scope.<br/>
        /// Every request must include the beta header `anthropic-beta: ce-plugins-2026-09-01`. A request without it returns `404`, exactly as if the endpoint did not exist. The Plugins API is in beta and is available to Claude Enterprise organizations only. It is not available to Claude Platform (Claude Console) organizations, or to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `1000`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="ownerType">
        /// `organization` for the organization's plugin marketplaces, `user` for members' personal plugin marketplaces.
        /// </param>
        /// <param name="source">
        /// Only plugin marketplaces with this `source`: `manual` for those whose Plugins are uploaded; `github`, `gitlab` or `public_git` for those synchronized from a Git repository. `directory` (Anthropic's catalog) is never listed here.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaPluginMarketplaceList>> BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetAsResponseAsync(
            int? limit = default,
            string? page = default,
            global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType? ownerType = default,
            global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource? source = default,
            string? organizationId = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaPluginMarketplace&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `1000`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="ownerType">
        /// `organization` for the organization's plugin marketplaces, `user` for members' personal plugin marketplaces.
        /// </param>
        /// <param name="source">
        /// Only plugin marketplaces with this `source`: `manual` for those whose Plugins are uploaded; `github`, `gitlab` or `public_git` for those synchronized from a Git repository. `directory` (Anthropic's catalog) is never listed here.
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
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaPluginMarketplace> BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetAutoPagingAsync(
              int? limit = default,
            global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType? ownerType = default,
            global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource? source = default,
            string? organizationId = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}