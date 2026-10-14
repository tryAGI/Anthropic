
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The test span was not delivered.<br/>
    /// Example: {"type":"failure","error":"HTTP error (status 403)"}
    /// </summary>
    public sealed partial class BetaTelemetryDestinationTestFailure
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"failure"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "failure";

        /// <summary>
        /// A message that describes why the test span was not delivered, including the HTTP status code when the destination returned one. Examples: `HTTP error (status 403)`, `timeout`, `TLS failure`. It has the same form as the destination's `delivery_health.last_error` and never contains the destination's response body, any header value, a network address, or TLS details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationTestFailure" /> class.
        /// </summary>
        /// <param name="error">
        /// A message that describes why the test span was not delivered, including the HTTP status code when the destination returned one. Examples: `HTTP error (status 403)`, `timeout`, `TLS failure`. It has the same form as the destination's `delivery_health.last_error` and never contains the destination's response body, any header value, a network address, or TLS details.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationTestFailure(
            string error,
            string type = "failure")
        {
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationTestFailure" /> class.
        /// </summary>
        public BetaTelemetryDestinationTestFailure()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaTelemetryDestinationTestFailure"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaTelemetryDestinationTestFailure FromError(string error)
        {
            return new BetaTelemetryDestinationTestFailure
            {
                Error = error,
            };
        }

    }
}