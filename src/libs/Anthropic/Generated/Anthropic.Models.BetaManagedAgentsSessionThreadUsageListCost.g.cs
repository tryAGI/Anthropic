
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Cumulative list cost of this thread across all turns, priced at public list rates. Absent until cost tracking is available for the thread. Each figure is rounded to the nearest cent independently and the session's aggregate `usage.list_cost` additionally includes session runtime, so per-thread costs do not sum exactly to the session figure; the session figure is authoritative and is what a budget is enforced against.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionThreadUsageListCost
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}