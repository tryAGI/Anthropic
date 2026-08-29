
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaCreateWorkspaceMemberParams
    {
        /// <summary>
        /// ID of the User.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Role of the new Workspace Member. Cannot be `workspace_billing`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaNoBillingWorkspaceRoleSchemaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaNoBillingWorkspaceRoleSchema WorkspaceRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateWorkspaceMemberParams" /> class.
        /// </summary>
        /// <param name="userId">
        /// ID of the User.
        /// </param>
        /// <param name="workspaceRole">
        /// Role of the new Workspace Member. Cannot be `workspace_billing`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateWorkspaceMemberParams(
            string userId,
            global::Anthropic.BetaNoBillingWorkspaceRoleSchema workspaceRole)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.WorkspaceRole = workspaceRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateWorkspaceMemberParams" /> class.
        /// </summary>
        public BetaCreateWorkspaceMemberParams()
        {
        }

    }
}