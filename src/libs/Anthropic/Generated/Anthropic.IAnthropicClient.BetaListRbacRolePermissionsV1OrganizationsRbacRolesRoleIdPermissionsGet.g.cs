#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List RBAC Role Permissions<br/>
        /// List the permissions an RBAC Role grants.<br/>
        /// The RBAC Roles API is available to Claude Enterprise organizations only.
        /// </summary>
        /// <param name="rbacRoleId">
        /// ID of the RBAC Role.
        /// </param>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `1000`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaRbacRolePermissionList> BetaListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetAsync(
            string rbacRoleId,
            int? limit = default,
            string? page = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List RBAC Role Permissions<br/>
        /// List the permissions an RBAC Role grants.<br/>
        /// The RBAC Roles API is available to Claude Enterprise organizations only.
        /// </summary>
        /// <param name="rbacRoleId">
        /// ID of the RBAC Role.
        /// </param>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `1000`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaRbacRolePermissionList>> BetaListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetAsResponseAsync(
            string rbacRoleId,
            int? limit = default,
            string? page = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaRbacRolePermission&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="rbacRoleId">
        /// ID of the RBAC Role.
        /// </param>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `1000`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaRbacRolePermission> BetaListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetAutoPagingAsync(
            string rbacRoleId,             int? limit = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}