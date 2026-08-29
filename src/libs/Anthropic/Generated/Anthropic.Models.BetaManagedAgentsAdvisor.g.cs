
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAdvisorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAdvisorType Type { get; set; }

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
            global::Anthropic.BetaManagedAgentsAdvisorType type)
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

    }
}