
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaCreateInviteParams
    {
        /// <summary>
        /// Email of the User.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// RBAC group IDs to assign to the User when the Invite is accepted. A non-empty array is accepted only for a Claude Enterprise organization with RBAC groups, and requires the key to carry the `write:rbac_groups` scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_ids")]
        public global::System.Collections.Generic.IList<string>? RbacGroupIds { get; set; }

        /// <summary>
        /// Role for the invited User.<br/>
        /// The accepted values depend on the organization type. Console and API organizations accept `user`, `developer`, `billing`, and `claude_code_user`; `admin` cannot be assigned through the API. Claude Enterprise organizations accept `user` and `managed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaCreateInviteParamsRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCreateInviteParamsRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateInviteParams" /> class.
        /// </summary>
        /// <param name="email">
        /// Email of the User.
        /// </param>
        /// <param name="role">
        /// Role for the invited User.<br/>
        /// The accepted values depend on the organization type. Console and API organizations accept `user`, `developer`, `billing`, and `claude_code_user`; `admin` cannot be assigned through the API. Claude Enterprise organizations accept `user` and `managed`.
        /// </param>
        /// <param name="rbacGroupIds">
        /// RBAC group IDs to assign to the User when the Invite is accepted. A non-empty array is accepted only for a Claude Enterprise organization with RBAC groups, and requires the key to carry the `write:rbac_groups` scope.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateInviteParams(
            string email,
            global::Anthropic.BetaCreateInviteParamsRole role,
            global::System.Collections.Generic.IList<string>? rbacGroupIds)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.RbacGroupIds = rbacGroupIds;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateInviteParams" /> class.
        /// </summary>
        public BetaCreateInviteParams()
        {
        }

    }
}