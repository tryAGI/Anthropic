
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Events that were successfully sent to the session.
    /// </summary>
    public sealed partial class BetaManagedAgentsSendSessionEvents
    {
        /// <summary>
        /// Sent events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsInputEvent>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSendSessionEvents" /> class.
        /// </summary>
        /// <param name="data">
        /// Sent events
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSendSessionEvents(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsInputEvent>? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSendSessionEvents" /> class.
        /// </summary>
        public BetaManagedAgentsSendSessionEvents()
        {
        }
    }
}