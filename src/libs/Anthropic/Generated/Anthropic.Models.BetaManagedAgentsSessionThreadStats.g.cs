
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Timing statistics for this thread. Null until the thread's first status transition.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionThreadStats
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}