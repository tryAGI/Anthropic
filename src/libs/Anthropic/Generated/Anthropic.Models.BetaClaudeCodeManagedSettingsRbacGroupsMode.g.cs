
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeManagedSettingsRbacGroupsMode
    {
        /// <summary>
        /// Always `rbac_groups`.<br/>
        /// Default Value: rbac_groups
        /// </summary>
        /// <default>"rbac_groups"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "rbac_groups";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeManagedSettingsRbacGroupsMode" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `rbac_groups`.<br/>
        /// Default Value: rbac_groups
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeManagedSettingsRbacGroupsMode(
            string type = "rbac_groups")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeManagedSettingsRbacGroupsMode" /> class.
        /// </summary>
        public BetaClaudeCodeManagedSettingsRbacGroupsMode()
        {
        }

    }
}