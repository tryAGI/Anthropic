
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
        /// <default>"user.interrupt"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user.interrupt";

        /// <summary>
        /// If absent, interrupts every non-archived thread in a multiagent session (or the primary alone in a single-agent session). If present, interrupts only the named thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_thread_id")]
        public string? SessionThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserInterruptEventParams" /> class.
        /// </summary>
        /// <param name="sessionThreadId">
        /// If absent, interrupts every non-archived thread in a multiagent session (or the primary alone in a single-agent session). If present, interrupts only the named thread.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUserInterruptEventParams(
            string? sessionThreadId,
            string type = "user.interrupt")
        {
            this.Type = type;
            this.SessionThreadId = sessionThreadId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserInterruptEventParams" /> class.
        /// </summary>
        public BetaManagedAgentsUserInterruptEventParams()
        {
        }

    }
}