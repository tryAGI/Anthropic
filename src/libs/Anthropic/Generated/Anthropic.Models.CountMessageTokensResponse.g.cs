
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CountMessageTokensResponse
    {
        /// <summary>
        /// The total number of tokens across the provided list of messages, system prompt, and tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountMessageTokensResponse" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The total number of tokens across the provided list of messages, system prompt, and tools.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountMessageTokensResponse(
            int inputTokens)
        {
            this.InputTokens = inputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountMessageTokensResponse" /> class.
        /// </summary>
        public CountMessageTokensResponse()
        {
        }
    }
}