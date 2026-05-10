
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Parameters for defining an outcome the agent should work toward. The agent begins work on receipt.<br/>
    /// Example: {"type":"user.define_outcome","description":"Produce a 2-page summary as summary.md","rubric":{"type":"text","content":"Must cover all five sections; cite sources inline."},"max_iterations":3}
    /// </summary>
    public sealed partial class BetaManagedAgentsUserDefineOutcomeEventParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserDefineOutcomeEventParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParamsType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRubricParamsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsRubricParams Rubric { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserDefineOutcomeEventParams" /> class.
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
        public BetaManagedAgentsUserDefineOutcomeEventParams(
            string description,
            global::Anthropic.BetaManagedAgentsRubricParams rubric,
            global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParamsType type,
            int? maxIterations)
        {
            this.Type = type;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Rubric = rubric;
            this.MaxIterations = maxIterations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserDefineOutcomeEventParams" /> class.
        /// </summary>
        public BetaManagedAgentsUserDefineOutcomeEventParams()
        {
        }

    }
}