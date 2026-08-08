
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Reclaim unacknowledged work items older than this many milliseconds. If omitted, uses the default (5000ms).
    /// </summary>
    public sealed partial class BetaPollWorkV1EnvironmentsEnvironmentIdWorkPollGetReclaimOlderThanMs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}