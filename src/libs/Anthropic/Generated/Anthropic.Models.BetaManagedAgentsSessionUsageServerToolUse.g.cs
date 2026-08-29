
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Cumulative server-executed tool usage across all turns. Absent until server-tool tracking is available for the session.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionUsageServerToolUse
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}