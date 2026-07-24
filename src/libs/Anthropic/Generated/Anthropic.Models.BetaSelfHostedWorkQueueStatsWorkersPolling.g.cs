
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Number of workers that have polled for work in the last 30 seconds. Requires worker_id to be sent with poll requests.
    /// </summary>
    public sealed partial class BetaSelfHostedWorkQueueStatsWorkersPolling
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}