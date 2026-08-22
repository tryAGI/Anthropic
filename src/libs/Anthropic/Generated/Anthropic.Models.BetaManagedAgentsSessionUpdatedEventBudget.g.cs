
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The session's budget after the update: the new budget when set or replaced, or null when the update removed it. Present only when the update changed the budget.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionUpdatedEventBudget
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}