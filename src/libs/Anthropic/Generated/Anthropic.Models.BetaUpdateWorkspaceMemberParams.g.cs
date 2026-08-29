
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaUpdateWorkspaceMemberParams
    {
        /// <summary>
        /// New workspace role for the User.
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
        /// Initializes a new instance of the <see cref="BetaUpdateWorkspaceMemberParams" /> class.
        /// </summary>
        /// <param name="workspaceRole">
        /// New workspace role for the User.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUpdateWorkspaceMemberParams(
            global::Anthropic.BetaWorkspaceRoleSchema workspaceRole)
        {
            this.WorkspaceRole = workspaceRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateWorkspaceMemberParams" /> class.
        /// </summary>
        public BetaUpdateWorkspaceMemberParams()
        {
        }

    }
}