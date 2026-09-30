
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One share the owner of a member-owned Plugin has given. Shares are<br/>
    /// read-only in this API and have no ID of their own; who gave a share is<br/>
    /// recorded on the Compliance API activity feed, not here.
    /// </summary>
    public sealed partial class BetaPluginShare
    {
        /// <summary>
        /// When the share was given; a share whose role is later changed in claude.ai is re-granted and carries the time of that change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime GrantedAt { get; set; }

        /// <summary>
        /// The Plugin's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PluginId { get; set; }

        /// <summary>
        /// Who the Plugin is shared with: `organization` (every member), `rbac_group` (one RBAC Group), or `organization_member` (one member).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Target3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Target3 Target { get; set; }

        /// <summary>
        /// Always `plugin_share`.<br/>
        /// Default Value: plugin_share
        /// </summary>
        /// <default>"plugin_share"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "plugin_share";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginShare" /> class.
        /// </summary>
        /// <param name="grantedAt">
        /// When the share was given; a share whose role is later changed in claude.ai is re-granted and carries the time of that change.
        /// </param>
        /// <param name="pluginId">
        /// The Plugin's ID.
        /// </param>
        /// <param name="target">
        /// Who the Plugin is shared with: `organization` (every member), `rbac_group` (one RBAC Group), or `organization_member` (one member).
        /// </param>
        /// <param name="type">
        /// Always `plugin_share`.<br/>
        /// Default Value: plugin_share
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginShare(
            global::System.DateTime grantedAt,
            string pluginId,
            global::Anthropic.Target3 target,
            string type = "plugin_share")
        {
            this.GrantedAt = grantedAt;
            this.PluginId = pluginId ?? throw new global::System.ArgumentNullException(nameof(pluginId));
            this.Target = target;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginShare" /> class.
        /// </summary>
        public BetaPluginShare()
        {
        }

    }
}