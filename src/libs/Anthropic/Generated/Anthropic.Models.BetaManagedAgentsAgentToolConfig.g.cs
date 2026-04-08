
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration for a specific agent tool.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentToolConfig
    {
        /// <summary>
        /// Built-in agent tool identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsAgentToolName Name { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolConfig" /> class.
        /// </summary>
        /// <param name="name">
        /// Built-in agent tool identifier.
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="permissionPolicy">
        /// Permission policy for tool execution.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentToolConfig(
            global::Anthropic.BetaManagedAgentsAgentToolName name,
            bool enabled,
            global::Anthropic.BetaManagedAgentsPermissionPolicy permissionPolicy)
        {
            this.Name = name;
            this.Enabled = enabled;
            this.PermissionPolicy = permissionPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolConfig" /> class.
        /// </summary>
        public BetaManagedAgentsAgentToolConfig()
        {
        }
    }
}