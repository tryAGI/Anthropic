#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List External Storage<br/>
        /// List the organization's External Storage, newest first.
        /// </summary>
        /// <param name="limit">
        /// Number of results per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page`.
        /// </param>
        /// <param name="userProfileIds">
        /// Returns only External Storage bound to one of these user profile IDs (`uprof_...`). An empty entry matches storage bound to no user profile. At most 10 entries, counting repeats.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `efs-2026-10-01` in this header.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaExternalStorageListResponse> BetaListExternalStorageV1OrganizationsExternalStorageGetAsync(
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<string>? userProfileIds = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List External Storage<br/>
        /// List the organization's External Storage, newest first.
        /// </summary>
        /// <param name="limit">
        /// Number of results per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page`.
        /// </param>
        /// <param name="userProfileIds">
        /// Returns only External Storage bound to one of these user profile IDs (`uprof_...`). An empty entry matches storage bound to no user profile. At most 10 entries, counting repeats.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `efs-2026-10-01` in this header.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaExternalStorageListResponse>> BetaListExternalStorageV1OrganizationsExternalStorageGetAsResponseAsync(
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<string>? userProfileIds = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListExternalStorageV1OrganizationsExternalStorageGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaExternalStorage&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Number of results per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="userProfileIds">
        /// Returns only External Storage bound to one of these user profile IDs (`uprof_...`). An empty entry matches storage bound to no user profile. At most 10 entries, counting repeats.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `efs-2026-10-01` in this header.
        /// </param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaExternalStorage> BetaListExternalStorageV1OrganizationsExternalStorageGetAutoPagingAsync(
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,             int? limit = default,
            global::System.Collections.Generic.IList<string>? userProfileIds = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}