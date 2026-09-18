#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get RBAC Group<br/>
        /// Retrieve an RBAC Group by ID.<br/>
        /// The RBAC Groups API is available to Claude Enterprise organizations only.
        /// </summary>
        /// <param name="rbacGroupId">
        /// ID of the RBAC Group.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaRbacGroup> BetaGetRbacGroupV1OrganizationsRbacGroupsGroupIdGetAsync(
            string rbacGroupId,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get RBAC Group<br/>
        /// Retrieve an RBAC Group by ID.<br/>
        /// The RBAC Groups API is available to Claude Enterprise organizations only.
        /// </summary>
        /// <param name="rbacGroupId">
        /// ID of the RBAC Group.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaRbacGroup>> BetaGetRbacGroupV1OrganizationsRbacGroupsGroupIdGetAsResponseAsync(
            string rbacGroupId,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}