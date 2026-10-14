
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A telemetry destination's settings for the traces it receives.
    /// </summary>
    public sealed partial class BetaTelemetryDestinationTraces
    {
        /// <summary>
        /// Whether the destination receives traces. A destination whose `enabled` is false keeps its other settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The full URL that the API posts traces to, exactly as registered, or `null` if the destination doesn't have one.<br/>
        /// When it is `null`, the API posts traces to `endpoint_url` with `/v1/traces` appended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_url")]
        public string? EndpointUrl { get; set; }

        /// <summary>
        /// What the exported spans contain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaTelemetryDestinationContentModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaTelemetryDestinationContentMode ContentMode { get; set; }

        /// <summary>
        /// The most bytes of content that one exported span can contain, or `null` if only the API's maximum applies.<br/>
        /// Content means model prompts and responses, and tool inputs and outputs. The API shortens longer content to this size before it delivers the span. A destination whose `content_mode` is `metadata_only` keeps this value. It applies once `content_mode` is `content`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_content_bytes")]
        public int? MaxContentBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationTraces" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the destination receives traces. A destination whose `enabled` is false keeps its other settings.
        /// </param>
        /// <param name="contentMode">
        /// What the exported spans contain.
        /// </param>
        /// <param name="endpointUrl">
        /// The full URL that the API posts traces to, exactly as registered, or `null` if the destination doesn't have one.<br/>
        /// When it is `null`, the API posts traces to `endpoint_url` with `/v1/traces` appended.
        /// </param>
        /// <param name="maxContentBytes">
        /// The most bytes of content that one exported span can contain, or `null` if only the API's maximum applies.<br/>
        /// Content means model prompts and responses, and tool inputs and outputs. The API shortens longer content to this size before it delivers the span. A destination whose `content_mode` is `metadata_only` keeps this value. It applies once `content_mode` is `content`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationTraces(
            bool enabled,
            global::Anthropic.BetaTelemetryDestinationContentMode contentMode,
            string? endpointUrl,
            int? maxContentBytes)
        {
            this.Enabled = enabled;
            this.EndpointUrl = endpointUrl;
            this.ContentMode = contentMode;
            this.MaxContentBytes = maxContentBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationTraces" /> class.
        /// </summary>
        public BetaTelemetryDestinationTraces()
        {
        }

    }
}