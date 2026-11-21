
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeManagedSettingsConfigurationUpdateParams
    {
        /// <summary>
        /// The new mode, as an object such as `{"type": "rbac_groups"}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaClaudeCodeManagedSettingsModeParamsJsonConverter))]
        public global::Anthropic.BetaClaudeCodeManagedSettingsModeParams? Mode { get; set; }

        /// <summary>
        /// Every RBAC Group that has settings, each listed once, in the new order, highest precedence first. Requires `rbac_group_order_version`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_order")]
        public global::System.Collections.Generic.IList<string>? RbacGroupOrder { get; set; }

        /// <summary>
        /// The `rbac_group_order_version` from the read this change is based on. Requires `rbac_group_order`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_order_version")]
        public string? RbacGroupOrderVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeManagedSettingsConfigurationUpdateParams" /> class.
        /// </summary>
        /// <param name="mode">
        /// The new mode, as an object such as `{"type": "rbac_groups"}`.
        /// </param>
        /// <param name="rbacGroupOrder">
        /// Every RBAC Group that has settings, each listed once, in the new order, highest precedence first. Requires `rbac_group_order_version`.
        /// </param>
        /// <param name="rbacGroupOrderVersion">
        /// The `rbac_group_order_version` from the read this change is based on. Requires `rbac_group_order`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeManagedSettingsConfigurationUpdateParams(
            global::Anthropic.BetaClaudeCodeManagedSettingsModeParams? mode,
            global::System.Collections.Generic.IList<string>? rbacGroupOrder,
            string? rbacGroupOrderVersion)
        {
            this.Mode = mode;
            this.RbacGroupOrder = rbacGroupOrder;
            this.RbacGroupOrderVersion = rbacGroupOrderVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeManagedSettingsConfigurationUpdateParams" /> class.
        /// </summary>
        public BetaClaudeCodeManagedSettingsConfigurationUpdateParams()
        {
        }

    }
}