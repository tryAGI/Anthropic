
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeRbacGroupStatusDeleted
    {
        /// <summary>
        /// Always `deleted`.<br/>
        /// Default Value: deleted
        /// </summary>
        /// <default>"deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupStatusDeleted" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `deleted`.<br/>
        /// Default Value: deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeRbacGroupStatusDeleted(
            string type = "deleted")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupStatusDeleted" /> class.
        /// </summary>
        public BetaClaudeCodeRbacGroupStatusDeleted()
        {
        }

    }
}