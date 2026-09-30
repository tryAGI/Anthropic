
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Confirmation that one target's installation setting was removed, naming<br/>
    /// the Plugin and the target in place of an ID.
    /// </summary>
    public sealed partial class BetaPluginInstallationSettingDeleted
    {
        /// <summary>
        /// The Plugin's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PluginId { get; set; }

        /// <summary>
        /// Whose setting was removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Target2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Target2 Target { get; set; }

        /// <summary>
        /// Always `plugin_installation_setting_deleted`.<br/>
        /// Default Value: plugin_installation_setting_deleted
        /// </summary>
        /// <default>"plugin_installation_setting_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "plugin_installation_setting_deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginInstallationSettingDeleted" /> class.
        /// </summary>
        /// <param name="pluginId">
        /// The Plugin's ID.
        /// </param>
        /// <param name="target">
        /// Whose setting was removed.
        /// </param>
        /// <param name="type">
        /// Always `plugin_installation_setting_deleted`.<br/>
        /// Default Value: plugin_installation_setting_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginInstallationSettingDeleted(
            string pluginId,
            global::Anthropic.Target2 target,
            string type = "plugin_installation_setting_deleted")
        {
            this.PluginId = pluginId ?? throw new global::System.ArgumentNullException(nameof(pluginId));
            this.Target = target;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginInstallationSettingDeleted" /> class.
        /// </summary>
        public BetaPluginInstallationSettingDeleted()
        {
        }

    }
}