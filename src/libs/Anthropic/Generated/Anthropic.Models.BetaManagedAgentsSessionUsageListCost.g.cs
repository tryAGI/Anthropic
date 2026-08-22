
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Cumulative list cost of the session across all turns, priced at public list rates. Absent until cost tracking is available for the session.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionUsageListCost
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}