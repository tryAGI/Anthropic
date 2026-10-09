
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A work item's lease as the server holds it.
    /// </summary>
    public sealed partial class BetaWorkLeaseState
    {
        /// <summary>
        /// RFC 3339 timestamp of the stored heartbeat, or null if there has been none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_heartbeat")]
        public string? LastHeartbeat { get; set; }

        /// <summary>
        /// Always false: a refused heartbeat does not extend the lease
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lease_extended")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LeaseExtended { get; set; }

        /// <summary>
        /// Current state of the work item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaWorkLeaseStateStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaWorkLeaseStateState State { get; set; }

        /// <summary>
        /// TTL of the lease
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TtlSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkLeaseState" /> class.
        /// </summary>
        /// <param name="leaseExtended">
        /// Always false: a refused heartbeat does not extend the lease
        /// </param>
        /// <param name="state">
        /// Current state of the work item
        /// </param>
        /// <param name="ttlSeconds">
        /// TTL of the lease
        /// </param>
        /// <param name="lastHeartbeat">
        /// RFC 3339 timestamp of the stored heartbeat, or null if there has been none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkLeaseState(
            bool leaseExtended,
            global::Anthropic.BetaWorkLeaseStateState state,
            int ttlSeconds,
            string? lastHeartbeat)
        {
            this.LastHeartbeat = lastHeartbeat;
            this.LeaseExtended = leaseExtended;
            this.State = state;
            this.TtlSeconds = ttlSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkLeaseState" /> class.
        /// </summary>
        public BetaWorkLeaseState()
        {
        }

    }
}