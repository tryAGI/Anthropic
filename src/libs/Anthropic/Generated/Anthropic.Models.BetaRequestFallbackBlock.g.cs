
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A `fallback` block echoed back from a prior response.<br/>
    /// Accepted in `messages[].content` and not rendered into the prompt; not<br/>
    /// validated against the request's `fallbacks` chain or top-level `model`.<br/>
    /// Echo the assistant turn back verbatim, including this block in its<br/>
    /// original position. The block marks the boundary between content produced<br/>
    /// before and after a fallback hop, and the server relies on that boundary<br/>
    /// to validate the turn: when thinking runs flank the boundary, omitting<br/>
    /// the block merges them into one span the server cannot validate (the<br/>
    /// request is rejected), and moving it into the middle of a single run is<br/>
    /// likewise rejected; between non-thinking blocks the block's placement has<br/>
    /// no validation effect.
    /// </summary>
    public sealed partial class BetaRequestFallbackBlock
    {
        /// <summary>
        /// Identifies one hop of a fallback transition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaRequestFallbackHopInfo From { get; set; }

        /// <summary>
        /// Identifies one hop of a fallback transition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaRequestFallbackHopInfo To { get; set; }

        /// <summary>
        /// The response block's `trigger`, echoed verbatim. Accepted and ignored by the server; any object or `null` is allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public object? Trigger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"fallback"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "fallback";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestFallbackBlock" /> class.
        /// </summary>
        /// <param name="from">
        /// Identifies one hop of a fallback transition.
        /// </param>
        /// <param name="to">
        /// Identifies one hop of a fallback transition.
        /// </param>
        /// <param name="trigger">
        /// The response block's `trigger`, echoed verbatim. Accepted and ignored by the server; any object or `null` is allowed.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestFallbackBlock(
            global::Anthropic.BetaRequestFallbackHopInfo from,
            global::Anthropic.BetaRequestFallbackHopInfo to,
            object? trigger,
            string type = "fallback")
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Trigger = trigger;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestFallbackBlock" /> class.
        /// </summary>
        public BetaRequestFallbackBlock()
        {
        }

    }
}