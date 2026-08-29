
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Platform advisor roster entry: a model the session's primary thread may consult mid-turn. At most one per roster; the entry occupies the roster name `anthropic.advisor`.<br/>
    /// Example: {"type":"advisor","model":"claude-fable-5"}
    /// </summary>
    public sealed partial class BetaManagedAgentsAdvisorParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAdvisorParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAdvisorParamsType Type { get; set; }

        /// <summary>
        /// A Claude model id. The model must be permitted as an advisor for this agent's model — see the sessions/threads/advisor spec.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAdvisorParams" /> class.
        /// </summary>
        /// <param name="model">
        /// A Claude model id. The model must be permitted as an advisor for this agent's model — see the sessions/threads/advisor spec.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAdvisorParams(
            string model,
            global::Anthropic.BetaManagedAgentsAdvisorParamsType type)
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAdvisorParams" /> class.
        /// </summary>
        public BetaManagedAgentsAdvisorParams()
        {
        }

    }
}