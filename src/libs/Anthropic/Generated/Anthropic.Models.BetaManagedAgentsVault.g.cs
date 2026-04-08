
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A vault that stores credentials for use by agents during sessions.<br/>
    /// Example: {"type":"vault","id":"vlt_011CZkZDLs7fYzm1hXNPeRjv","display_name":"Example vault","metadata":{"environment":"production"},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z","archived_at":null}
    /// </summary>
    public sealed partial class BetaManagedAgentsVault
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsVaultTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsVaultType Type { get; set; }

        /// <summary>
        /// Unique identifier for the vault.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable name for the vault.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Arbitrary key-value metadata attached to the vault.
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
        /// When the vault was archived. Null if not archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsVault" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the vault.
        /// </param>
        /// <param name="displayName">
        /// Human-readable name for the vault.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata attached to the vault.
        /// </param>
        /// <param name="createdAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="type"></param>
        /// <param name="archivedAt">
        /// When the vault was archived. Null if not archived.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsVault(
            string id,
            string displayName,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Anthropic.BetaManagedAgentsVaultType type,
            global::System.DateTime? archivedAt)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsVault" /> class.
        /// </summary>
        public BetaManagedAgentsVault()
        {
        }
    }
}