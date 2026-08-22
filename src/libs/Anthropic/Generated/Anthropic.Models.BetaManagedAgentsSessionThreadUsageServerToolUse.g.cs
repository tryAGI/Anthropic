
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Cumulative server-executed tool usage across all turns of this thread. Absent until server-tool tracking is available for the thread.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionThreadUsageServerToolUse
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}