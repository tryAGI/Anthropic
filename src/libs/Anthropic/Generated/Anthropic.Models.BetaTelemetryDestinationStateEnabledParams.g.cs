
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Start deliveries to the telemetry destination again.<br/>
    /// This doesn't reset `delivery_health`.
    /// </summary>
    public sealed partial class BetaTelemetryDestinationStateEnabledParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationStateEnabledParams" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationStateEnabledParams(
            string type = "enabled")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationStateEnabledParams" /> class.
        /// </summary>
        public BetaTelemetryDestinationStateEnabledParams()
        {
        }

    }
}