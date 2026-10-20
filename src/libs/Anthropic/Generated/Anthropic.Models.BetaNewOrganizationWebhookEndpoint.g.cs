
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A new organization webhook endpoint, with its signing secret.
    /// </summary>
    public sealed partial class BetaNewOrganizationWebhookEndpoint
    {
        /// <summary>
        /// When the endpoint was created, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Notes about the endpoint. An empty string when none were given.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Why Anthropic disabled the endpoint automatically. An empty string when the endpoint is enabled, or when you disabled it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisabledReason { get; set; }

        /// <summary>
        /// The event types delivered to the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent> EnabledEvents { get; set; }

        /// <summary>
        /// ID of the webhook endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A short label for the endpoint. An empty string when none was given.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The secret Anthropic signs deliveries to the endpoint with (prefix `whsec_`). No other response returns it, so store it now. To replace it, regenerate the signing secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signing_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SigningSecret { get; set; }

        /// <summary>
        /// Whether deliveries are sent to the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaOrganizationWebhookEndpointStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaOrganizationWebhookEndpointState State { get; set; }

        /// <summary>
        /// When the endpoint was last changed, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaNewOrganizationWebhookEndpoint" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// When the endpoint was created, in RFC 3339 format.
        /// </param>
        /// <param name="description">
        /// Notes about the endpoint. An empty string when none were given.
        /// </param>
        /// <param name="disabledReason">
        /// Why Anthropic disabled the endpoint automatically. An empty string when the endpoint is enabled, or when you disabled it.
        /// </param>
        /// <param name="enabledEvents">
        /// The event types delivered to the endpoint.
        /// </param>
        /// <param name="id">
        /// ID of the webhook endpoint.
        /// </param>
        /// <param name="name">
        /// A short label for the endpoint. An empty string when none was given.
        /// </param>
        /// <param name="signingSecret">
        /// The secret Anthropic signs deliveries to the endpoint with (prefix `whsec_`). No other response returns it, so store it now. To replace it, regenerate the signing secret.
        /// </param>
        /// <param name="state">
        /// Whether deliveries are sent to the endpoint.
        /// </param>
        /// <param name="updatedAt">
        /// When the endpoint was last changed, in RFC 3339 format.
        /// </param>
        /// <param name="url">
        /// The HTTPS URL that deliveries are sent to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaNewOrganizationWebhookEndpoint(
            global::System.DateTime createdAt,
            string description,
            string disabledReason,
            global::System.Collections.Generic.IList<global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent> enabledEvents,
            string id,
            string name,
            string signingSecret,
            global::Anthropic.BetaOrganizationWebhookEndpointState state,
            global::System.DateTime updatedAt,
            string url)
        {
            this.CreatedAt = createdAt;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.DisabledReason = disabledReason ?? throw new global::System.ArgumentNullException(nameof(disabledReason));
            this.EnabledEvents = enabledEvents ?? throw new global::System.ArgumentNullException(nameof(enabledEvents));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SigningSecret = signingSecret ?? throw new global::System.ArgumentNullException(nameof(signingSecret));
            this.State = state;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaNewOrganizationWebhookEndpoint" /> class.
        /// </summary>
        public BetaNewOrganizationWebhookEndpoint()
        {
        }

    }
}