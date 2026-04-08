
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A credential stored in a vault. Sensitive fields are never returned in responses.<br/>
    /// Example: {"type":"vault_credential","id":"vcrd_011CZkZEMt8gZan2iYOQfSkw","vault_id":"vlt_011CZkZDLs7fYzm1hXNPeRjv","display_name":"Example credential","metadata":{"environment":"production"},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z","archived_at":null,"auth":{"type":"static_bearer","mcp_server_url":"https://example-server.modelcontextprotocol.io/sse"}}
    /// </summary>
    public sealed partial class BetaManagedAgentsCredential
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsCredentialType Type { get; set; }

        /// <summary>
        /// Unique identifier for the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Identifier of the vault this credential belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultId { get; set; }

        /// <summary>
        /// Human-readable name for the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Arbitrary key-value metadata attached to the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A timestamp in RFC 3339 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A timestamp in RFC 3339 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// When the credential was archived. Null if not archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Authentication configuration for this credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialAuthJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsCredentialAuth Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCredential" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the credential.
        /// </param>
        /// <param name="vaultId">
        /// Identifier of the vault this credential belongs to.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata attached to the credential.
        /// </param>
        /// <param name="createdAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for this credential.
        /// </param>
        /// <param name="type"></param>
        /// <param name="displayName">
        /// Human-readable name for the credential.
        /// </param>
        /// <param name="archivedAt">
        /// When the credential was archived. Null if not archived.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCredential(
            string id,
            string vaultId,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Anthropic.BetaManagedAgentsCredentialAuth auth,
            global::Anthropic.BetaManagedAgentsCredentialType type,
            string? displayName,
            global::System.DateTime? archivedAt)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.VaultId = vaultId ?? throw new global::System.ArgumentNullException(nameof(vaultId));
            this.DisplayName = displayName;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ArchivedAt = archivedAt;
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCredential" /> class.
        /// </summary>
        public BetaManagedAgentsCredential()
        {
        }
    }
}