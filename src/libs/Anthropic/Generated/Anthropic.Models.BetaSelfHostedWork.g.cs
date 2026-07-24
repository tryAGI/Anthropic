
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Work resource representing a unit of work in a self-hosted environment.<br/>
    /// Work items are queued when sessions are created or when long-dormant sessions<br/>
    /// receive new messages. The environment worker polls for work to execute in a<br/>
    /// self-hosted sandbox.
    /// </summary>
    public sealed partial class BetaSelfHostedWork
    {
        /// <summary>
        /// RFC 3339 timestamp when the work item was acknowledged and assigned to a self-hosted sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledged_at")]
        public string? AcknowledgedAt { get; set; }

        /// <summary>
        /// RFC 3339 timestamp when work was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The actual work to be performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaSessionWorkData Data { get; set; }

        /// <summary>
        /// Environment identifier this work belongs to (e.g., `env_...`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// Work identifier (e.g., 'work_...')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// RFC 3339 timestamp of the most recent heartbeat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_heartbeat_at")]
        public string? LatestHeartbeatAt { get; set; }

        /// <summary>
        /// User-provided metadata key-value pairs associated with this work item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Credential payload used by the environment worker to execute this work item. May be populated when polling for work; null on all other retrieval paths.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// RFC 3339 timestamp when work execution started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// Current state of the work item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaSelfHostedWorkStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaSelfHostedWorkState State { get; set; }

        /// <summary>
        /// RFC 3339 timestamp when stop was requested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_requested_at")]
        public string? StopRequestedAt { get; set; }

        /// <summary>
        /// RFC 3339 timestamp when work execution stopped
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopped_at")]
        public string? StoppedAt { get; set; }

        /// <summary>
        /// The type of object (always 'work')<br/>
        /// Default Value: work
        /// </summary>
        /// <default>"work"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "work";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSelfHostedWork" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// RFC 3339 timestamp when work was created
        /// </param>
        /// <param name="data">
        /// The actual work to be performed
        /// </param>
        /// <param name="environmentId">
        /// Environment identifier this work belongs to (e.g., `env_...`)
        /// </param>
        /// <param name="id">
        /// Work identifier (e.g., 'work_...')
        /// </param>
        /// <param name="metadata">
        /// User-provided metadata key-value pairs associated with this work item
        /// </param>
        /// <param name="state">
        /// Current state of the work item
        /// </param>
        /// <param name="acknowledgedAt">
        /// RFC 3339 timestamp when the work item was acknowledged and assigned to a self-hosted sandbox
        /// </param>
        /// <param name="latestHeartbeatAt">
        /// RFC 3339 timestamp of the most recent heartbeat
        /// </param>
        /// <param name="secret">
        /// Credential payload used by the environment worker to execute this work item. May be populated when polling for work; null on all other retrieval paths.
        /// </param>
        /// <param name="startedAt">
        /// RFC 3339 timestamp when work execution started
        /// </param>
        /// <param name="stopRequestedAt">
        /// RFC 3339 timestamp when stop was requested
        /// </param>
        /// <param name="stoppedAt">
        /// RFC 3339 timestamp when work execution stopped
        /// </param>
        /// <param name="type">
        /// The type of object (always 'work')<br/>
        /// Default Value: work
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSelfHostedWork(
            string createdAt,
            global::Anthropic.BetaSessionWorkData data,
            string environmentId,
            string id,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::Anthropic.BetaSelfHostedWorkState state,
            string? acknowledgedAt,
            string? latestHeartbeatAt,
            string? secret,
            string? startedAt,
            string? stopRequestedAt,
            string? stoppedAt,
            string type = "work")
        {
            this.AcknowledgedAt = acknowledgedAt;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LatestHeartbeatAt = latestHeartbeatAt;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Secret = secret;
            this.StartedAt = startedAt;
            this.State = state;
            this.StopRequestedAt = stopRequestedAt;
            this.StoppedAt = stoppedAt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSelfHostedWork" /> class.
        /// </summary>
        public BetaSelfHostedWork()
        {
        }

    }
}