
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaDeleteWorkspaceMemberResponse
    {
        /// <summary>
        /// Deleted object type.<br/>
        /// For Workspace Members, this is always `"workspace_member_deleted"`.<br/>
        /// Default Value: workspace_member_deleted
        /// </summary>
        /// <default>"workspace_member_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "workspace_member_deleted";

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteWorkspaceMemberResponse" /> class.
        /// </summary>
        /// <param name="userId">
        /// ID of the User.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the Workspace.
        /// </param>
        /// <param name="type">
        /// Deleted object type.<br/>
        /// For Workspace Members, this is always `"workspace_member_deleted"`.<br/>
        /// Default Value: workspace_member_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeleteWorkspaceMemberResponse(
            string userId,
            string workspaceId,
            string type = "workspace_member_deleted")
        {
            this.Type = type;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteWorkspaceMemberResponse" /> class.
        /// </summary>
        public BetaDeleteWorkspaceMemberResponse()
        {
        }

    }
}