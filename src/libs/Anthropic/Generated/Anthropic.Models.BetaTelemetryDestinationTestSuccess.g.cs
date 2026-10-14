
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The destination answered the test span with a 2xx status.<br/>
    /// Example: {"type":"success"}
    /// </summary>
    public sealed partial class BetaTelemetryDestinationTestSuccess
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"success"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "success";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationTestSuccess" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationTestSuccess(
            string type = "success")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationTestSuccess" /> class.
        /// </summary>
        public BetaTelemetryDestinationTestSuccess()
        {
        }

    }
}