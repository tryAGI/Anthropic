#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List API Keys
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
        /// <param name="status">
        /// Filter by API key status.
        /// </param>
        /// <param name="workspaceId">
        /// Filter by Workspace ID.
        /// </param>
        /// <param name="createdByUserId">
        /// Filter by the ID of the User who created the object.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaListResponseApiKey> BetaListApiKeysV1OrganizationsApiKeysGetAsync(
            string? beforeId = default,
            string? afterId = default,
            int? limit = default,
            global::Anthropic.BetaListApiKeysV1OrganizationsApiKeysGetStatus2? status = default,
            string? workspaceId = default,
            string? createdByUserId = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List API Keys
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
        /// <param name="status">
        /// Filter by API key status.
        /// </param>
        /// <param name="workspaceId">
        /// Filter by Workspace ID.
        /// </param>
        /// <param name="createdByUserId">
        /// Filter by the ID of the User who created the object.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListResponseApiKey>> BetaListApiKeysV1OrganizationsApiKeysGetAsResponseAsync(
            string? beforeId = default,
            string? afterId = default,
            int? limit = default,
            global::Anthropic.BetaListApiKeysV1OrganizationsApiKeysGetStatus2? status = default,
            string? workspaceId = default,
            string? createdByUserId = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListApiKeysV1OrganizationsApiKeysGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaApiKey&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="beforeId">
        /// ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately before this object.
        /// </param>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `1000`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="status">
        /// Filter by API key status.
        /// </param>
        /// <param name="workspaceId">
        /// Filter by Workspace ID.
        /// </param>
        /// <param name="createdByUserId">
        /// Filter by the ID of the User who created the object.
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
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaApiKey> BetaListApiKeysV1OrganizationsApiKeysGetAutoPagingAsync(
              string? beforeId = default,
            int? limit = default,
            global::Anthropic.BetaListApiKeysV1OrganizationsApiKeysGetStatus2? status = default,
            string? workspaceId = default,
            string? createdByUserId = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? afterId = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}