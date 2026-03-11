
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaContextManagementResponse
    {
        /// <summary>
        /// The original token count before context management was applied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OriginalInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContextManagementResponse" /> class.
        /// </summary>
        /// <param name="originalInputTokens">
        /// The original token count before context management was applied
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaContextManagementResponse(
            int originalInputTokens)
        {
            this.OriginalInputTokens = originalInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContextManagementResponse" /> class.
        /// </summary>
        public BetaContextManagementResponse()
        {
        }
    }
}