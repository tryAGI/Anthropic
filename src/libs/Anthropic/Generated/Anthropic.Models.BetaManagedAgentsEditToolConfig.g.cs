
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration for the edit tool.
    /// </summary>
    public sealed partial class BetaManagedAgentsEditToolConfig
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"edit"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "edit";

        /// <summary>
        ///
        /// </summary>
        /// <default>"edit"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = "edit";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Permission policy for tool execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPermissionPolicyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsPermissionPolicy PermissionPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEditToolConfig" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="permissionPolicy">
        /// Permission policy for tool execution.
        /// </param>
        /// <param name="type"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEditToolConfig(
            bool enabled,
            global::Anthropic.BetaManagedAgentsPermissionPolicy permissionPolicy,
            string type = "edit",
            string name = "edit")
        {
            this.Type = type;
            this.Name = name;
            this.Enabled = enabled;
            this.PermissionPolicy = permissionPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEditToolConfig" /> class.
        /// </summary>
        public BetaManagedAgentsEditToolConfig()
        {
        }

    }
}