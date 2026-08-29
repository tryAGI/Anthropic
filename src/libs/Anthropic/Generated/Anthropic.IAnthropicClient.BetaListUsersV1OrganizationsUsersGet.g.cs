#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Users<br/>
        /// List the organization's members.
        /// </summary>
        /// <param name="beforeId">
        /// ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately before this object.
        /// </param>
        /// <param name="afterId">
        /// ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately after this object.
        /// </param>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `1000`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="email">
        /// Filter by user email.
        /// </param>
        /// <param name="roles">
        /// Filter to items whose `role` equals one of the supplied values. Repeatable; values are OR'ed together.<br/>
        /// Accepted values depend on the organization type: Console and API organizations accept `user`, `developer`, `billing`, `admin`, and `claude_code_user`; Claude Enterprise organizations accept `user`, `owner`, `primary_owner`, `membership_admin`, and `managed`.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaListResponseUser> BetaListUsersV1OrganizationsUsersGetAsync(
            string? beforeId = default,
            string? afterId = default,
            int? limit = default,
            string? email = default,
            global::System.Collections.Generic.IList<string>? roles = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Users<br/>
        /// List the organization's members.
        /// </summary>
        /// <param name="beforeId">
        /// ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately before this object.
        /// </param>
        /// <param name="afterId">
        /// ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately after this object.
        /// </param>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `1000`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="email">
        /// Filter by user email.
        /// </param>
        /// <param name="roles">
        /// Filter to items whose `role` equals one of the supplied values. Repeatable; values are OR'ed together.<br/>
        /// Accepted values depend on the organization type: Console and API organizations accept `user`, `developer`, `billing`, `admin`, and `claude_code_user`; Claude Enterprise organizations accept `user`, `owner`, `primary_owner`, `membership_admin`, and `managed`.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListResponseUser>> BetaListUsersV1OrganizationsUsersGetAsResponseAsync(
            string? beforeId = default,
            string? afterId = default,
            int? limit = default,
            string? email = default,
            global::System.Collections.Generic.IList<string>? roles = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListUsersV1OrganizationsUsersGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaUser&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="beforeId">
        /// ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately before this object.
        /// </param>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `1000`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="email">
        /// Filter by user email.
        /// </param>
        /// <param name="roles">
        /// Filter to items whose `role` equals one of the supplied values. Repeatable; values are OR'ed together.<br/>
        /// Accepted values depend on the organization type: Console and API organizations accept `user`, `developer`, `billing`, `admin`, and `claude_code_user`; Claude Enterprise organizations accept `user`, `owner`, `primary_owner`, `membership_admin`, and `managed`.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="afterId">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaUser> BetaListUsersV1OrganizationsUsersGetAutoPagingAsync(
              string? beforeId = default,
            int? limit = default,
            string? email = default,
            global::System.Collections.Generic.IList<string>? roles = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? afterId = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}