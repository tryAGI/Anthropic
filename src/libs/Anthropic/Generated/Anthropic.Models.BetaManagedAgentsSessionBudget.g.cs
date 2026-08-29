
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The session's enforced spend ceiling, or null when no budget is set.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionBudget
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}