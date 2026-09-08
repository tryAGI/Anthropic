
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaOrganizationPermissionResource
    {
        /// <summary>
        /// UUID of the organization the permission applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Kind of resource the permission applies to.<br/>
        /// Default Value: organization
        /// </summary>
        /// <default>"organization"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "organization";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationPermissionResource" /> class.
        /// </summary>
        /// <param name="organizationId">
        /// UUID of the organization the permission applies to.
        /// </param>
        /// <param name="type">
        /// Kind of resource the permission applies to.<br/>
        /// Default Value: organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOrganizationPermissionResource(
            string organizationId,
            string type = "organization")
        {
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationPermissionResource" /> class.
        /// </summary>
        public BetaOrganizationPermissionResource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaOrganizationPermissionResource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaOrganizationPermissionResource FromOrganizationId(string organizationId)
        {
            return new BetaOrganizationPermissionResource
            {
                OrganizationId = organizationId,
            };
        }

    }
}