
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default configuration for all tools from an MCP server.
    /// </summary>
    public sealed partial class BetaManagedAgentsMCPToolsetDefaultConfigParams
    {
        /// <summary>
        /// Whether tools are enabled by default. Defaults to true if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Default permission policy for tools from this server.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMCPToolsetDefaultConfigParams" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether tools are enabled by default. Defaults to true if not specified.
        /// </param>
        /// <param name="permissionPolicy">
        /// Default permission policy for tools from this server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMCPToolsetDefaultConfigParams(
            bool? enabled,
            global::Anthropic.BetaManagedAgentsPermissionPolicy? permissionPolicy)
        {
            this.Enabled = enabled;
            this.PermissionPolicy = permissionPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMCPToolsetDefaultConfigParams" /> class.
        /// </summary>
        public BetaManagedAgentsMCPToolsetDefaultConfigParams()
        {
        }
    }
}