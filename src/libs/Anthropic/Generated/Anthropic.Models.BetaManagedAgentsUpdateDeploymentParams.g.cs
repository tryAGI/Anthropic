
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for updating a `deployment`. Omit a field to preserve its current value.
    /// </summary>
    public sealed partial class BetaManagedAgentsUpdateDeploymentParams
    {
        /// <summary>
        /// Human-readable name. Must be non-empty. Omit to preserve. Cannot be cleared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description. Omit to preserve; send empty string or null to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Agent to deploy. Accepts the `agent` ID string, which re-pins to the latest version, or an `agent` object with both id and version specified. Omit to preserve. Cannot be cleared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentUnionParamsJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAgentUnionParams? Agent { get; set; }

        /// <summary>
        /// ID of the `environment` where sessions run. Omit to preserve. Cannot be cleared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// Vault IDs. Full replacement. Omit to preserve; send empty array or null to clear. Maximum 50.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_ids")]
        public global::System.Collections.Generic.IList<string>? VaultIds { get; set; }

        /// <summary>
        /// Initial events. Full replacement. Omit to preserve. Cannot be cleared. At least 1, maximum 50.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_events")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams>? InitialEvents { get; set; }

        /// <summary>
        /// Session resources. Full replacement. Omit to preserve; send empty array or null to clear. Maximum 500.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? Resources { get; set; }

        /// <summary>
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omit the field to preserve. The stored bag is limited to 16 keys (up to 64 chars each) with values up to 512 chars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string?>? Metadata { get; set; }

        /// <summary>
        /// Cron schedule. Full replacement. Omit to preserve; send null to clear (revert to manual-only).
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateDeploymentParams" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name. Must be non-empty. Omit to preserve. Cannot be cleared.
        /// </param>
        /// <param name="description">
        /// Description. Omit to preserve; send empty string or null to clear.
        /// </param>
        /// <param name="agent">
        /// Agent to deploy. Accepts the `agent` ID string, which re-pins to the latest version, or an `agent` object with both id and version specified. Omit to preserve. Cannot be cleared.
        /// </param>
        /// <param name="environmentId">
        /// ID of the `environment` where sessions run. Omit to preserve. Cannot be cleared.
        /// </param>
        /// <param name="vaultIds">
        /// Vault IDs. Full replacement. Omit to preserve; send empty array or null to clear. Maximum 50.
        /// </param>
        /// <param name="initialEvents">
        /// Initial events. Full replacement. Omit to preserve. Cannot be cleared. At least 1, maximum 50.
        /// </param>
        /// <param name="resources">
        /// Session resources. Full replacement. Omit to preserve; send empty array or null to clear. Maximum 500.
        /// </param>
        /// <param name="metadata">
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omit the field to preserve. The stored bag is limited to 16 keys (up to 64 chars each) with values up to 512 chars.
        /// </param>
        /// <param name="schedule">
        /// Cron schedule. Full replacement. Omit to preserve; send null to clear (revert to manual-only).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUpdateDeploymentParams(
            string? name,
            string? description,
            global::Anthropic.BetaManagedAgentsAgentUnionParams? agent,
            string? environmentId,
            global::System.Collections.Generic.IList<string>? vaultIds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams>? initialEvents,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? resources,
            global::System.Collections.Generic.Dictionary<string, string?>? metadata,
            global::Anthropic.BetaManagedAgentsScheduleParams? schedule)
        {
            this.Name = name;
            this.Description = description;
            this.Agent = agent;
            this.EnvironmentId = environmentId;
            this.VaultIds = vaultIds;
            this.InitialEvents = initialEvents;
            this.Resources = resources;
            this.Metadata = metadata;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateDeploymentParams" /> class.
        /// </summary>
        public BetaManagedAgentsUpdateDeploymentParams()
        {
        }

    }
}