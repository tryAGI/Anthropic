
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaWorkspaceMemberSchema
    {
        /// <summary>
        /// Object type.<br/>
        /// For Workspace Members, this is always `"workspace_member"`.<br/>
        /// Default Value: workspace_member
        /// </summary>
        /// <default>"workspace_member"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "workspace_member";

        /// <summary>
        /// ID of the User.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// ID of the Workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Role of the Workspace Member.
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
        /// Initializes a new instance of the <see cref="BetaWorkspaceMemberSchema" /> class.
        /// </summary>
        /// <param name="userId">
        /// ID of the User.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the Workspace.
        /// </param>
        /// <param name="workspaceRole">
        /// Role of the Workspace Member.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Workspace Members, this is always `"workspace_member"`.<br/>
        /// Default Value: workspace_member
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspaceMemberSchema(
            string userId,
            string workspaceId,
            global::Anthropic.BetaWorkspaceRoleSchema workspaceRole,
            string type = "workspace_member")
        {
            this.Type = type;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.WorkspaceRole = workspaceRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceMemberSchema" /> class.
        /// </summary>
        public BetaWorkspaceMemberSchema()
        {
        }

    }
}