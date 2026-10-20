#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Organization Webhook Endpoint<br/>
        /// Create an organization webhook endpoint.<br/>
        /// An organization webhook endpoint belongs to the organization rather than to one of its workspaces. An organization can have at most 32 organization<br/>
        /// webhook endpoints, enabled or disabled.<br/>
        /// The response includes the endpoint's signing secret. No read returns it, so store<br/>
        /// it when you receive it.<br/>
        /// Every request must include the beta header `anthropic-beta: webhooks-2026-10-07`. A request without it returns `404`, exactly as if this API did not exist. Anthropic turns organization webhook endpoints on for each organization; until yours is on, requests also return `404`. Organization webhook endpoints are in beta and are not available to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `webhooks-2026-10-07` in this header.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaNewOrganizationWebhookEndpoint> BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostAsync(

            global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Organization Webhook Endpoint<br/>
        /// Create an organization webhook endpoint.<br/>
        /// An organization webhook endpoint belongs to the organization rather than to one of its workspaces. An organization can have at most 32 organization<br/>
        /// webhook endpoints, enabled or disabled.<br/>
        /// The response includes the endpoint's signing secret. No read returns it, so store<br/>
        /// it when you receive it.<br/>
        /// Every request must include the beta header `anthropic-beta: webhooks-2026-10-07`. A request without it returns `404`, exactly as if this API did not exist. Anthropic turns organization webhook endpoints on for each organization; until yours is on, requests also return `404`. Organization webhook endpoints are in beta and are not available to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `webhooks-2026-10-07` in this header.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaNewOrganizationWebhookEndpoint>> BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostAsResponseAsync(

            global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Organization Webhook Endpoint<br/>
        /// Create an organization webhook endpoint.<br/>
        /// An organization webhook endpoint belongs to the organization rather than to one of its workspaces. An organization can have at most 32 organization<br/>
        /// webhook endpoints, enabled or disabled.<br/>
        /// The response includes the endpoint's signing secret. No read returns it, so store<br/>
        /// it when you receive it.<br/>
        /// Every request must include the beta header `anthropic-beta: webhooks-2026-10-07`. A request without it returns `404`, exactly as if this API did not exist. Anthropic turns organization webhook endpoints on for each organization; until yours is on, requests also return `404`. Organization webhook endpoints are in beta and are not available to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `webhooks-2026-10-07` in this header.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="description">
        /// Notes about the endpoint.
        /// </param>
        /// <param name="enabledEvents">
        /// The event types to deliver to the endpoint. Must list at least one.
        /// </param>
        /// <param name="name">
        /// A short label for the endpoint.
        /// </param>
        /// <param name="url">
        /// The HTTPS URL that deliveries are sent to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaNewOrganizationWebhookEndpoint> BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostAsync(
            global::System.Collections.Generic.IList<global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent> enabledEvents,
            string url,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            string? description = default,
            string? name = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}