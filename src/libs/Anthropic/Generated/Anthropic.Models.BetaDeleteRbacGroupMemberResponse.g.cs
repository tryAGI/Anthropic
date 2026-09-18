
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaDeleteRbacGroupMemberResponse
    {
        /// <summary>
        /// Deprecated: use `rbac_group_id` instead. ID of the RBAC Group; always the same value as `rbac_group_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupId { get; set; }

        /// <summary>
        /// ID of the RBAC Group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RbacGroupId { get; set; }

        /// <summary>
        /// Deleted object type. For RBAC Group Members, this is always `"rbac_group_member_deleted"`.<br/>
        /// Default Value: rbac_group_member_deleted
        /// </summary>
        /// <default>"rbac_group_member_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "rbac_group_member_deleted";

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
        /// Initializes a new instance of the <see cref="BetaDeleteRbacGroupMemberResponse" /> class.
        /// </summary>
        /// <param name="groupId">
        /// Deprecated: use `rbac_group_id` instead. ID of the RBAC Group; always the same value as `rbac_group_id`.
        /// </param>
        /// <param name="rbacGroupId">
        /// ID of the RBAC Group.
        /// </param>
        /// <param name="userId">
        /// ID of the User.
        /// </param>
        /// <param name="type">
        /// Deleted object type. For RBAC Group Members, this is always `"rbac_group_member_deleted"`.<br/>
        /// Default Value: rbac_group_member_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeleteRbacGroupMemberResponse(
            string groupId,
            string rbacGroupId,
            string userId,
            string type = "rbac_group_member_deleted")
        {
            this.GroupId = groupId ?? throw new global::System.ArgumentNullException(nameof(groupId));
            this.RbacGroupId = rbacGroupId ?? throw new global::System.ArgumentNullException(nameof(rbacGroupId));
            this.Type = type;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteRbacGroupMemberResponse" /> class.
        /// </summary>
        public BetaDeleteRbacGroupMemberResponse()
        {
        }

    }
}