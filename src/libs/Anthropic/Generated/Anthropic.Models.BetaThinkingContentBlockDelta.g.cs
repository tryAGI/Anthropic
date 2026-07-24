
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaThinkingContentBlockDelta
    {
        /// <summary>
        /// Per-frame increment of a coarse, running estimate of the tokens this thinking block has produced so far. Present whenever the `thinking-token-count-2026-05-13` beta is set; `null` unless `thinking.display` resolves to `"omitted"` and a count is due this frame. Sum the increments across `thinking_delta` frames on this block for a progress indicator. Each increment is a non-negative multiple of a fixed quantum and the cadence is rate-limited, so this is a deliberately lossy display hint, not a billable count; `usage.output_tokens` remains authoritative.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_tokens")]
        public int? EstimatedTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Thinking { get; set; }

        /// <summary>
        /// Default Value: thinking_delta
        /// </summary>
        /// <default>"thinking_delta"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "thinking_delta";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingContentBlockDelta" /> class.
        /// </summary>
        /// <param name="thinking"></param>
        /// <param name="estimatedTokens">
        /// Per-frame increment of a coarse, running estimate of the tokens this thinking block has produced so far. Present whenever the `thinking-token-count-2026-05-13` beta is set; `null` unless `thinking.display` resolves to `"omitted"` and a count is due this frame. Sum the increments across `thinking_delta` frames on this block for a progress indicator. Each increment is a non-negative multiple of a fixed quantum and the cadence is rate-limited, so this is a deliberately lossy display hint, not a billable count; `usage.output_tokens` remains authoritative.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Default Value: thinking_delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaThinkingContentBlockDelta(
            string thinking,
            int? estimatedTokens,
            string type = "thinking_delta")
        {
            this.EstimatedTokens = estimatedTokens;
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingContentBlockDelta" /> class.
        /// </summary>
        public BetaThinkingContentBlockDelta()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaThinkingContentBlockDelta"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaThinkingContentBlockDelta FromThinking(string thinking)
        {
            return new BetaThinkingContentBlockDelta
            {
                Thinking = thinking,
            };
        }

    }
}