
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Maximum effort. Favors reasoning depth over latency.
    /// </summary>
    public sealed partial class BetaManagedAgentsEffortMax
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEffortMaxTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsEffortMaxType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEffortMax" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEffortMax(
            global::Anthropic.BetaManagedAgentsEffortMaxType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEffortMax" /> class.
        /// </summary>
        public BetaManagedAgentsEffortMax()
        {
        }

    }
}