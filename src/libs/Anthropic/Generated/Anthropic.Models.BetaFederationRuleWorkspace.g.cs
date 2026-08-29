
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaFederationRuleWorkspace
    {
        /// <summary>
        /// When this workspace was enabled for the rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Tagged ID (`user_...` or `svac_...`) of the actor that enabled this workspace for the rule, if known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_actor_id")]
        public string? CreatedByActorId { get; set; }

        /// <summary>
        /// Tagged ID of the federation rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("federation_rule_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FederationRuleId { get; set; }

        /// <summary>
        /// Default Value: federation_rule_workspace
        /// </summary>
        /// <default>"federation_rule_workspace"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "federation_rule_workspace";

        /// <summary>
        /// Tagged ID of the workspace this rule is enabled for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Workspace display name. Populated when listing; null in the enable response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_name")]
        public string? WorkspaceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationRuleWorkspace" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// When this workspace was enabled for the rule.
        /// </param>
        /// <param name="federationRuleId">
        /// Tagged ID of the federation rule.
        /// </param>
        /// <param name="workspaceId">
        /// Tagged ID of the workspace this rule is enabled for.
        /// </param>
        /// <param name="createdByActorId">
        /// Tagged ID (`user_...` or `svac_...`) of the actor that enabled this workspace for the rule, if known.
        /// </param>
        /// <param name="workspaceName">
        /// Workspace display name. Populated when listing; null in the enable response.
        /// </param>
        /// <param name="type">
        /// Default Value: federation_rule_workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFederationRuleWorkspace(
            global::System.DateTime createdAt,
            string federationRuleId,
            string workspaceId,
            string? createdByActorId,
            string? workspaceName,
            string type = "federation_rule_workspace")
        {
            this.CreatedAt = createdAt;
            this.CreatedByActorId = createdByActorId;
            this.FederationRuleId = federationRuleId ?? throw new global::System.ArgumentNullException(nameof(federationRuleId));
            this.Type = type;
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.WorkspaceName = workspaceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFederationRuleWorkspace" /> class.
        /// </summary>
        public BetaFederationRuleWorkspace()
        {
        }

    }
}