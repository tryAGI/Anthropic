
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration override for the write tool.
    /// </summary>
    public sealed partial class BetaManagedAgentsWriteToolConfigParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Must be "write".
        /// </summary>
        /// <default>"write"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = "write";

        /// <summary>
        /// Whether this tool is enabled and available to Claude. Overrides the default_config setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Permission policy for this tool. Controls whether tool calls are auto-approved or require confirmation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_policy")]
        public global::Anthropic.BetaManagedAgentsPermissionPolicy? PermissionPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWriteToolConfigParams" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="enabled">
        /// Whether this tool is enabled and available to Claude. Overrides the default_config setting.
        /// </param>
        /// <param name="permissionPolicy">
        /// Permission policy for this tool. Controls whether tool calls are auto-approved or require confirmation.
        /// </param>
        /// <param name="name">
        /// Must be "write".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWriteToolConfigParams(
            string? type,
            bool? enabled,
            global::Anthropic.BetaManagedAgentsPermissionPolicy? permissionPolicy,
            string name = "write")
        {
            this.Type = type;
            this.Name = name;
            this.Enabled = enabled;
            this.PermissionPolicy = permissionPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWriteToolConfigParams" /> class.
        /// </summary>
        public BetaManagedAgentsWriteToolConfigParams()
        {
        }

    }
}