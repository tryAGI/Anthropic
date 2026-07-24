
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for creating a `deployment`.
    /// </summary>
    public sealed partial class BetaManagedAgentsCreateDeploymentParams
    {
        /// <summary>
        /// Human-readable name for the deployment.
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
        /// Agent to deploy. Accepts the `agent` ID string, which pins the latest version, or an `agent` object with both id and version specified. The agent must exist and not be archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentUnionParamsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsAgentUnionParams Agent { get; set; }

        /// <summary>
        /// ID of the `environment` defining the container configuration for sessions created from this deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// Vault IDs for stored credentials the agent can use during sessions created from this deployment. Maximum 50.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_ids")]
        public global::System.Collections.Generic.IList<string>? VaultIds { get; set; }

        /// <summary>
        /// Events to send to each session immediately after creation. At least 1, maximum 50.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams> InitialEvents { get; set; }

        /// <summary>
        /// Resources (e.g. repositories, files) to mount into each session's container. Maximum 500.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? Resources { get; set; }

        /// <summary>
        /// Arbitrary key-value metadata. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Optional recurring cron schedule. When present, the deployment fires automatically. Both expression and timezone are required when schedule is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsScheduleParamsJsonConverter))]
        public global::Anthropic.BetaManagedAgentsScheduleParams? Schedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateDeploymentParams" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the deployment.
        /// </param>
        /// <param name="agent">
        /// Agent to deploy. Accepts the `agent` ID string, which pins the latest version, or an `agent` object with both id and version specified. The agent must exist and not be archived.
        /// </param>
        /// <param name="environmentId">
        /// ID of the `environment` defining the container configuration for sessions created from this deployment.
        /// </param>
        /// <param name="initialEvents">
        /// Events to send to each session immediately after creation. At least 1, maximum 50.
        /// </param>
        /// <param name="description">
        /// Description of what the deployment does.
        /// </param>
        /// <param name="vaultIds">
        /// Vault IDs for stored credentials the agent can use during sessions created from this deployment. Maximum 50.
        /// </param>
        /// <param name="resources">
        /// Resources (e.g. repositories, files) to mount into each session's container. Maximum 500.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </param>
        /// <param name="schedule">
        /// Optional recurring cron schedule. When present, the deployment fires automatically. Both expression and timezone are required when schedule is set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCreateDeploymentParams(
            string name,
            global::Anthropic.BetaManagedAgentsAgentUnionParams agent,
            string environmentId,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams> initialEvents,
            string? description,
            global::System.Collections.Generic.IList<string>? vaultIds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? resources,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::Anthropic.BetaManagedAgentsScheduleParams? schedule)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Agent = agent;
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.VaultIds = vaultIds;
            this.InitialEvents = initialEvents ?? throw new global::System.ArgumentNullException(nameof(initialEvents));
            this.Resources = resources;
            this.Metadata = metadata;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateDeploymentParams" /> class.
        /// </summary>
        public BetaManagedAgentsCreateDeploymentParams()
        {
        }

    }
}