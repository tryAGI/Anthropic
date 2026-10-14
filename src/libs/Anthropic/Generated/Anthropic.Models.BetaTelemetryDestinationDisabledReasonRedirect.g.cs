
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The API disabled the destination because the endpoint answered a delivery with a 3xx status. Redirects are never followed, and one such answer disables the destination at once.
    /// </summary>
    public sealed partial class BetaTelemetryDestinationDisabledReasonRedirect
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"redirect"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "redirect";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationDisabledReasonRedirect" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTelemetryDestinationDisabledReasonRedirect(
            string type = "redirect")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTelemetryDestinationDisabledReasonRedirect" /> class.
        /// </summary>
        public BetaTelemetryDestinationDisabledReasonRedirect()
        {
        }

    }
}