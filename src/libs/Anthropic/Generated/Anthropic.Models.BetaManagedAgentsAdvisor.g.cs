
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Platform advisor roster entry: a model the session's primary thread may consult mid-turn.
    /// </summary>
    public sealed partial class BetaManagedAgentsAdvisor
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"advisor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "advisor";

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAdvisor" /> class.
        /// </summary>
        /// <param name="model">
        /// The advisor model id.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAdvisor(
            string model,
            string type = "advisor")
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAdvisor" /> class.
        /// </summary>
        public BetaManagedAgentsAdvisor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsAdvisor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsAdvisor FromModel(string model)
        {
            return new BetaManagedAgentsAdvisor
            {
                Model = model,
            };
        }

    }
}