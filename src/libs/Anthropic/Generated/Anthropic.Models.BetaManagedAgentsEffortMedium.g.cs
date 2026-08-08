
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Medium effort. Balances latency and reasoning depth.
    /// </summary>
    public sealed partial class BetaManagedAgentsEffortMedium
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEffortMediumTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsEffortMediumType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEffortMedium" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEffortMedium(
            global::Anthropic.BetaManagedAgentsEffortMediumType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEffortMedium" /> class.
        /// </summary>
        public BetaManagedAgentsEffortMedium()
        {
        }

    }
}