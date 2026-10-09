
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The session's primary thread can consult `model` mid-turn.<br/>
    /// Example: {"type":"enabled","model":"claude-fable-5"}
    /// </summary>
    public sealed partial class BetaManagedAgentsMultiagentAdvisorEnabled
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// The advisor model id.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentAdvisorEnabled" /> class.
        /// </summary>
        /// <param name="model">
        /// The advisor model id.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMultiagentAdvisorEnabled(
            string model,
            string type = "enabled")
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentAdvisorEnabled" /> class.
        /// </summary>
        public BetaManagedAgentsMultiagentAdvisorEnabled()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsMultiagentAdvisorEnabled"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsMultiagentAdvisorEnabled FromModel(string model)
        {
            return new BetaManagedAgentsMultiagentAdvisorEnabled
            {
                Model = model,
            };
        }

    }
}