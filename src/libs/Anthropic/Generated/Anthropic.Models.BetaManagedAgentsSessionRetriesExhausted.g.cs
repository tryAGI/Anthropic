
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The turn ended because repeated errors exhausted the retry budget or an error escalated to `retry_status: 'exhausted'`.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionRetriesExhausted
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"retries_exhausted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "retries_exhausted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionRetriesExhausted" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionRetriesExhausted(
            string type = "retries_exhausted")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionRetriesExhausted" /> class.
        /// </summary>
        public BetaManagedAgentsSessionRetriesExhausted()
        {
        }

    }
}