
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Per-frame increment of a coarse, running estimate of the tokens this thinking block has produced so far. Present whenever the `thinking-token-count-2026-05-13` beta is set; `null` unless `thinking.display` resolves to `"omitted"` and a count is due this frame. Sum the increments across `thinking_delta` frames on this block for a progress indicator. Each increment is a non-negative multiple of a fixed quantum and the cadence is rate-limited, so this is a deliberately lossy display hint, not a billable count; `usage.output_tokens` remains authoritative.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class BetaThinkingContentBlockDeltaEstimatedTokens
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}