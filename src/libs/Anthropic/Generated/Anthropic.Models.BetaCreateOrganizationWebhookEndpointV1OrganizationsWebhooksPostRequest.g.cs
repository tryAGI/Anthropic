
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequest
    {
        /// <summary>
        /// Notes about the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The event types to deliver to the endpoint. Must list at least one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent> EnabledEvents { get; set; }

        /// <summary>
        /// A short label for the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The HTTPS URL that deliveries are sent to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequest" /> class.
        /// </summary>
        /// <param name="enabledEvents">
        /// The event types to deliver to the endpoint. Must list at least one.
        /// </param>
        /// <param name="url">
        /// The HTTPS URL that deliveries are sent to.
        /// </param>
        /// <param name="description">
        /// Notes about the endpoint.
        /// </param>
        /// <param name="name">
        /// A short label for the endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequest(
            global::System.Collections.Generic.IList<global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent> enabledEvents,
            string url,
            string? description,
            string? name)
        {
            this.Description = description;
            this.EnabledEvents = enabledEvents ?? throw new global::System.ArgumentNullException(nameof(enabledEvents));
            this.Name = name;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequest" /> class.
        /// </summary>
        public BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequest()
        {
        }

    }
}