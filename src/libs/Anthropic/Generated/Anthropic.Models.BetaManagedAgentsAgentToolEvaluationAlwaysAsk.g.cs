
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The resolved permission_policy was always_ask; accompanies evaluated_permission "ask".
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentToolEvaluationAlwaysAsk
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"always_ask"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "always_ask";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolEvaluationAlwaysAsk" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentToolEvaluationAlwaysAsk(
            string type = "always_ask")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolEvaluationAlwaysAsk" /> class.
        /// </summary>
        public BetaManagedAgentsAgentToolEvaluationAlwaysAsk()
        {
        }

    }
}