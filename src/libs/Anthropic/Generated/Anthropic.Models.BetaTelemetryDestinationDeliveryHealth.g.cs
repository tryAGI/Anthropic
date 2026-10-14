
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The most recent delivery results that the API records for a telemetry destination.<br/>
    /// Changes to the destination's configuration or state don't reset these fields. Changes to these fields don't change `updated_at`. The values can lag behind the latest deliveries.<br/>
    /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#delivery-and-health) to learn how the API delivers spans and when it disables a destination.
    /// </summary>
    public sealed partial class BetaTelemetryDestinationDeliveryHealth
    {
        /// <summary>
        /// Time of the most recent successful delivery to the destination, or `null` if no delivery has succeeded yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_success_at")]
        public global::System.DateTime? LastSuccessAt { get; set; }

        /// <summary>
        /// A message that describes the most recent failed delivery to the destination, or `null` if no delivery has failed yet.<br/>
        /// Examples are `temporary DNS failure`, `TLS failure`, `timeout`, `connection failure`, `invalid address`, `HTTP error (status 503)`, and `redirect (status 301)`. The message is `invalid address` both for a hostname that doesn't exist and for an address that isn't publicly routable. It never contains the endpoint's response body, a header value, a network address, or TLS details.<br/>
        /// `last_error` and `last_error_at` always change together. A later successful delivery doesn't clear them. If `last_success_at` is later than `last_error_at`, a delivery has succeeded since this failure.<br/>
        /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#delivery-errors) to learn the likely cause of each error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_error")]
        public string? LastError { get; set; }

        /// <summary>
        /// Time of the failure that `last_error` describes. Changes together with `last_error`. Null until a delivery first fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_error_at")]
        public global::System.DateTime? LastErrorAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationDeliveryHealth" /> class.
        /// </summary>
        /// <param name="lastSuccessAt">
        /// Time of the most recent successful delivery to the destination, or `null` if no delivery has succeeded yet.
        /// </param>
        /// <param name="lastError">
        /// A message that describes the most recent failed delivery to the destination, or `null` if no delivery has failed yet.<br/>
        /// Examples are `temporary DNS failure`, `TLS failure`, `timeout`, `connection failure`, `invalid address`, `HTTP error (status 503)`, and `redirect (status 301)`. The message is `invalid address` both for a hostname that doesn't exist and for an address that isn't publicly routable. It never contains the endpoint's response body, a header value, a network address, or TLS details.<br/>
        /// `last_error` and `last_error_at` always change together. A later successful delivery doesn't clear them. If `last_success_at` is later than `last_error_at`, a delivery has succeeded since this failure.<br/>
        /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#delivery-errors) to learn the likely cause of each error.
        /// </param>
        /// <param name="lastErrorAt">
        /// Time of the failure that `last_error` describes. Changes together with `last_error`. Null until a delivery first fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationDeliveryHealth(
            global::System.DateTime? lastSuccessAt,
            string? lastError,
            global::System.DateTime? lastErrorAt)
        {
            this.LastSuccessAt = lastSuccessAt;
            this.LastError = lastError;
            this.LastErrorAt = lastErrorAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationDeliveryHealth" /> class.
        /// </summary>
        public BetaTelemetryDestinationDeliveryHealth()
        {
        }

    }
}