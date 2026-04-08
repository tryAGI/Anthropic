
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration override for a specific MCP tool.
    /// </summary>
    public sealed partial class BetaManagedAgentsMCPToolConfigParams
    {
        /// <summary>
        /// Name of the MCP tool to configure. 1-128 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether this tool is enabled. Overrides the `default_config` setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Permission policy for this tool. Overrides the `default_config` setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPermissionPolicyJsonConverter))]
        public global::Anthropic.BetaManagedAgentsPermissionPolicy? PermissionPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMCPToolConfigParams" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the MCP tool to configure. 1-128 characters.
        /// </param>
        /// <param name="enabled">
        /// Whether this tool is enabled. Overrides the `default_config` setting.
        /// </param>
        /// <param name="permissionPolicy">
        /// Permission policy for this tool. Overrides the `default_config` setting.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMCPToolConfigParams(
            string name,
            bool? enabled,
            global::Anthropic.BetaManagedAgentsPermissionPolicy? permissionPolicy)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Enabled = enabled;
            this.PermissionPolicy = permissionPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMCPToolConfigParams" /> class.
        /// </summary>
        public BetaManagedAgentsMCPToolConfigParams()
        {
        }
    }
}