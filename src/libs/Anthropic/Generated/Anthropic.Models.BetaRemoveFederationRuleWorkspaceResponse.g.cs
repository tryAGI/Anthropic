
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaRemoveFederationRuleWorkspaceResponse
    {
        /// <summary>
        /// Tagged ID of the federation rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("federation_rule_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FederationRuleId { get; set; }

        /// <summary>
        /// Default Value: federation_rule_workspace_deleted
        /// </summary>
        /// <default>"federation_rule_workspace_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "federation_rule_workspace_deleted";

        /// <summary>
        /// Tagged ID of the workspace named in the delete request. Removal is idempotent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRemoveFederationRuleWorkspaceResponse" /> class.
        /// </summary>
        /// <param name="federationRuleId">
        /// Tagged ID of the federation rule.
        /// </param>
        /// <param name="workspaceId">
        /// Tagged ID of the workspace named in the delete request. Removal is idempotent.
        /// </param>
        /// <param name="type">
        /// Default Value: federation_rule_workspace_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRemoveFederationRuleWorkspaceResponse(
            string federationRuleId,
            string workspaceId,
            string type = "federation_rule_workspace_deleted")
        {
            this.FederationRuleId = federationRuleId ?? throw new global::System.ArgumentNullException(nameof(federationRuleId));
            this.Type = type;
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRemoveFederationRuleWorkspaceResponse" /> class.
        /// </summary>
        public BetaRemoveFederationRuleWorkspaceResponse()
        {
        }

    }
}