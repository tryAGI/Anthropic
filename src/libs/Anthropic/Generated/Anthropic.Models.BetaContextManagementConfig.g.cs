
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaContextManagementConfig
    {
        /// <summary>
        /// List of context management edits to apply
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edits")]
        public global::System.Collections.Generic.IList<global::Anthropic.EditsItem>? Edits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContextManagementConfig" /> class.
        /// </summary>
        /// <param name="edits">
        /// List of context management edits to apply
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaContextManagementConfig(
            global::System.Collections.Generic.IList<global::Anthropic.EditsItem>? edits)
        {
            this.Edits = edits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContextManagementConfig" /> class.
        /// </summary>
        public BetaContextManagementConfig()
        {
        }
    }
}