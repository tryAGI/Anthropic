
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The session's configured budget at the snapshot time, or null when the session has no budget.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionUsageEventBudget
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}