
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeTagUpdateBundleRequestBody
    {
        /// <summary>
        /// Instructions for Claude, up to 10,000 bytes (UTF-8), added to the instructions of every session that can use the Bundle. Null or an empty string clears them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagUpdateBundleRequestBody" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Instructions for Claude, up to 10,000 bytes (UTF-8), added to the instructions of every session that can use the Bundle. Null or an empty string clears them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagUpdateBundleRequestBody(
            string? instructions)
        {
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagUpdateBundleRequestBody" /> class.
        /// </summary>
        public BetaClaudeTagUpdateBundleRequestBody()
        {
        }

    }
}