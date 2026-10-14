
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The API doesn't deliver anything to the telemetry destination.<br/>
    /// Spans produced while it is disabled aren't delivered later.
    /// </summary>
    public sealed partial class BetaTelemetryDestinationStateDisabled
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"disabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "disabled";

        /// <summary>
        /// Whether a caller or the API disabled the destination and, when the API did, why. Read-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaTelemetryDestinationDisabledReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaTelemetryDestinationDisabledReason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationStateDisabled" /> class.
        /// </summary>
        /// <param name="reason">
        /// Whether a caller or the API disabled the destination and, when the API did, why. Read-only.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationStateDisabled(
            global::Anthropic.BetaTelemetryDestinationDisabledReason reason,
            string type = "disabled")
        {
            this.Type = type;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationStateDisabled" /> class.
        /// </summary>
        public BetaTelemetryDestinationStateDisabled()
        {
        }

    }
}