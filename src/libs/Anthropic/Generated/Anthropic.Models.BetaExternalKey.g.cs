
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// CMEK external key config belonging to the caller's organization.<br/>
    /// Configs are organization-scoped. Workspaces attach to a config; once any<br/>
    /// workspace references it, the provider fields become effectively immutable<br/>
    /// (existing encrypted data needs the config for decrypt).
    /// </summary>
    public sealed partial class BetaExternalKey
    {
        /// <summary>
        /// Whether any workspace uses this config to encrypt its data — counting live and archived workspaces (an archived workspace's data remains encrypted under the config), excluding deleted ones. Only an attached config is used by the encryption path; an `unattached` config is inert and can be deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AttachmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Attachment Attachment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Human-friendly display name. Null if none was set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Data residency geo. Selects which regional validator handles this key's encrypt/decrypt roundtrips.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Geo { get; set; }

        /// <summary>
        /// Identifier of the external key config. A tagged ID prefixed `ekey_`, or — for organizations on the Claude Platform on AWS — the AWS KMS key ARN.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// KMS provider identity and auth coordinates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ProviderConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ProviderConfig ProviderConfig { get; set; }

        /// <summary>
        /// Default Value: external_key
        /// </summary>
        /// <default>"external_key"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "external_key";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalKey" /> class.
        /// </summary>
        /// <param name="attachment">
        /// Whether any workspace uses this config to encrypt its data — counting live and archived workspaces (an archived workspace's data remains encrypted under the config), excluding deleted ones. Only an attached config is used by the encryption path; an `unattached` config is inert and can be deleted.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="geo">
        /// Data residency geo. Selects which regional validator handles this key's encrypt/decrypt roundtrips.
        /// </param>
        /// <param name="id">
        /// Identifier of the external key config. A tagged ID prefixed `ekey_`, or — for organizations on the Claude Platform on AWS — the AWS KMS key ARN.
        /// </param>
        /// <param name="providerConfig">
        /// KMS provider identity and auth coordinates.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="displayName">
        /// Human-friendly display name. Null if none was set.
        /// </param>
        /// <param name="type">
        /// Default Value: external_key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalKey(
            global::Anthropic.Attachment attachment,
            global::System.DateTime createdAt,
            string geo,
            string id,
            global::Anthropic.ProviderConfig providerConfig,
            global::System.DateTime updatedAt,
            string? displayName,
            string type = "external_key")
        {
            this.Attachment = attachment;
            this.CreatedAt = createdAt;
            this.DisplayName = displayName;
            this.Geo = geo ?? throw new global::System.ArgumentNullException(nameof(geo));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProviderConfig = providerConfig;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalKey" /> class.
        /// </summary>
        public BetaExternalKey()
        {
        }

    }
}