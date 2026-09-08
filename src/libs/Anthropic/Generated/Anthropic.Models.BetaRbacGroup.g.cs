
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaRbacGroup
    {
        /// <summary>
        /// RFC 3339 timestamp of when the RBAC Group was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// ID of the RBAC Group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the RBAC Group. Not uniqueness-enforced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// RBAC Role IDs attached to this RBAC Group. Role attachment is managed in the admin settings and is read-only on this API. `null` means role data was temporarily unavailable — retry to distinguish from an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<string>? Roles { get; set; }

        /// <summary>
        /// How the RBAC Group was created: `"direct"` for groups created directly (for example, in the organization's admin settings), `"scim"` for groups provisioned by the identity provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaRbacGroupSourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaRbacGroupSourceType SourceType { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For RBAC Groups, this is always `"rbac_group"`.<br/>
        /// Default Value: rbac_group
        /// </summary>
        /// <default>"rbac_group"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "rbac_group";

        /// <summary>
        /// RFC 3339 timestamp of when the RBAC Group was last updated.
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
        /// Initializes a new instance of the <see cref="BetaRbacGroup" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// RFC 3339 timestamp of when the RBAC Group was created.
        /// </param>
        /// <param name="id">
        /// ID of the RBAC Group.
        /// </param>
        /// <param name="name">
        /// Name of the RBAC Group. Not uniqueness-enforced.
        /// </param>
        /// <param name="sourceType">
        /// How the RBAC Group was created: `"direct"` for groups created directly (for example, in the organization's admin settings), `"scim"` for groups provisioned by the identity provider.
        /// </param>
        /// <param name="updatedAt">
        /// RFC 3339 timestamp of when the RBAC Group was last updated.
        /// </param>
        /// <param name="roles">
        /// RBAC Role IDs attached to this RBAC Group. Role attachment is managed in the admin settings and is read-only on this API. `null` means role data was temporarily unavailable — retry to distinguish from an empty list.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For RBAC Groups, this is always `"rbac_group"`.<br/>
        /// Default Value: rbac_group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRbacGroup(
            global::System.DateTime createdAt,
            string id,
            string name,
            global::Anthropic.BetaRbacGroupSourceType sourceType,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<string>? roles,
            string type = "rbac_group")
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Roles = roles;
            this.SourceType = sourceType;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRbacGroup" /> class.
        /// </summary>
        public BetaRbacGroup()
        {
        }

    }
}