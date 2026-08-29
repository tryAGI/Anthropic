
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
        public object? Metadata { get; set; }

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
        /// Enforced spend ceiling for the session. Set an object to replace the budget of a session that was created with one, or `null` to remove it; omit to preserve. A budget cannot be added to a session created without one (rejected with reason `budget_create_only`), and a removed budget cannot be re-added. Allowed in any non-terminated status. Lowering `max_list_cost` to at or below the session's consumed list cost is rejected with reason `budget_not_raised`, and every model the session can run must have a public list price or the request is rejected with reason `model_not_budgetable`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        public global::Anthropic.BetaManagedAgentsBudget? Budget { get; set; }

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
        /// <param name="budget">
        /// Enforced spend ceiling for the session. Set an object to replace the budget of a session that was created with one, or `null` to remove it; omit to preserve. A budget cannot be added to a session created without one (rejected with reason `budget_create_only`), and a removed budget cannot be re-added. Allowed in any non-terminated status. Lowering `max_list_cost` to at or below the session's consumed list cost is rejected with reason `budget_not_raised`, and every model the session can run must have a public list price or the request is rejected with reason `model_not_budgetable`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUpdateSessionParams(
            string? title,
            object? metadata,
            global::System.Collections.Generic.IList<string>? vaultIds,
            global::Anthropic.BetaManagedAgentsSessionAgentUpdate? agent,
            global::Anthropic.BetaManagedAgentsBudget? budget)
        {
            this.Title = title;
            this.Metadata = metadata;
            this.VaultIds = vaultIds;
            this.Agent = agent;
            this.Budget = budget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateSessionParams" /> class.
        /// </summary>
        public BetaManagedAgentsUpdateSessionParams()
        {
        }

    }
}