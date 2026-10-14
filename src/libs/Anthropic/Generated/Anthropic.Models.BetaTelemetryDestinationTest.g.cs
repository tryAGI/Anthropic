
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The result of one test span sent to a destination.
    /// </summary>
    public sealed partial class BetaTelemetryDestinationTest
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"telemetry_destination_test"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "telemetry_destination_test";

        /// <summary>
        /// How the test went: `success` when the destination answered with a 2xx status, else `failure` with the reason.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaTelemetryDestinationTestResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaTelemetryDestinationTestResult Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationTest" /> class.
        /// </summary>
        /// <param name="result">
        /// How the test went: `success` when the destination answered with a 2xx status, else `failure` with the reason.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationTest(
            global::Anthropic.BetaTelemetryDestinationTestResult result,
            string type = "telemetry_destination_test")
        {
            this.Type = type;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationTest" /> class.
        /// </summary>
        public BetaTelemetryDestinationTest()
        {
        }

    }
}