
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A caller disabled the destination with an update that set `state` to `disabled`.
    /// </summary>
    public sealed partial class BetaTelemetryDestinationDisabledReasonCaller
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"caller"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "caller";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationDisabledReasonCaller" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationDisabledReasonCaller(
            string type = "caller")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationDisabledReasonCaller" /> class.
        /// </summary>
        public BetaTelemetryDestinationDisabledReasonCaller()
        {
        }

    }
}