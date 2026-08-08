
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaWebhookVaultCredentialRefreshFailedEventData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"vault_credential.refresh_failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "vault_credential.refresh_failed";

        /// <summary>
        /// ID of the vault credential that triggered the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// ID of the vault that owns this credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookVaultCredentialRefreshFailedEventData" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the vault credential that triggered the event.
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="vaultId">
        /// ID of the vault that owns this credential.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebhookVaultCredentialRefreshFailedEventData(
            string id,
            string organizationId,
            string workspaceId,
            string vaultId,
            string type = "vault_credential.refresh_failed")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.VaultId = vaultId ?? throw new global::System.ArgumentNullException(nameof(vaultId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookVaultCredentialRefreshFailedEventData" /> class.
        /// </summary>
        public BetaWebhookVaultCredentialRefreshFailedEventData()
        {
        }

    }
}