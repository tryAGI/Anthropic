
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServiceAccountWorkspaceMemberCreateParams
    {
        /// <summary>
        /// Tagged service account ID to add.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        /// Role to assign to the service account in this workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.NoBillingWorkspaceRoleSchemaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.NoBillingWorkspaceRoleSchema WorkspaceRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAccountWorkspaceMemberCreateParams" /> class.
        /// </summary>
        /// <param name="serviceAccountId">
        /// Tagged service account ID to add.
        /// </param>
        /// <param name="workspaceRole">
        /// Role to assign to the service account in this workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceAccountWorkspaceMemberCreateParams(
            string serviceAccountId,
            global::Anthropic.NoBillingWorkspaceRoleSchema workspaceRole)
        {
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.WorkspaceRole = workspaceRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAccountWorkspaceMemberCreateParams" /> class.
        /// </summary>
        public ServiceAccountWorkspaceMemberCreateParams()
        {
        }

    }
}