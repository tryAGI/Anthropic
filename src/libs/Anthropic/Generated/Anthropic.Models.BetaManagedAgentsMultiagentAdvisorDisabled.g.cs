
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The agent has no advisor.
    /// </summary>
    public sealed partial class BetaManagedAgentsMultiagentAdvisorDisabled
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"disabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "disabled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentAdvisorDisabled" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMultiagentAdvisorDisabled(
            string type = "disabled")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentAdvisorDisabled" /> class.
        /// </summary>
        public BetaManagedAgentsMultiagentAdvisorDisabled()
        {
        }

    }
}