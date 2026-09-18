#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Remove RBAC Group Member<br/>
        /// Remove a User from an RBAC Group. Membership of groups provisioned by an identity provider (source type `"scim"`) cannot be modified via the API while an organization in the tenant uses SCIM provisioning.<br/>
        /// The RBAC Groups API is available to Claude Enterprise organizations only.
        /// </summary>
        /// <param name="rbacGroupId">
        /// ID of the RBAC Group.
        /// </param>
        /// <param name="userId">
        /// ID of the User.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaDeleteRbacGroupMemberResponse> BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteAsync(
            string rbacGroupId,
            string userId,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove RBAC Group Member<br/>
        /// Remove a User from an RBAC Group. Membership of groups provisioned by an identity provider (source type `"scim"`) cannot be modified via the API while an organization in the tenant uses SCIM provisioning.<br/>
        /// The RBAC Groups API is available to Claude Enterprise organizations only.
        /// </summary>
        /// <param name="rbacGroupId">
        /// ID of the RBAC Group.
        /// </param>
        /// <param name="userId">
        /// ID of the User.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaDeleteRbacGroupMemberResponse>> BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteAsResponseAsync(
            string rbacGroupId,
            string userId,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}