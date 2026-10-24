
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Extra-high effort. Not all models accept this level.
    /// </summary>
    public sealed partial class BetaManagedAgentsEffortXhigh
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"xhigh"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "xhigh";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEffortXhigh" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEffortXhigh(
            string type = "xhigh")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEffortXhigh" /> class.
        /// </summary>
        public BetaManagedAgentsEffortXhigh()
        {
        }

    }
}