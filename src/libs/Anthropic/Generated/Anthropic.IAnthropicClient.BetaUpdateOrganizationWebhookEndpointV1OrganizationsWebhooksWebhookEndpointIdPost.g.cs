#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Organization Webhook Endpoint<br/>
        /// Update an organization webhook endpoint. Only the fields you send are changed.<br/>
        /// Every request must include the beta header `anthropic-beta: webhooks-2026-10-07`. A request without it returns `404`, exactly as if this API did not exist. Anthropic turns organization webhook endpoints on for each organization; until yours is on, requests also return `404`. Organization webhook endpoints are in beta and are not available to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="webhookEndpointId">
        /// ID of the webhook endpoint.
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaOrganizationWebhookEndpoint> BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostAsync(
            string webhookEndpointId,

            global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Organization Webhook Endpoint<br/>
        /// Update an organization webhook endpoint. Only the fields you send are changed.<br/>
        /// Every request must include the beta header `anthropic-beta: webhooks-2026-10-07`. A request without it returns `404`, exactly as if this API did not exist. Anthropic turns organization webhook endpoints on for each organization; until yours is on, requests also return `404`. Organization webhook endpoints are in beta and are not available to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="webhookEndpointId">
        /// ID of the webhook endpoint.
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaOrganizationWebhookEndpoint>> BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostAsResponseAsync(
            string webhookEndpointId,

            global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Organization Webhook Endpoint<br/>
        /// Update an organization webhook endpoint. Only the fields you send are changed.<br/>
        /// Every request must include the beta header `anthropic-beta: webhooks-2026-10-07`. A request without it returns `404`, exactly as if this API did not exist. Anthropic turns organization webhook endpoints on for each organization; until yours is on, requests also return `404`. Organization webhook endpoints are in beta and are not available to organizations with HIPAA readiness enabled.
        /// </summary>
        /// <param name="webhookEndpointId">
        /// ID of the webhook endpoint.
        /// </param>
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
        /// The event types to deliver to the endpoint. Replaces the whole set; an empty list leaves it unchanged.
        /// </param>
        /// <param name="name">
        /// A short label for the endpoint.
        /// </param>
        /// <param name="state">
        /// `disabled` stops deliveries. `enabled` resumes them and clears `disabled_reason`. Events that happen while the endpoint is disabled are never delivered.
        /// </param>
        /// <param name="url">
        /// The HTTPS URL that deliveries are sent to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaOrganizationWebhookEndpoint> BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostAsync(
            string webhookEndpointId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestEnabledEvent>? enabledEvents = default,
            string? name = default,
            global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState? state = default,
            string? url = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}