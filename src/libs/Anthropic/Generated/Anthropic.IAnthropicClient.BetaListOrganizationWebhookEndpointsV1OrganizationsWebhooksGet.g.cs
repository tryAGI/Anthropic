#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Organization Webhook Endpoints<br/>
        /// List the organization's webhook endpoints.<br/>
        /// An organization webhook endpoint belongs to the organization rather than to one of its workspaces. The list does not include webhook endpoints that<br/>
        /// belong to a workspace.<br/>
        /// Every request must include the beta header `anthropic-beta: webhooks-2026-10-07`. A request without it returns `404`, exactly as if this API did not exist. Anthropic turns organization webhook endpoints on for each organization; until yours is on, requests also return `404`. Organization webhook endpoints are in beta and are not available to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="limit">
        /// Number of items to return per page, up to `100`. The default, `0`, means `20`.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="beforeId">
        /// ID of a webhook endpoint to use as a cursor. Returns the first `limit` endpoints that come before it in list order, not the `limit` endpoints just before it.
        /// </param>
        /// <param name="afterId">
        /// ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately after this object.
        /// </param>
        /// <param name="order">
        /// Sort order by `created_at`. Defaults to `desc`, newest first.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `webhooks-2026-10-07` in this header.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaOrganizationWebhookEndpointList> BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetAsync(
            int? limit = default,
            string? beforeId = default,
            string? afterId = default,
            global::Anthropic.BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder? order = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Organization Webhook Endpoints<br/>
        /// List the organization's webhook endpoints.<br/>
        /// An organization webhook endpoint belongs to the organization rather than to one of its workspaces. The list does not include webhook endpoints that<br/>
        /// belong to a workspace.<br/>
        /// Every request must include the beta header `anthropic-beta: webhooks-2026-10-07`. A request without it returns `404`, exactly as if this API did not exist. Anthropic turns organization webhook endpoints on for each organization; until yours is on, requests also return `404`. Organization webhook endpoints are in beta and are not available to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="limit">
        /// Number of items to return per page, up to `100`. The default, `0`, means `20`.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="beforeId">
        /// ID of a webhook endpoint to use as a cursor. Returns the first `limit` endpoints that come before it in list order, not the `limit` endpoints just before it.
        /// </param>
        /// <param name="afterId">
        /// ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately after this object.
        /// </param>
        /// <param name="order">
        /// Sort order by `created_at`. Defaults to `desc`, newest first.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `webhooks-2026-10-07` in this header.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaOrganizationWebhookEndpointList>> BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetAsResponseAsync(
            int? limit = default,
            string? beforeId = default,
            string? afterId = default,
            global::Anthropic.BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder? order = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaOrganizationWebhookEndpoint&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Number of items to return per page, up to `100`. The default, `0`, means `20`.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="beforeId">
        /// ID of a webhook endpoint to use as a cursor. Returns the first `limit` endpoints that come before it in list order, not the `limit` endpoints just before it.
        /// </param>
        /// <param name="order">
        /// Sort order by `created_at`. Defaults to `desc`, newest first.
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `webhooks-2026-10-07` in this header.
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
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaOrganizationWebhookEndpoint> BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetAutoPagingAsync(
              int? limit = default,
            string? beforeId = default,
            global::Anthropic.BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder? order = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? afterId = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}