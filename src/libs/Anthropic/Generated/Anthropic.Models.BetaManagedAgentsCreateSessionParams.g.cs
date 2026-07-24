
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for creating a `session`.<br/>
    /// Example: {"agent":"agent_011CZkYpogX7uDKUyvBTophP","environment_id":"env_011CZkZ9X2dpNyB7HsEFoRfW","title":"Order #1234 inquiry"}
    /// </summary>
    public sealed partial class BetaManagedAgentsCreateSessionParams
    {
        /// <summary>
        /// Agent identifier. Accepts the `agent` ID string, which pins the latest version for the session, or an `agent` object with both id and version specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCreateSessionAgentUnionParamsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParams Agent { get; set; }

        /// <summary>
        /// ID of the `environment` defining the container configuration for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// Human-readable session title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Arbitrary key-value metadata attached to the session. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Resources (e.g. repositories, files) to mount into the session's container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? Resources { get; set; }

        /// <summary>
        /// Vault IDs for stored credentials the agent can use during the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_ids")]
        public global::System.Collections.Generic.IList<string>? VaultIds { get; set; }

        /// <summary>
        /// Initial events to send to the `session` at creation, processed in order. Supports `user.message` and `user.define_outcome` events. Maximum 50 events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_events")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionInitialEventParams>? InitialEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateSessionParams" /> class.
        /// </summary>
        /// <param name="agent">
        /// Agent identifier. Accepts the `agent` ID string, which pins the latest version for the session, or an `agent` object with both id and version specified.
        /// </param>
        /// <param name="environmentId">
        /// ID of the `environment` defining the container configuration for this session.
        /// </param>
        /// <param name="title">
        /// Human-readable session title.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata attached to the session. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </param>
        /// <param name="resources">
        /// Resources (e.g. repositories, files) to mount into the session's container.
        /// </param>
        /// <param name="vaultIds">
        /// Vault IDs for stored credentials the agent can use during the session.
        /// </param>
        /// <param name="initialEvents">
        /// Initial events to send to the `session` at creation, processed in order. Supports `user.message` and `user.define_outcome` events. Maximum 50 events.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCreateSessionParams(
            global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParams agent,
            string environmentId,
            string? title,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? resources,
            global::System.Collections.Generic.IList<string>? vaultIds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionInitialEventParams>? initialEvents)
        {
            this.Agent = agent;
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.Title = title;
            this.Metadata = metadata;
            this.Resources = resources;
            this.VaultIds = vaultIds;
            this.InitialEvents = initialEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateSessionParams" /> class.
        /// </summary>
        public BetaManagedAgentsCreateSessionParams()
        {
        }

    }
}