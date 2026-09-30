
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Structured information about a refusal.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionRefusalStopDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"refusal"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "refusal";

        /// <summary>
        /// The policy category that triggered the refusal, or `null` when there is no named category. New values can be added over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetailsCategory? Category { get; set; }

        /// <summary>
        /// Human-readable explanation of the refusal, or `null` when none is available. The wording can change, so do not parse it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explanation")]
        public string? Explanation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionRefusalStopDetails" /> class.
        /// </summary>
        /// <param name="category">
        /// The policy category that triggered the refusal, or `null` when there is no named category. New values can be added over time.
        /// </param>
        /// <param name="explanation">
        /// Human-readable explanation of the refusal, or `null` when none is available. The wording can change, so do not parse it.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionRefusalStopDetails(
            global::Anthropic.BetaManagedAgentsSessionRefusalStopDetailsCategory? category,
            string? explanation,
            string type = "refusal")
        {
            this.Type = type;
            this.Category = category;
            this.Explanation = explanation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionRefusalStopDetails" /> class.
        /// </summary>
        public BetaManagedAgentsSessionRefusalStopDetails()
        {
        }

    }
}