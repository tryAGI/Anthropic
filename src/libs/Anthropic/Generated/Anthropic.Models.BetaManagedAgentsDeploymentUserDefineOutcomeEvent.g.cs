
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An outcome the agent should work toward. The agent begins work on receipt.
    /// </summary>
    public sealed partial class BetaManagedAgentsDeploymentUserDefineOutcomeEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeploymentUserDefineOutcomeEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEventType Type { get; set; }

        /// <summary>
        /// What the agent should produce. This is the task specification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// How to grade the outcome. Text or file reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rubric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRubricJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsRubric Rubric { get; set; }

        /// <summary>
        /// Eval→revision cycles before giving up. Default 3, max 20.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_iterations")]
        public int? MaxIterations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeploymentUserDefineOutcomeEvent" /> class.
        /// </summary>
        /// <param name="description">
        /// What the agent should produce. This is the task specification.
        /// </param>
        /// <param name="rubric">
        /// How to grade the outcome. Text or file reference.
        /// </param>
        /// <param name="type"></param>
        /// <param name="maxIterations">
        /// Eval→revision cycles before giving up. Default 3, max 20.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsDeploymentUserDefineOutcomeEvent(
            string description,
            global::Anthropic.BetaManagedAgentsRubric rubric,
            global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEventType type,
            int? maxIterations)
        {
            this.Type = type;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Rubric = rubric;
            this.MaxIterations = maxIterations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeploymentUserDefineOutcomeEvent" /> class.
        /// </summary>
        public BetaManagedAgentsDeploymentUserDefineOutcomeEvent()
        {
        }

    }
}