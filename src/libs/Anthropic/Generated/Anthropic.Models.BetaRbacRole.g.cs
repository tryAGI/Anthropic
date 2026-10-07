
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaRbacRole
    {
        /// <summary>
        /// RFC 3339 datetime string indicating when the RBAC Role was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Name of the RBAC Role. For a role created by Anthropic, this name can differ from the label claude.ai shows, and Anthropic may change the name. To keep a lasting reference to a role, store its `id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// ID of the RBAC Role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Deprecated: use `display_name` instead. Name of the RBAC Role; always the same value as `display_name`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For RBAC Roles, this is always `"rbac_role"`.<br/>
        /// Default Value: rbac_role
        /// </summary>
        /// <default>"rbac_role"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "rbac_role";

        /// <summary>
        /// RFC 3339 datetime string indicating when the RBAC Role was last updated.
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
        /// Initializes a new instance of the <see cref="BetaRbacRole" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// RFC 3339 datetime string indicating when the RBAC Role was created.
        /// </param>
        /// <param name="displayName">
        /// Name of the RBAC Role. For a role created by Anthropic, this name can differ from the label claude.ai shows, and Anthropic may change the name. To keep a lasting reference to a role, store its `id`.
        /// </param>
        /// <param name="id">
        /// ID of the RBAC Role.
        /// </param>
        /// <param name="name">
        /// Deprecated: use `display_name` instead. Name of the RBAC Role; always the same value as `display_name`.
        /// </param>
        /// <param name="updatedAt">
        /// RFC 3339 datetime string indicating when the RBAC Role was last updated.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For RBAC Roles, this is always `"rbac_role"`.<br/>
        /// Default Value: rbac_role
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRbacRole(
            global::System.DateTime createdAt,
            string displayName,
            string id,
            string name,
            global::System.DateTime updatedAt,
            string type = "rbac_role")
        {
            this.CreatedAt = createdAt;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRbacRole" /> class.
        /// </summary>
        public BetaRbacRole()
        {
        }

    }
}