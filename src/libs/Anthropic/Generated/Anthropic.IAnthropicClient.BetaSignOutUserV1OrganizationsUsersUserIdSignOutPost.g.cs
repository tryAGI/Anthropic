#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Sign Out User<br/>
        /// Sign a member out of Claude everywhere, without removing them from the organization. This ends their sign-in sessions and removes their trusted devices wherever they use Claude, including other organizations and individual plans. It also ends the OAuth tokens issued to them for this organization, so apps such as Claude Code must sign in again.<br/>
        /// A token can take up to an hour to stop working, though it almost always stops at once. The member keeps their role and can sign in again right away. To keep them out, remove them from the organization or, if your organization uses single sign-on, block them in your identity provider. Signing out does not end API keys, OAuth tokens that were not issued for this organization, or the member's Claude Code cloud sessions and routines.<br/>
        /// You cannot sign out the organization's primary owner or the person your API key or token acts for, and a request to sign out another owner, a member with owner permissions, or a membership admin may be refused. A refused request returns a `400` or `403` error that says why. If the request returns `503`, send it again to finish; anything already ended stays ended.<br/>
        /// Every request must include the beta header `anthropic-beta: admin-user-sign-out-2026-10-08`. A request without it returns `400`. Sign-out is in beta for Claude Enterprise organizations. In an organization where it is not enabled, a request returns `400` with `error_code` `organization_not_enrolled_in_beta`. In a Claude Enterprise organization, an API key needs the `write:members` scope; a key without it gets `403`.
        /// </summary>
        /// <param name="userId">
        /// ID of the User.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `admin-user-sign-out-2026-10-08` in this header.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaUser> BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostAsync(
            string userId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign Out User<br/>
        /// Sign a member out of Claude everywhere, without removing them from the organization. This ends their sign-in sessions and removes their trusted devices wherever they use Claude, including other organizations and individual plans. It also ends the OAuth tokens issued to them for this organization, so apps such as Claude Code must sign in again.<br/>
        /// A token can take up to an hour to stop working, though it almost always stops at once. The member keeps their role and can sign in again right away. To keep them out, remove them from the organization or, if your organization uses single sign-on, block them in your identity provider. Signing out does not end API keys, OAuth tokens that were not issued for this organization, or the member's Claude Code cloud sessions and routines.<br/>
        /// You cannot sign out the organization's primary owner or the person your API key or token acts for, and a request to sign out another owner, a member with owner permissions, or a membership admin may be refused. A refused request returns a `400` or `403` error that says why. If the request returns `503`, send it again to finish; anything already ended stays ended.<br/>
        /// Every request must include the beta header `anthropic-beta: admin-user-sign-out-2026-10-08`. A request without it returns `400`. Sign-out is in beta for Claude Enterprise organizations. In an organization where it is not enabled, a request returns `400` with `error_code` `organization_not_enrolled_in_beta`. In a Claude Enterprise organization, an API key needs the `write:members` scope; a key without it gets `403`.
        /// </summary>
        /// <param name="userId">
        /// ID of the User.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `admin-user-sign-out-2026-10-08` in this header.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaUser>> BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostAsResponseAsync(
            string userId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}