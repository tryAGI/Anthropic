
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Platform advisor roster entry: a model the session's primary thread may consult mid-turn. At most one per roster; the entry occupies the roster name `anthropic.advisor`.<br/>
    /// Example: {"type":"advisor","model":"claude-opus-5-5"}
    /// </summary>
    public sealed partial class BetaManagedAgentsAdvisorParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"advisor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "advisor";

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAdvisorParams" /> class.
        /// </summary>
        /// <param name="model">
        /// A Claude model id. The model must be permitted as an advisor for this agent's model.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAdvisorParams(
            string model,
            string type = "advisor")
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

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsAdvisorParams"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsAdvisorParams FromModel(string model)
        {
            return new BetaManagedAgentsAdvisorParams
            {
                Model = model,
            };
        }

    }
}