
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Partial update. `name` is immutable.
    /// </summary>
    public sealed partial class BetaServiceAccountUpdateParams
    {
        /// <summary>
        /// Replaces the description. Omit to leave unchanged; send `null` to clear (the field is stored as an empty string).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Replaces the org-level role. Omit or send `null` to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_role")]
        public global::Anthropic.BetaServiceAccountUpdateParamsOrganizationRole2? OrganizationRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServiceAccountUpdateParams" /> class.
        /// </summary>
        /// <param name="description">
        /// Replaces the description. Omit to leave unchanged; send `null` to clear (the field is stored as an empty string).
        /// </param>
        /// <param name="organizationRole">
        /// Replaces the org-level role. Omit or send `null` to leave unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaServiceAccountUpdateParams(
            string? description,
            global::Anthropic.BetaServiceAccountUpdateParamsOrganizationRole2? organizationRole)
        {
            this.Description = description;
            this.OrganizationRole = organizationRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServiceAccountUpdateParams" /> class.
        /// </summary>
        public BetaServiceAccountUpdateParams()
        {
        }

    }
}