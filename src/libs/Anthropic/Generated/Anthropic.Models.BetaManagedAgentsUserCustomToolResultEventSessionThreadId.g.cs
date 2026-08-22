
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Routes this result to a subagent thread. Copy from the `agent.custom_tool_use` event's `session_thread_id`.
    /// </summary>
    public sealed partial class BetaManagedAgentsUserCustomToolResultEventSessionThreadId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}