
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Parameters for sending an interrupt to pause the agent.
    /// </summary>
    public sealed partial class BetaManagedAgentsUserInterruptEventParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserInterruptEventParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsUserInterruptEventParamsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserInterruptEventParams" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUserInterruptEventParams(
            global::Anthropic.BetaManagedAgentsUserInterruptEventParamsType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserInterruptEventParams" /> class.
        /// </summary>
        public BetaManagedAgentsUserInterruptEventParams()
        {
        }
    }
}