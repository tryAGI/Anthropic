
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The memory's path at the time of this write. `null` if and only if `redacted_at` is set.
    /// </summary>
    public sealed partial class BetaManagedAgentsMemoryVersionPath
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}