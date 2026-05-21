
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response after recording a heartbeat for a work item.
    /// </summary>
    public sealed partial class BetaSelfHostedWorkHeartbeatResponse
    {
        /// <summary>
        /// RFC 3339 timestamp of the actual heartbeat from DB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_heartbeat")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastHeartbeat { get; set; }

        /// <summary>
        /// Whether the heartbeat succeeded in extending the lease
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lease_extended")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LeaseExtended { get; set; }

        /// <summary>
        /// Current state of the work item (active/stopping/stopped)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaSelfHostedWorkHeartbeatResponseStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaSelfHostedWorkHeartbeatResponseState State { get; set; }

        /// <summary>
        /// Effective TTL applied to the lease
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TtlSeconds { get; set; }

        /// <summary>
        /// The type of response<br/>
        /// Default Value: work_heartbeat
        /// </summary>
        /// <default>"work_heartbeat"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "work_heartbeat";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSelfHostedWorkHeartbeatResponse" /> class.
        /// </summary>
        /// <param name="lastHeartbeat">
        /// RFC 3339 timestamp of the actual heartbeat from DB
        /// </param>
        /// <param name="leaseExtended">
        /// Whether the heartbeat succeeded in extending the lease
        /// </param>
        /// <param name="state">
        /// Current state of the work item (active/stopping/stopped)
        /// </param>
        /// <param name="ttlSeconds">
        /// Effective TTL applied to the lease
        /// </param>
        /// <param name="type">
        /// The type of response<br/>
        /// Default Value: work_heartbeat
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSelfHostedWorkHeartbeatResponse(
            string lastHeartbeat,
            bool leaseExtended,
            global::Anthropic.BetaSelfHostedWorkHeartbeatResponseState state,
            int ttlSeconds,
            string type = "work_heartbeat")
        {
            this.LastHeartbeat = lastHeartbeat ?? throw new global::System.ArgumentNullException(nameof(lastHeartbeat));
            this.LeaseExtended = leaseExtended;
            this.State = state;
            this.TtlSeconds = ttlSeconds;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSelfHostedWorkHeartbeatResponse" /> class.
        /// </summary>
        public BetaSelfHostedWorkHeartbeatResponse()
        {
        }

    }
}