
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaServiceAccountWorkspaceMember
    {
        /// <summary>
        /// Tagged ID (`user_...`/`svac_...`) of the actor who created this membership.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_actor_id")]
        public string? CreatedByActorId { get; set; }

        /// <summary>
        /// True when this is the implicit default-workspace membership every service account has when no explicit membership exists. Implicit memberships have role `workspace_user` and cannot be removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("implicit")]
        public bool? Implicit { get; set; }

        /// <summary>
        /// Tagged service account ID (`svac_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        /// Default Value: service_account_workspace_member
        /// </summary>
        /// <default>"service_account_workspace_member"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "service_account_workspace_member";

        /// <summary>
        /// Tagged workspace ID (`wrkspc_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Role of the service account in this workspace. Service accounts cannot hold the `workspace_billing` role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaWorkspaceRoleSchemaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaWorkspaceRoleSchema WorkspaceRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServiceAccountWorkspaceMember" /> class.
        /// </summary>
        /// <param name="serviceAccountId">
        /// Tagged service account ID (`svac_...`).
        /// </param>
        /// <param name="workspaceId">
        /// Tagged workspace ID (`wrkspc_...`).
        /// </param>
        /// <param name="workspaceRole">
        /// Role of the service account in this workspace. Service accounts cannot hold the `workspace_billing` role.
        /// </param>
        /// <param name="createdByActorId">
        /// Tagged ID (`user_...`/`svac_...`) of the actor who created this membership.
        /// </param>
        /// <param name="implicit">
        /// True when this is the implicit default-workspace membership every service account has when no explicit membership exists. Implicit memberships have role `workspace_user` and cannot be removed.
        /// </param>
        /// <param name="type">
        /// Default Value: service_account_workspace_member
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaServiceAccountWorkspaceMember(
            string serviceAccountId,
            string workspaceId,
            global::Anthropic.BetaWorkspaceRoleSchema workspaceRole,
            string? createdByActorId,
            bool? @implicit,
            string type = "service_account_workspace_member")
        {
            this.CreatedByActorId = createdByActorId;
            this.Implicit = @implicit;
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.Type = type;
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.WorkspaceRole = workspaceRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServiceAccountWorkspaceMember" /> class.
        /// </summary>
        public BetaServiceAccountWorkspaceMember()
        {
        }

    }
}