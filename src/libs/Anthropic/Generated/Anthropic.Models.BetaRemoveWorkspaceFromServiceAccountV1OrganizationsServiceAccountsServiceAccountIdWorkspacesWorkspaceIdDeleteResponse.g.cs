
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaRemoveWorkspaceFromServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesWorkspaceIdDeleteResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaRemoveWorkspaceFromServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesWorkspaceIdDeleteResponseError Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Default Value: error
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRemoveWorkspaceFromServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesWorkspaceIdDeleteResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="requestId"></param>
        /// <param name="type">
        /// Default Value: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRemoveWorkspaceFromServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesWorkspaceIdDeleteResponse(
            global::Anthropic.BetaRemoveWorkspaceFromServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesWorkspaceIdDeleteResponseError error,
            string? requestId,
            string type = "error")
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRemoveWorkspaceFromServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesWorkspaceIdDeleteResponse" /> class.
        /// </summary>
        public BetaRemoveWorkspaceFromServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesWorkspaceIdDeleteResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaRemoveWorkspaceFromServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesWorkspaceIdDeleteResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaRemoveWorkspaceFromServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesWorkspaceIdDeleteResponse FromError(global::Anthropic.BetaRemoveWorkspaceFromServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesWorkspaceIdDeleteResponseError error)
        {
            return new BetaRemoveWorkspaceFromServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesWorkspaceIdDeleteResponse
            {
                Error = error,
            };
        }

    }
}