
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPluginTargetOrganizationMember
    {
        /// <summary>
        /// One member of the organization.<br/>
        /// Default Value: organization_member
        /// </summary>
        /// <default>"organization_member"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "organization_member";

        /// <summary>
        /// The member's User ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginTargetOrganizationMember" /> class.
        /// </summary>
        /// <param name="userId">
        /// The member's User ID.
        /// </param>
        /// <param name="type">
        /// One member of the organization.<br/>
        /// Default Value: organization_member
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginTargetOrganizationMember(
            string userId,
            string type = "organization_member")
        {
            this.Type = type;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginTargetOrganizationMember" /> class.
        /// </summary>
        public BetaPluginTargetOrganizationMember()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaPluginTargetOrganizationMember"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaPluginTargetOrganizationMember FromUserId(string userId)
        {
            return new BetaPluginTargetOrganizationMember
            {
                UserId = userId,
            };
        }

    }
}