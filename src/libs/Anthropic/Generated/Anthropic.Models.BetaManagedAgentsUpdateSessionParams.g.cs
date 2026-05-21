
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for updating a `session`. Omit a field to preserve its current value.<br/>
    /// Example: {"title":"Order #1234 inquiry"}
    /// </summary>
    public sealed partial class BetaManagedAgentsUpdateSessionParams
    {
        /// <summary>
        /// Human-readable session title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omit the field to preserve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string?>? Metadata { get; set; }

        /// <summary>
        /// Vault IDs (`vlt_*`) to attach to the session. Not yet supported; requests setting this field are rejected. Reserved for future use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_ids")]
        public global::System.Collections.Generic.IList<string>? VaultIds { get; set; }

        /// <summary>
        /// Agent configuration update. Only `tools` and `mcp_servers` are updatable mid-session. Only valid for sessions created from an agent or deployment reference. The session must not be running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::Anthropic.BetaManagedAgentsSessionAgentUpdate? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateSessionParams" /> class.
        /// </summary>
        /// <param name="title">
        /// Human-readable session title.
        /// </param>
        /// <param name="metadata">
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omit the field to preserve.
        /// </param>
        /// <param name="vaultIds">
        /// Vault IDs (`vlt_*`) to attach to the session. Not yet supported; requests setting this field are rejected. Reserved for future use.
        /// </param>
        /// <param name="agent">
        /// Agent configuration update. Only `tools` and `mcp_servers` are updatable mid-session. Only valid for sessions created from an agent or deployment reference. The session must not be running.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUpdateSessionParams(
            string? title,
            global::System.Collections.Generic.Dictionary<string, string?>? metadata,
            global::System.Collections.Generic.IList<string>? vaultIds,
            global::Anthropic.BetaManagedAgentsSessionAgentUpdate? agent)
        {
            this.Title = title;
            this.Metadata = metadata;
            this.VaultIds = vaultIds;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateSessionParams" /> class.
        /// </summary>
        public BetaManagedAgentsUpdateSessionParams()
        {
        }

    }
}