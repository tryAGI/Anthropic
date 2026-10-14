
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The API disabled the destination because deliveries to it failed, with no successful delivery in between, for longer than a threshold that Anthropic configures and that is not part of this contract. The reason is `invalid_address` instead when the most recent failed delivery failed with an invalid address.
    /// </summary>
    public sealed partial class BetaTelemetryDestinationDisabledReasonSustainedFailure
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"sustained_failure"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "sustained_failure";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationDisabledReasonSustainedFailure" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationDisabledReasonSustainedFailure(
            string type = "sustained_failure")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationDisabledReasonSustainedFailure" /> class.
        /// </summary>
        public BetaTelemetryDestinationDisabledReasonSustainedFailure()
        {
        }

    }
}