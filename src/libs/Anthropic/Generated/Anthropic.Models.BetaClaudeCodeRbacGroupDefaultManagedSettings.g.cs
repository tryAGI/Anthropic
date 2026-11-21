
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeRbacGroupDefaultManagedSettings
    {
        /// <summary>
        /// The default settings document, or `null` if none are set or the stored document is damaged and can no longer be read. To tell these apart, `updated_at` is `null` only when none are set. Replacing a damaged document fixes this.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public object? Settings { get; set; }

        /// <summary>
        /// Always `claude_code_rbac_group_default_managed_settings`.<br/>
        /// Default Value: claude_code_rbac_group_default_managed_settings
        /// </summary>
        /// <default>"claude_code_rbac_group_default_managed_settings"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "claude_code_rbac_group_default_managed_settings";

        /// <summary>
        /// When the default settings last changed, in RFC 3339 format, or `null` if none are set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupDefaultManagedSettings" /> class.
        /// </summary>
        /// <param name="settings">
        /// The default settings document, or `null` if none are set or the stored document is damaged and can no longer be read. To tell these apart, `updated_at` is `null` only when none are set. Replacing a damaged document fixes this.
        /// </param>
        /// <param name="updatedAt">
        /// When the default settings last changed, in RFC 3339 format, or `null` if none are set.
        /// </param>
        /// <param name="type">
        /// Always `claude_code_rbac_group_default_managed_settings`.<br/>
        /// Default Value: claude_code_rbac_group_default_managed_settings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeRbacGroupDefaultManagedSettings(
            object? settings,
            global::System.DateTime? updatedAt,
            string type = "claude_code_rbac_group_default_managed_settings")
        {
            this.Settings = settings;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupDefaultManagedSettings" /> class.
        /// </summary>
        public BetaClaudeCodeRbacGroupDefaultManagedSettings()
        {
        }

    }
}