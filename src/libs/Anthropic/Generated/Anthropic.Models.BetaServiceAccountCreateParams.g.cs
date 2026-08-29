
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaServiceAccountCreateParams
    {
        /// <summary>
        /// Optional free-text description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Slug identifier (lowercase, digits, hyphens). Unique within the organization; a duplicate name returns 409.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Org-level role. Defaults to `developer`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaServiceAccountCreateParamsOrganizationRoleJsonConverter))]
        public global::Anthropic.BetaServiceAccountCreateParamsOrganizationRole? OrganizationRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServiceAccountCreateParams" /> class.
        /// </summary>
        /// <param name="name">
        /// Slug identifier (lowercase, digits, hyphens). Unique within the organization; a duplicate name returns 409.
        /// </param>
        /// <param name="description">
        /// Optional free-text description.
        /// </param>
        /// <param name="organizationRole">
        /// Org-level role. Defaults to `developer`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaServiceAccountCreateParams(
            string name,
            string? description,
            global::Anthropic.BetaServiceAccountCreateParamsOrganizationRole? organizationRole)
        {
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrganizationRole = organizationRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServiceAccountCreateParams" /> class.
        /// </summary>
        public BetaServiceAccountCreateParams()
        {
        }

    }
}