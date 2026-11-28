
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeRbacGroupManagedSettingsSummary
    {
        /// <summary>
        /// When the settings document this group uses was first stored, in RFC 3339 format. This can be earlier than when the group got its settings, and it changes if the group gets a different document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The RBAC Group's ID, prefixed `rbac_group_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RbacGroupId { get; set; }

        /// <summary>
        /// Whether the group is still one of the organization's RBAC Groups. Its `type` is `active` if it is, `deleted` if it is not, and `unknown` if that cannot be checked right now. A deleted group's settings stay in `rbac_group_order` but match no member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaClaudeCodeRbacGroupStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaClaudeCodeRbacGroupStatus RbacGroupStatus { get; set; }

        /// <summary>
        /// Always `claude_code_rbac_group_managed_settings_summary`.<br/>
        /// Default Value: claude_code_rbac_group_managed_settings_summary
        /// </summary>
        /// <default>"claude_code_rbac_group_managed_settings_summary"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "claude_code_rbac_group_managed_settings_summary";

        /// <summary>
        /// When this group's settings or its position in the order last changed, in RFC 3339 format. Its position changes whenever the number of groups ahead of it changes.
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
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupManagedSettingsSummary" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// When the settings document this group uses was first stored, in RFC 3339 format. This can be earlier than when the group got its settings, and it changes if the group gets a different document.
        /// </param>
        /// <param name="rbacGroupId">
        /// The RBAC Group's ID, prefixed `rbac_group_`.
        /// </param>
        /// <param name="rbacGroupStatus">
        /// Whether the group is still one of the organization's RBAC Groups. Its `type` is `active` if it is, `deleted` if it is not, and `unknown` if that cannot be checked right now. A deleted group's settings stay in `rbac_group_order` but match no member.
        /// </param>
        /// <param name="updatedAt">
        /// When this group's settings or its position in the order last changed, in RFC 3339 format. Its position changes whenever the number of groups ahead of it changes.
        /// </param>
        /// <param name="type">
        /// Always `claude_code_rbac_group_managed_settings_summary`.<br/>
        /// Default Value: claude_code_rbac_group_managed_settings_summary
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeRbacGroupManagedSettingsSummary(
            global::System.DateTime createdAt,
            string rbacGroupId,
            global::Anthropic.BetaClaudeCodeRbacGroupStatus rbacGroupStatus,
            global::System.DateTime updatedAt,
            string type = "claude_code_rbac_group_managed_settings_summary")
        {
            this.CreatedAt = createdAt;
            this.RbacGroupId = rbacGroupId ?? throw new global::System.ArgumentNullException(nameof(rbacGroupId));
            this.RbacGroupStatus = rbacGroupStatus;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupManagedSettingsSummary" /> class.
        /// </summary>
        public BetaClaudeCodeRbacGroupManagedSettingsSummary()
        {
        }

    }
}