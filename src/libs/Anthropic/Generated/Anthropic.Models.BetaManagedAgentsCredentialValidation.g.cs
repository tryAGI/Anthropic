
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Result of live-probing a credential against its configured MCP server.<br/>
    /// Example: {"type":"vault_credential_validation","credential_id":"vcrd_011CZkZEMt8gZan2iYOQfSkw","vault_id":"vlt_011CZkZDLs7fYzm1hXNPeRjv","status":"valid","validated_at":"2026-03-15T10:00:00Z","has_refresh_token":true,"mcp_probe":null,"refresh":null}
    /// </summary>
    public sealed partial class BetaManagedAgentsCredentialValidation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialValidationTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsCredentialValidationType Type { get; set; }

        /// <summary>
        /// Unique identifier of the credential that was validated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CredentialId { get; set; }

        /// <summary>
        /// Identifier of the vault containing the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultId { get; set; }

        /// <summary>
        /// Overall verdict of the validation probe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialValidationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsCredentialValidationStatus Status { get; set; }

        /// <summary>
        /// When the validation probe was performed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ValidatedAt { get; set; }

        /// <summary>
        /// Whether the credential has a refresh token configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_refresh_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasRefreshToken { get; set; }

        /// <summary>
        /// Details of the failing MCP probe step. Null when the probe succeeded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_probe")]
        public global::Anthropic.BetaManagedAgentsMcpProbe? McpProbe { get; set; }

        /// <summary>
        /// Details of the refresh-token exchange attempted on a 401. Null when no refresh was attempted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh")]
        public global::Anthropic.BetaManagedAgentsRefreshObject? Refresh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCredentialValidation" /> class.
        /// </summary>
        /// <param name="credentialId">
        /// Unique identifier of the credential that was validated.
        /// </param>
        /// <param name="vaultId">
        /// Identifier of the vault containing the credential.
        /// </param>
        /// <param name="status">
        /// Overall verdict of the validation probe.
        /// </param>
        /// <param name="validatedAt">
        /// When the validation probe was performed.
        /// </param>
        /// <param name="hasRefreshToken">
        /// Whether the credential has a refresh token configured.
        /// </param>
        /// <param name="type"></param>
        /// <param name="mcpProbe">
        /// Details of the failing MCP probe step. Null when the probe succeeded.
        /// </param>
        /// <param name="refresh">
        /// Details of the refresh-token exchange attempted on a 401. Null when no refresh was attempted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCredentialValidation(
            string credentialId,
            string vaultId,
            global::Anthropic.BetaManagedAgentsCredentialValidationStatus status,
            global::System.DateTime validatedAt,
            bool hasRefreshToken,
            global::Anthropic.BetaManagedAgentsCredentialValidationType type,
            global::Anthropic.BetaManagedAgentsMcpProbe? mcpProbe,
            global::Anthropic.BetaManagedAgentsRefreshObject? refresh)
        {
            this.Type = type;
            this.CredentialId = credentialId ?? throw new global::System.ArgumentNullException(nameof(credentialId));
            this.VaultId = vaultId ?? throw new global::System.ArgumentNullException(nameof(vaultId));
            this.Status = status;
            this.ValidatedAt = validatedAt;
            this.HasRefreshToken = hasRefreshToken;
            this.McpProbe = mcpProbe;
            this.Refresh = refresh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCredentialValidation" /> class.
        /// </summary>
        public BetaManagedAgentsCredentialValidation()
        {
        }
    }
}