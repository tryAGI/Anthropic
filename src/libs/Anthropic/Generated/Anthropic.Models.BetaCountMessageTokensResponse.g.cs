
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCountMessageTokensResponse
    {
        /// <summary>
        /// The total number of tokens across the provided list of messages, system prompt, and tools.<br/>
        /// Example: 2095
        /// </summary>
        /// <example>2095</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCountMessageTokensResponse" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The total number of tokens across the provided list of messages, system prompt, and tools.<br/>
        /// Example: 2095
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaCountMessageTokensResponse(
            int inputTokens)
        {
            this.InputTokens = inputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCountMessageTokensResponse" /> class.
        /// </summary>
        public BetaCountMessageTokensResponse()
        {
        }
    }
}