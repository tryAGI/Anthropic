#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List User Profiles
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="order">
        /// The direction that a list of user profiles is sorted in.
        /// </param>
        /// <param name="orderBy">
        /// Sort field for listing user profiles: `created_at` (default) or `name` (case-insensitive; profiles without a name sort last).
        /// </param>
        /// <param name="enforcementStatus"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.ListUserProfilesResponse> ListUserProfilesAsync(
            string? anthropicVersion = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.UserProfileListOrder? order = default,
            global::Anthropic.UserProfileListOrderBy? orderBy = default,
            global::System.Collections.Generic.IList<global::Anthropic.UserProfileEnforcementStatus>? enforcementStatus = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List User Profiles
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="order">
        /// The direction that a list of user profiles is sorted in.
        /// </param>
        /// <param name="orderBy">
        /// Sort field for listing user profiles: `created_at` (default) or `name` (case-insensitive; profiles without a name sort last).
        /// </param>
        /// <param name="enforcementStatus"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.ListUserProfilesResponse>> ListUserProfilesAsResponseAsync(
            string? anthropicVersion = default,
            int? limit = default,
            string? page = default,
            global::Anthropic.UserProfileListOrder? order = default,
            global::Anthropic.UserProfileListOrderBy? orderBy = default,
            global::System.Collections.Generic.IList<global::Anthropic.UserProfileEnforcementStatus>? enforcementStatus = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListUserProfilesAsync as an IAsyncEnumerable&lt;global::Anthropic.UserProfile&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="limit"></param>
        /// <param name="order">
        /// The direction that a list of user profiles is sorted in.
        /// </param>
        /// <param name="orderBy">
        /// Sort field for listing user profiles: `created_at` (default) or `name` (case-insensitive; profiles without a name sort last).
        /// </param>
        /// <param name="enforcementStatus"></param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.UserProfile> ListUserProfilesAutoPagingAsync(
              string? anthropicVersion = default,
            int? limit = default,
            global::Anthropic.UserProfileListOrder? order = default,
            global::Anthropic.UserProfileListOrderBy? orderBy = default,
            global::System.Collections.Generic.IList<global::Anthropic.UserProfileEnforcementStatus>? enforcementStatus = default,
            string? anthropicWorkspaceId = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}