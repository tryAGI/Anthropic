
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeRbacGroupManagedSettingsDeleted
    {
        /// <summary>
        /// The RBAC Group's ID, prefixed `rbac_group_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RbacGroupId { get; set; }

        /// <summary>
        /// Always `claude_code_rbac_group_managed_settings_deleted`.<br/>
        /// Default Value: claude_code_rbac_group_managed_settings_deleted
        /// </summary>
        /// <default>"claude_code_rbac_group_managed_settings_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "claude_code_rbac_group_managed_settings_deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupManagedSettingsDeleted" /> class.
        /// </summary>
        /// <param name="rbacGroupId">
        /// The RBAC Group's ID, prefixed `rbac_group_`.
        /// </param>
        /// <param name="type">
        /// Always `claude_code_rbac_group_managed_settings_deleted`.<br/>
        /// Default Value: claude_code_rbac_group_managed_settings_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeRbacGroupManagedSettingsDeleted(
            string rbacGroupId,
            string type = "claude_code_rbac_group_managed_settings_deleted")
        {
            this.RbacGroupId = rbacGroupId ?? throw new global::System.ArgumentNullException(nameof(rbacGroupId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupManagedSettingsDeleted" /> class.
        /// </summary>
        public BetaClaudeCodeRbacGroupManagedSettingsDeleted()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaClaudeCodeRbacGroupManagedSettingsDeleted"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaClaudeCodeRbacGroupManagedSettingsDeleted FromRbacGroupId(string rbacGroupId)
        {
            return new BetaClaudeCodeRbacGroupManagedSettingsDeleted
            {
                RbacGroupId = rbacGroupId,
            };
        }

    }
}