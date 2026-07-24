
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaOutputTokensDetails
    {
        /// <summary>
        /// Number of output tokens the model generated as internal reasoning, including<br/>
        /// the thinking-block delimiter tokens.<br/>
        /// Reflects the raw reasoning the model produced, not the (possibly shorter)<br/>
        /// summarized thinking text returned in the response body. Computed by<br/>
        /// re-tokenizing the raw reasoning text, so it may differ from the model's exact<br/>
        /// generation count by a small number of tokens. Always ≤ `output_tokens`;<br/>
        /// `output_tokens - thinking_tokens` approximates the non-reasoning output.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ThinkingTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOutputTokensDetails" /> class.
        /// </summary>
        /// <param name="thinkingTokens">
        /// Number of output tokens the model generated as internal reasoning, including<br/>
        /// the thinking-block delimiter tokens.<br/>
        /// Reflects the raw reasoning the model produced, not the (possibly shorter)<br/>
        /// summarized thinking text returned in the response body. Computed by<br/>
        /// re-tokenizing the raw reasoning text, so it may differ from the model's exact<br/>
        /// generation count by a small number of tokens. Always ≤ `output_tokens`;<br/>
        /// `output_tokens - thinking_tokens` approximates the non-reasoning output.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOutputTokensDetails(
            int thinkingTokens)
        {
            this.ThinkingTokens = thinkingTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOutputTokensDetails" /> class.
        /// </summary>
        public BetaOutputTokensDetails()
        {
        }

    }
}