
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeRbacGroupStatusUnknown
    {
        /// <summary>
        /// Always `unknown`.<br/>
        /// Default Value: unknown
        /// </summary>
        /// <default>"unknown"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "unknown";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupStatusUnknown" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `unknown`.<br/>
        /// Default Value: unknown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeRbacGroupStatusUnknown(
            string type = "unknown")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupStatusUnknown" /> class.
        /// </summary>
        public BetaClaudeCodeRbacGroupStatusUnknown()
        {
        }

    }
}