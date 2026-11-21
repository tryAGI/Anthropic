
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeRbacGroupStatusActive
    {
        /// <summary>
        /// Always `active`.<br/>
        /// Default Value: active
        /// </summary>
        /// <default>"active"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "active";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupStatusActive" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `active`.<br/>
        /// Default Value: active
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeRbacGroupStatusActive(
            string type = "active")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupStatusActive" /> class.
        /// </summary>
        public BetaClaudeCodeRbacGroupStatusActive()
        {
        }

    }
}