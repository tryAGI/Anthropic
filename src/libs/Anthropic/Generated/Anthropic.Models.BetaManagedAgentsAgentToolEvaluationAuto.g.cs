
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The resolved permission_policy was auto: the server judged this invocation individually.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentToolEvaluationAuto
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"auto"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "auto";

        /// <summary>
        /// The server's judgement for this invocation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluated_permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentAutoEvaluatedPermissionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermission EvaluatedPermission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolEvaluationAuto" /> class.
        /// </summary>
        /// <param name="evaluatedPermission">
        /// The server's judgement for this invocation.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentToolEvaluationAuto(
            global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermission evaluatedPermission,
            string type = "auto")
        {
            this.Type = type;
            this.EvaluatedPermission = evaluatedPermission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolEvaluationAuto" /> class.
        /// </summary>
        public BetaManagedAgentsAgentToolEvaluationAuto()
        {
        }

    }
}