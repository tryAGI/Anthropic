
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A deployment is a configured instance of an agent — it binds the agent to everything needed to run it autonomously: an environment, credentials, initial events, and an optional schedule.<br/>
    /// Example: {"type":"deployment","id":"depl_011CZkZcDH3vPqd7xnEfwTai","name":"Daily order report","description":"Compiles yesterday\u0027s orders into a report every weekday morning.","agent":{"type":"agent","id":"agent_011CZkYpogX7uDKUyvBTophP","version":1},"environment_id":"env_011CZkZ9X2dpNyB7HsEFoRfW","vault_ids":["vlt_011CZkZDLs7fYzm1hXNPeRjv"],"initial_events":[{"type":"user.message","content":[{"type":"text","text":"Compile yesterday\u0027s orders into report.md."}]}],"resources":[],"metadata":{},"schedule":{"type":"cron","expression":"0 9 * * 1-5","timezone":"America/Los_Angeles","last_run_at":"2026-03-16T16:00:09Z","upcoming_runs_at":["2026-03-17T16:00:00Z","2026-03-18T16:00:00Z"]},"status":"active","paused_reason":null,"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z","archived_at":null}
    /// </summary>
    public sealed partial class BetaManagedAgentsDeployment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeploymentTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsDeploymentType Type { get; set; }

        /// <summary>
        /// Unique identifier for this deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of what the deployment does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Reference to the agent this deployment runs, resolved to a concrete version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsAgentReference Agent { get; set; }

        /// <summary>
        /// ID of the `environment` where sessions run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// Vault IDs supplying stored credentials for sessions created from this deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VaultIds { get; set; }

        /// <summary>
        /// Events sent to each session immediately after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEvent> InitialEvents { get; set; }

        /// <summary>
        /// Resources attached to sessions created from this deployment. Echoes the input minus write-only credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceConfig> Resources { get; set; }

        /// <summary>
        /// Arbitrary key-value metadata. Maximum 16 pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Recurring cron schedule. Presence enables scheduled execution; null means manual-only. Includes computed timestamps (next fire times, last run) on the cron variant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsScheduleJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSchedule? Schedule { get; set; }

        /// <summary>
        /// Computed status of the deployment: `active` or `paused`. Archived deployments report `active` with `archived_at` set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeploymentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsDeploymentStatus Status { get; set; }

        /// <summary>
        /// Why the deployment is paused. Non-null exactly when status is paused; null otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paused_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeploymentPausedReasonJsonConverter))]
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReason? PausedReason { get; set; }

        /// <summary>
        /// Time the deployment was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time the deployment was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Time the deployment was archived. Null if not archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeployment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this deployment.
        /// </param>
        /// <param name="name">
        /// Human-readable name.
        /// </param>
        /// <param name="agent">
        /// Reference to the agent this deployment runs, resolved to a concrete version.
        /// </param>
        /// <param name="environmentId">
        /// ID of the `environment` where sessions run.
        /// </param>
        /// <param name="vaultIds">
        /// Vault IDs supplying stored credentials for sessions created from this deployment.
        /// </param>
        /// <param name="initialEvents">
        /// Events sent to each session immediately after creation.
        /// </param>
        /// <param name="resources">
        /// Resources attached to sessions created from this deployment. Echoes the input minus write-only credentials.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata. Maximum 16 pairs.
        /// </param>
        /// <param name="status">
        /// Computed status of the deployment: `active` or `paused`. Archived deployments report `active` with `archived_at` set.
        /// </param>
        /// <param name="createdAt">
        /// Time the deployment was created.
        /// </param>
        /// <param name="updatedAt">
        /// Time the deployment was last updated.
        /// </param>
        /// <param name="type"></param>
        /// <param name="description">
        /// Description of what the deployment does.
        /// </param>
        /// <param name="schedule">
        /// Recurring cron schedule. Presence enables scheduled execution; null means manual-only. Includes computed timestamps (next fire times, last run) on the cron variant.
        /// </param>
        /// <param name="pausedReason">
        /// Why the deployment is paused. Non-null exactly when status is paused; null otherwise.
        /// </param>
        /// <param name="archivedAt">
        /// Time the deployment was archived. Null if not archived.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsDeployment(
            string id,
            string name,
            global::Anthropic.BetaManagedAgentsAgentReference agent,
            string environmentId,
            global::System.Collections.Generic.IList<string> vaultIds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEvent> initialEvents,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceConfig> resources,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::Anthropic.BetaManagedAgentsDeploymentStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Anthropic.BetaManagedAgentsDeploymentType type,
            string? description,
            global::Anthropic.BetaManagedAgentsSchedule? schedule,
            global::Anthropic.BetaManagedAgentsDeploymentPausedReason? pausedReason,
            global::System.DateTime? archivedAt)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Agent = agent ?? throw new global::System.ArgumentNullException(nameof(agent));
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.VaultIds = vaultIds ?? throw new global::System.ArgumentNullException(nameof(vaultIds));
            this.InitialEvents = initialEvents ?? throw new global::System.ArgumentNullException(nameof(initialEvents));
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Schedule = schedule;
            this.Status = status;
            this.PausedReason = pausedReason;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeployment" /> class.
        /// </summary>
        public BetaManagedAgentsDeployment()
        {
        }

    }
}