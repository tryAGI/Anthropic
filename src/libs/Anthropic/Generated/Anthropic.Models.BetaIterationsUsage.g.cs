
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Per-iteration token usage breakdown.<br/>
    /// Each entry represents one sampling iteration, with its own input/output token counts and cache statistics. This allows you to:<br/>
    /// - Determine which iterations exceeded long context thresholds (&gt;=200k tokens)<br/>
    /// - Calculate the true context window size from the last iteration<br/>
    /// - Understand token accumulation across server-side tool use loops<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class BetaIterationsUsage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}