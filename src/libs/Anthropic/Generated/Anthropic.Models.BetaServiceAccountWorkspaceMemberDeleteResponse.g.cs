
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaServiceAccountWorkspaceMemberDeleteResponse
    {
        /// <summary>
        /// Tagged service account ID (`svac_...`) named in the delete request. Removal is idempotent; see the endpoint description for the implicit-membership no-op.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        /// Default Value: service_account_workspace_member_deleted
        /// </summary>
        /// <default>"service_account_workspace_member_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "service_account_workspace_member_deleted";

        /// <summary>
        /// Tagged workspace ID (`wrkspc_...`) named in the delete request.
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
        /// Initializes a new instance of the <see cref="BetaServiceAccountWorkspaceMemberDeleteResponse" /> class.
        /// </summary>
        /// <param name="serviceAccountId">
        /// Tagged service account ID (`svac_...`) named in the delete request. Removal is idempotent; see the endpoint description for the implicit-membership no-op.
        /// </param>
        /// <param name="workspaceId">
        /// Tagged workspace ID (`wrkspc_...`) named in the delete request.
        /// </param>
        /// <param name="type">
        /// Default Value: service_account_workspace_member_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaServiceAccountWorkspaceMemberDeleteResponse(
            string serviceAccountId,
            string workspaceId,
            string type = "service_account_workspace_member_deleted")
        {
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.Type = type;
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServiceAccountWorkspaceMemberDeleteResponse" /> class.
        /// </summary>
        public BetaServiceAccountWorkspaceMemberDeleteResponse()
        {
        }

    }
}