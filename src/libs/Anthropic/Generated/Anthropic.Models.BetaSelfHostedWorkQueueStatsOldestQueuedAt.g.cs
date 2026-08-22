
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// RFC 3339 timestamp of oldest item in the work stream (includes both queued and pending items), null if stream empty
    /// </summary>
    public sealed partial class BetaSelfHostedWorkQueueStatsOldestQueuedAt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}