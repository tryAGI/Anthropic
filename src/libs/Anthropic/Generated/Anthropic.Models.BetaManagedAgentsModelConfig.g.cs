
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Model identifier and configuration.<br/>
    /// Example: {"id":"claude-opus-4-8","speed":"standard"}
    /// </summary>
    public sealed partial class BetaManagedAgentsModelConfig
    {
        /// <summary>
        /// The model that will power your agent.<br/>
        /// See [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsModel Id { get; set; }

        /// <summary>
        /// Inference speed mode. `fast` provides significantly faster output token generation at premium pricing. Defaults to `standard`. Not all models support `fast`; invalid combinations are rejected at create time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSpeedJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSpeed? Speed { get; set; }

        /// <summary>
        /// How hard Claude works on each inference call. One of `low`, `medium`, `high`, `xhigh`, `max`. Always present; resolved to the per-model default at save time when not supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEffortJsonConverter))]
        public global::Anthropic.BetaManagedAgentsEffort? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsModelConfig" /> class.
        /// </summary>
        /// <param name="id">
        /// The model that will power your agent.<br/>
        /// See [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </param>
        /// <param name="speed">
        /// Inference speed mode. `fast` provides significantly faster output token generation at premium pricing. Defaults to `standard`. Not all models support `fast`; invalid combinations are rejected at create time.
        /// </param>
        /// <param name="effort">
        /// How hard Claude works on each inference call. One of `low`, `medium`, `high`, `xhigh`, `max`. Always present; resolved to the per-model default at save time when not supplied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsModelConfig(
            global::Anthropic.BetaManagedAgentsModel id,
            global::Anthropic.BetaManagedAgentsSpeed? speed,
            global::Anthropic.BetaManagedAgentsEffort? effort)
        {
            this.Id = id;
            this.Speed = speed;
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsModelConfig" /> class.
        /// </summary>
        public BetaManagedAgentsModelConfig()
        {
        }

    }
}