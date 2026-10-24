
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Placeholder for content withheld by Anthropic model policy.
    /// </summary>
    public sealed partial class BetaManagedAgentsRedactedBlock
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"redacted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "redacted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsRedactedBlock" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsRedactedBlock(
            string type = "redacted")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsRedactedBlock" /> class.
        /// </summary>
        public BetaManagedAgentsRedactedBlock()
        {
        }

    }
}