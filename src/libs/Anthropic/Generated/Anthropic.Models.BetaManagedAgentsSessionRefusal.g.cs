
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The turn ended because the model's response was refused, for example by a safety classifier.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionRefusal
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"refusal"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "refusal";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionRefusal" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionRefusal(
            string type = "refusal")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionRefusal" /> class.
        /// </summary>
        public BetaManagedAgentsSessionRefusal()
        {
        }

    }
}