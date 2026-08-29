
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Azure Key Vault provider configuration.
    /// </summary>
    public sealed partial class BetaAzureExternalKeyConfigParams
    {
        /// <summary>
        /// Azure AD application (client) ID. Omit to use Anthropic's multitenant app. Provide only if using a single-tenant app registration in the customer's directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Name of the key within the vault.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyName { get; set; }

        /// <summary>
        /// Azure AD tenant ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"azure"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "azure";

        /// <summary>
        /// Key Vault data-plane URI — `https://{vault-name}.vault.azure.net` or `https://{hsm-name}.managedhsm.azure.net`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAzureExternalKeyConfigParams" /> class.
        /// </summary>
        /// <param name="keyName">
        /// Name of the key within the vault.
        /// </param>
        /// <param name="tenantId">
        /// Azure AD tenant ID.
        /// </param>
        /// <param name="vaultUri">
        /// Key Vault data-plane URI — `https://{vault-name}.vault.azure.net` or `https://{hsm-name}.managedhsm.azure.net`.
        /// </param>
        /// <param name="clientId">
        /// Azure AD application (client) ID. Omit to use Anthropic's multitenant app. Provide only if using a single-tenant app registration in the customer's directory.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAzureExternalKeyConfigParams(
            string keyName,
            string tenantId,
            string vaultUri,
            string? clientId,
            string type = "azure")
        {
            this.ClientId = clientId;
            this.KeyName = keyName ?? throw new global::System.ArgumentNullException(nameof(keyName));
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.Type = type;
            this.VaultUri = vaultUri ?? throw new global::System.ArgumentNullException(nameof(vaultUri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAzureExternalKeyConfigParams" /> class.
        /// </summary>
        public BetaAzureExternalKeyConfigParams()
        {
        }

    }
}