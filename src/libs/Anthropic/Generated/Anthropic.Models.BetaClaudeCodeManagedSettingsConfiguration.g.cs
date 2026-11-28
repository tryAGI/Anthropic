
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeManagedSettingsConfiguration
    {
        /// <summary>
        /// How the organization serves managed settings. In `organization` mode every member receives the organization settings, which are set in claude.ai. In `rbac_groups` mode each member receives the settings of the first RBAC Group in `rbac_group_order` that they belong to. A member in none of them receives the default settings, or no settings if no default is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaClaudeCodeManagedSettingsModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaClaudeCodeManagedSettingsMode Mode { get; set; }

        /// <summary>
        /// When the mode last changed, in RFC 3339 format, or `null` if it never has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode_updated_at")]
        public global::System.DateTime? ModeUpdatedAt { get; set; }

        /// <summary>
        /// The ID of every RBAC Group with settings, deleted groups included, highest precedence first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RbacGroupOrder { get; set; }

        /// <summary>
        /// An opaque version of `rbac_group_order`, which changes whenever the order does. Send it back with a new order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_order_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RbacGroupOrderVersion { get; set; }

        /// <summary>
        /// Always `claude_code_managed_settings_configuration`.<br/>
        /// Default Value: claude_code_managed_settings_configuration
        /// </summary>
        /// <default>"claude_code_managed_settings_configuration"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "claude_code_managed_settings_configuration";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeManagedSettingsConfiguration" /> class.
        /// </summary>
        /// <param name="mode">
        /// How the organization serves managed settings. In `organization` mode every member receives the organization settings, which are set in claude.ai. In `rbac_groups` mode each member receives the settings of the first RBAC Group in `rbac_group_order` that they belong to. A member in none of them receives the default settings, or no settings if no default is set.
        /// </param>
        /// <param name="rbacGroupOrder">
        /// The ID of every RBAC Group with settings, deleted groups included, highest precedence first.
        /// </param>
        /// <param name="rbacGroupOrderVersion">
        /// An opaque version of `rbac_group_order`, which changes whenever the order does. Send it back with a new order.
        /// </param>
        /// <param name="modeUpdatedAt">
        /// When the mode last changed, in RFC 3339 format, or `null` if it never has.
        /// </param>
        /// <param name="type">
        /// Always `claude_code_managed_settings_configuration`.<br/>
        /// Default Value: claude_code_managed_settings_configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeManagedSettingsConfiguration(
            global::Anthropic.BetaClaudeCodeManagedSettingsMode mode,
            global::System.Collections.Generic.IList<string> rbacGroupOrder,
            string rbacGroupOrderVersion,
            global::System.DateTime? modeUpdatedAt,
            string type = "claude_code_managed_settings_configuration")
        {
            this.Mode = mode;
            this.ModeUpdatedAt = modeUpdatedAt;
            this.RbacGroupOrder = rbacGroupOrder ?? throw new global::System.ArgumentNullException(nameof(rbacGroupOrder));
            this.RbacGroupOrderVersion = rbacGroupOrderVersion ?? throw new global::System.ArgumentNullException(nameof(rbacGroupOrderVersion));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeManagedSettingsConfiguration" /> class.
        /// </summary>
        public BetaClaudeCodeManagedSettingsConfiguration()
        {
        }

    }
}