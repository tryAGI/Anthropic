
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An OpenTelemetry destination: an OTLP/HTTP endpoint, the request headers sent with every delivery to it, what the exported spans contain, and which workspaces it covers. A destination belongs to an organization. A workspace's spans go to every enabled destination that covers it.
    /// </summary>
    public sealed partial class BetaTelemetryDestination
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"telemetry_destination"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "telemetry_destination";

        /// <summary>
        /// The unique ID of the destination (`tdst_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable name for the destination. Null when none was set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The base URL of the destination's OTLP/HTTP endpoint, exactly as registered.<br/>
        /// The API appends the per-signal path, such as `/v1/traces`, on delivery, unless `traces.endpoint_url` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointUrl { get; set; }

        /// <summary>
        /// Names of the registered request headers. Header values are write-only and are never returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> HeaderNames { get; set; }

        /// <summary>
        /// The destination's settings for the traces it receives.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaTelemetryDestinationTraces Traces { get; set; }

        /// <summary>
        /// Whether the destination receives deliveries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaTelemetryDestinationStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaTelemetryDestinationState State { get; set; }

        /// <summary>
        /// The most recent delivery results for this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery_health")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaTelemetryDestinationDeliveryHealth DeliveryHealth { get; set; }

        /// <summary>
        /// Time the destination was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time of the last change to the destination's configuration or state. Changes to `delivery_health` don't change it.<br/>
        /// An update that sets a header value always changes it, even when the value is the same as before. Adding or removing a single workspace on the destination's list doesn't change it. An update that changes the list does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Which of the organization's workspaces the destination covers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaTelemetryDestinationWorkspacesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaTelemetryDestinationWorkspaces Workspaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestination" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the destination (`tdst_...`).
        /// </param>
        /// <param name="endpointUrl">
        /// The base URL of the destination's OTLP/HTTP endpoint, exactly as registered.<br/>
        /// The API appends the per-signal path, such as `/v1/traces`, on delivery, unless `traces.endpoint_url` is set.
        /// </param>
        /// <param name="headerNames">
        /// Names of the registered request headers. Header values are write-only and are never returned.
        /// </param>
        /// <param name="traces">
        /// The destination's settings for the traces it receives.
        /// </param>
        /// <param name="state">
        /// Whether the destination receives deliveries.
        /// </param>
        /// <param name="deliveryHealth">
        /// The most recent delivery results for this destination.
        /// </param>
        /// <param name="createdAt">
        /// Time the destination was created.
        /// </param>
        /// <param name="updatedAt">
        /// Time of the last change to the destination's configuration or state. Changes to `delivery_health` don't change it.<br/>
        /// An update that sets a header value always changes it, even when the value is the same as before. Adding or removing a single workspace on the destination's list doesn't change it. An update that changes the list does.
        /// </param>
        /// <param name="workspaces">
        /// Which of the organization's workspaces the destination covers.
        /// </param>
        /// <param name="displayName">
        /// Human-readable name for the destination. Null when none was set.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestination(
            string id,
            string endpointUrl,
            global::System.Collections.Generic.IList<string> headerNames,
            global::Anthropic.BetaTelemetryDestinationTraces traces,
            global::Anthropic.BetaTelemetryDestinationState state,
            global::Anthropic.BetaTelemetryDestinationDeliveryHealth deliveryHealth,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Anthropic.BetaTelemetryDestinationWorkspaces workspaces,
            string? displayName,
            string type = "telemetry_destination")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName;
            this.EndpointUrl = endpointUrl ?? throw new global::System.ArgumentNullException(nameof(endpointUrl));
            this.HeaderNames = headerNames ?? throw new global::System.ArgumentNullException(nameof(headerNames));
            this.Traces = traces ?? throw new global::System.ArgumentNullException(nameof(traces));
            this.State = state;
            this.DeliveryHealth = deliveryHealth ?? throw new global::System.ArgumentNullException(nameof(deliveryHealth));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Workspaces = workspaces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestination" /> class.
        /// </summary>
        public BetaTelemetryDestination()
        {
        }

    }
}