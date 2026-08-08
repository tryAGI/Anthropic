
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A persistent, append-only record of a single deployment execution. Records session creation success or failure — no session lifecycle tracking.
    /// </summary>
    public sealed partial class BetaManagedAgentsDeploymentRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeploymentRunTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsDeploymentRunType Type { get; set; }

        /// <summary>
        /// Unique identifier for this run (`drun_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the deployment that produced this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// What triggered this run and trigger-specific metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTriggerContextJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsTriggerContext TriggerContext { get; set; }

        /// <summary>
        /// Populated on success. Null on creation failure. Exactly one of session_id or error is non-null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Populated on creation failure. Null on success. Exactly one of session_id or error is non-null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRunErrorJsonConverter))]
        public global::Anthropic.BetaManagedAgentsRunError? Error { get; set; }

        /// <summary>
        /// Snapshot of the agent at fire time. Always fully resolved — deployments pin agent + version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsAgentReference Agent { get; set; }

        /// <summary>
        /// Time this run record was persisted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeploymentRun" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this run (`drun_...`).
        /// </param>
        /// <param name="deploymentId">
        /// ID of the deployment that produced this run.
        /// </param>
        /// <param name="triggerContext">
        /// What triggered this run and trigger-specific metadata.
        /// </param>
        /// <param name="agent">
        /// Snapshot of the agent at fire time. Always fully resolved — deployments pin agent + version.
        /// </param>
        /// <param name="createdAt">
        /// Time this run record was persisted.
        /// </param>
        /// <param name="type"></param>
        /// <param name="sessionId">
        /// Populated on success. Null on creation failure. Exactly one of session_id or error is non-null.
        /// </param>
        /// <param name="error">
        /// Populated on creation failure. Null on success. Exactly one of session_id or error is non-null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsDeploymentRun(
            string id,
            string deploymentId,
            global::Anthropic.BetaManagedAgentsTriggerContext triggerContext,
            global::Anthropic.BetaManagedAgentsAgentReference agent,
            global::System.DateTime createdAt,
            global::Anthropic.BetaManagedAgentsDeploymentRunType type,
            string? sessionId,
            global::Anthropic.BetaManagedAgentsRunError? error)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.TriggerContext = triggerContext;
            this.SessionId = sessionId;
            this.Error = error;
            this.Agent = agent ?? throw new global::System.ArgumentNullException(nameof(agent));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeploymentRun" /> class.
        /// </summary>
        public BetaManagedAgentsDeploymentRun()
        {
        }

    }
}