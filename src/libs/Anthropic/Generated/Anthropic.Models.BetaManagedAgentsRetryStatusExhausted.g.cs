
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// This turn is dead; queued inputs are flushed and the session returns to idle. Client may send a new prompt.
    /// </summary>
    public sealed partial class BetaManagedAgentsRetryStatusExhausted
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusExhaustedTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsRetryStatusExhaustedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsRetryStatusExhausted" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsRetryStatusExhausted(
            global::Anthropic.BetaManagedAgentsRetryStatusExhaustedType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsRetryStatusExhausted" /> class.
        /// </summary>
        public BetaManagedAgentsRetryStatusExhausted()
        {
        }
    }
}