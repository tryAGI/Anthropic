
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The settings for the traces that a telemetry destination receives, as a create or update request sets them. An omitted field takes its default on create and keeps its stored value on update.
    /// </summary>
    public sealed partial class BetaTelemetryDestinationTracesParams
    {
        /// <summary>
        /// Whether the destination receives traces. Defaults to true on create. It cannot be null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The full URL of your collector's traces endpoint, for a collector that takes traces on a path other than `/v1/traces`. The API posts traces to it exactly as given and appends nothing.<br/>
        /// The same rules as for `endpoint_url` apply, except that any path is allowed. It must have the same scheme, host, and port as `endpoint_url`. At most 2,048 characters.<br/>
        /// On create, `null` is the same as leaving it out. On update, `null` removes it. The API then posts traces to `endpoint_url` with `/v1/traces` appended. A change of this URL alone keeps the registered headers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_url")]
        public string? EndpointUrl { get; set; }

        /// <summary>
        /// What the exported spans contain. Defaults to `metadata_only` on create.<br/>
        /// On update, `null` sets `metadata_only`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_mode")]
        public global::Anthropic.BetaTelemetryDestinationContentMode? ContentMode { get; set; }

        /// <summary>
        /// The most bytes of content that one exported span can contain, from 1 up to the API's maximum. `null` sets no bound, so only the API's maximum applies.<br/>
        /// On create, leaving it out is the same as `null`. The error for a value above the maximum states the maximum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_content_bytes")]
        public int? MaxContentBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationTracesParams" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the destination receives traces. Defaults to true on create. It cannot be null.
        /// </param>
        /// <param name="endpointUrl">
        /// The full URL of your collector's traces endpoint, for a collector that takes traces on a path other than `/v1/traces`. The API posts traces to it exactly as given and appends nothing.<br/>
        /// The same rules as for `endpoint_url` apply, except that any path is allowed. It must have the same scheme, host, and port as `endpoint_url`. At most 2,048 characters.<br/>
        /// On create, `null` is the same as leaving it out. On update, `null` removes it. The API then posts traces to `endpoint_url` with `/v1/traces` appended. A change of this URL alone keeps the registered headers.
        /// </param>
        /// <param name="contentMode">
        /// What the exported spans contain. Defaults to `metadata_only` on create.<br/>
        /// On update, `null` sets `metadata_only`.
        /// </param>
        /// <param name="maxContentBytes">
        /// The most bytes of content that one exported span can contain, from 1 up to the API's maximum. `null` sets no bound, so only the API's maximum applies.<br/>
        /// On create, leaving it out is the same as `null`. The error for a value above the maximum states the maximum.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationTracesParams(
            bool? enabled,
            string? endpointUrl,
            global::Anthropic.BetaTelemetryDestinationContentMode? contentMode,
            int? maxContentBytes)
        {
            this.Enabled = enabled;
            this.EndpointUrl = endpointUrl;
            this.ContentMode = contentMode;
            this.MaxContentBytes = maxContentBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationTracesParams" /> class.
        /// </summary>
        public BetaTelemetryDestinationTracesParams()
        {
        }

    }
}