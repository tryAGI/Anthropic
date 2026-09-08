
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaRbacGroupMember
    {
        /// <summary>
        /// RFC 3339 timestamp of when the User was added to the RBAC Group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Email of the User.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// ID of the RBAC Group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupId { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For RBAC Group Members, this is always `"rbac_group_member"`.<br/>
        /// Default Value: rbac_group_member
        /// </summary>
        /// <default>"rbac_group_member"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "rbac_group_member";

        /// <summary>
        /// ID of the User.
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
        /// Initializes a new instance of the <see cref="BetaRbacGroupMember" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// RFC 3339 timestamp of when the User was added to the RBAC Group.
        /// </param>
        /// <param name="email">
        /// Email of the User.
        /// </param>
        /// <param name="groupId">
        /// ID of the RBAC Group.
        /// </param>
        /// <param name="userId">
        /// ID of the User.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For RBAC Group Members, this is always `"rbac_group_member"`.<br/>
        /// Default Value: rbac_group_member
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRbacGroupMember(
            global::System.DateTime createdAt,
            string email,
            string groupId,
            string userId,
            string type = "rbac_group_member")
        {
            this.CreatedAt = createdAt;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.GroupId = groupId ?? throw new global::System.ArgumentNullException(nameof(groupId));
            this.Type = type;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRbacGroupMember" /> class.
        /// </summary>
        public BetaRbacGroupMember()
        {
        }

    }
}