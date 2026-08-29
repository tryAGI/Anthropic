
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaInviteSchema
    {
        /// <summary>
        /// RFC 3339 datetime string indicating when the Invite was accepted, or null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted_at")]
        public global::System.DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// Email of the User being invited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// RFC 3339 datetime string indicating when the Invite expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// ID of the Invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// RFC 3339 datetime string indicating when the Invite was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime InvitedAt { get; set; }

        /// <summary>
        /// RBAC group IDs recorded on the Invite (Claude Enterprise organizations), to be assigned to the User when the Invite is accepted. `[]` when none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RbacGroupIds { get; set; }

        /// <summary>
        /// Organization role of the User.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaOrganizationRoleSchemaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaOrganizationRoleSchema Role { get; set; }

        /// <summary>
        /// Status of the Invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaInviteStatusSchemaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaInviteStatusSchema Status { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For Invites, this is always `"invite"`.<br/>
        /// Default Value: invite
        /// </summary>
        /// <default>"invite"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "invite";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInviteSchema" /> class.
        /// </summary>
        /// <param name="email">
        /// Email of the User being invited.
        /// </param>
        /// <param name="expiresAt">
        /// RFC 3339 datetime string indicating when the Invite expires.
        /// </param>
        /// <param name="id">
        /// ID of the Invite.
        /// </param>
        /// <param name="invitedAt">
        /// RFC 3339 datetime string indicating when the Invite was created.
        /// </param>
        /// <param name="rbacGroupIds">
        /// RBAC group IDs recorded on the Invite (Claude Enterprise organizations), to be assigned to the User when the Invite is accepted. `[]` when none.
        /// </param>
        /// <param name="role">
        /// Organization role of the User.
        /// </param>
        /// <param name="status">
        /// Status of the Invite.
        /// </param>
        /// <param name="acceptedAt">
        /// RFC 3339 datetime string indicating when the Invite was accepted, or null.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Invites, this is always `"invite"`.<br/>
        /// Default Value: invite
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInviteSchema(
            string email,
            global::System.DateTime expiresAt,
            string id,
            global::System.DateTime invitedAt,
            global::System.Collections.Generic.IList<string> rbacGroupIds,
            global::Anthropic.BetaOrganizationRoleSchema role,
            global::Anthropic.BetaInviteStatusSchema status,
            global::System.DateTime? acceptedAt,
            string type = "invite")
        {
            this.AcceptedAt = acceptedAt;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.ExpiresAt = expiresAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InvitedAt = invitedAt;
            this.RbacGroupIds = rbacGroupIds ?? throw new global::System.ArgumentNullException(nameof(rbacGroupIds));
            this.Role = role;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInviteSchema" /> class.
        /// </summary>
        public BetaInviteSchema()
        {
        }

    }
}