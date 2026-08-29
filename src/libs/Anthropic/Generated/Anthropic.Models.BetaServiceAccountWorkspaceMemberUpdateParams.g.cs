
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaServiceAccountWorkspaceMemberUpdateParams
    {
        /// <summary>
        /// New role for the service account in this workspace.
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
        /// Initializes a new instance of the <see cref="BetaServiceAccountWorkspaceMemberUpdateParams" /> class.
        /// </summary>
        /// <param name="workspaceRole">
        /// New role for the service account in this workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaServiceAccountWorkspaceMemberUpdateParams(
            global::Anthropic.BetaNoBillingWorkspaceRoleSchema workspaceRole)
        {
            this.WorkspaceRole = workspaceRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServiceAccountWorkspaceMemberUpdateParams" /> class.
        /// </summary>
        public BetaServiceAccountWorkspaceMemberUpdateParams()
        {
        }

    }
}