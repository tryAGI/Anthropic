
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration override for a specific tool within a toolset.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentToolConfigParams
    {
        /// <summary>
        /// Built-in agent tool identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsAgentToolName Name { get; set; }

        /// <summary>
        /// Whether this tool is enabled and available to Claude. Overrides the default_config setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Permission policy for this tool. Controls whether tool calls are auto-approved or require confirmation.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolConfigParams" /> class.
        /// </summary>
        /// <param name="name">
        /// Built-in agent tool identifier.
        /// </param>
        /// <param name="enabled">
        /// Whether this tool is enabled and available to Claude. Overrides the default_config setting.
        /// </param>
        /// <param name="permissionPolicy">
        /// Permission policy for this tool. Controls whether tool calls are auto-approved or require confirmation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentToolConfigParams(
            global::Anthropic.BetaManagedAgentsAgentToolName name,
            bool? enabled,
            global::Anthropic.BetaManagedAgentsPermissionPolicy? permissionPolicy)
        {
            this.Name = name;
            this.Enabled = enabled;
            this.PermissionPolicy = permissionPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolConfigParams" /> class.
        /// </summary>
        public BetaManagedAgentsAgentToolConfigParams()
        {
        }
    }
}