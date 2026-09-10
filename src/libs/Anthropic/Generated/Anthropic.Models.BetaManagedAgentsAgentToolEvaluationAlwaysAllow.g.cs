
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The resolved permission_policy was always_allow; accompanies evaluated_permission "allow".
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentToolEvaluationAlwaysAllow
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"always_allow"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "always_allow";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolEvaluationAlwaysAllow" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentToolEvaluationAlwaysAllow(
            string type = "always_allow")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolEvaluationAlwaysAllow" /> class.
        /// </summary>
        public BetaManagedAgentsAgentToolEvaluationAlwaysAllow()
        {
        }

    }
}