
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default configuration for all tools in a toolset.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentToolsetDefaultConfigParams
    {
        /// <summary>
        /// Whether tools are enabled and available to Claude by default. Defaults to true if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Default permission policy for tools. Controls whether tool calls are auto-approved or require confirmation.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolsetDefaultConfigParams" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether tools are enabled and available to Claude by default. Defaults to true if not specified.
        /// </param>
        /// <param name="permissionPolicy">
        /// Default permission policy for tools. Controls whether tool calls are auto-approved or require confirmation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentToolsetDefaultConfigParams(
            bool? enabled,
            global::Anthropic.BetaManagedAgentsPermissionPolicy? permissionPolicy)
        {
            this.Enabled = enabled;
            this.PermissionPolicy = permissionPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolsetDefaultConfigParams" /> class.
        /// </summary>
        public BetaManagedAgentsAgentToolsetDefaultConfigParams()
        {
        }
    }
}