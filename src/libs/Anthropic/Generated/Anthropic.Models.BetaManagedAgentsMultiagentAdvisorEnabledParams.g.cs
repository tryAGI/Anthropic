
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The session's primary thread can consult `model` mid-turn.<br/>
    /// Example: {"type":"enabled","model":"claude-fable-5"}
    /// </summary>
    public sealed partial class BetaManagedAgentsMultiagentAdvisorEnabledParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// A Claude model id. The model must be permitted as an advisor for this agent's model.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentAdvisorEnabledParams" /> class.
        /// </summary>
        /// <param name="model">
        /// A Claude model id. The model must be permitted as an advisor for this agent's model.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMultiagentAdvisorEnabledParams(
            string model,
            string type = "enabled")
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentAdvisorEnabledParams" /> class.
        /// </summary>
        public BetaManagedAgentsMultiagentAdvisorEnabledParams()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsMultiagentAdvisorEnabledParams"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsMultiagentAdvisorEnabledParams FromModel(string model)
        {
            return new BetaManagedAgentsMultiagentAdvisorEnabledParams
            {
                Model = model,
            };
        }

    }
}