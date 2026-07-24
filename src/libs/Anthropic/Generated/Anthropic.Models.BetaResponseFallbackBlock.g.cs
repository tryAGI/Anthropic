
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Marks the point in `content` where one model's output gives way to the next.<br/>
    /// One block appears per hop where a preceding model actually ran this turn and<br/>
    /// declined. A turn where no preceding model ran and declined has no such<br/>
    /// boundary and carries no block — the signal for whether a fallback model<br/>
    /// served the response is the presence of a `fallback_message` entry in<br/>
    /// `usage.iterations`, not this block.<br/>
    /// The block is treated like a server-tool content block for streaming: it<br/>
    /// arrives via the standard `content_block_start` / `content_block_stop`<br/>
    /// pair and carries no deltas.
    /// </summary>
    public sealed partial class BetaResponseFallbackBlock
    {
        /// <summary>
        /// The model whose output ends at this point — the model that declined at this hop. When the declining hop is the requested model, its `model` echoes the top-level `model` string the caller sent (alias or canonical); when the declining hop is a fallback model, its `model` is that model's canonical id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaResponseFallbackHopInfo From { get; set; }

        /// <summary>
        /// The fallback model producing the content that follows this block. Its `model` is always the canonical id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaResponseFallbackHopInfo To { get; set; }

        /// <summary>
        /// What caused the `from` model to hand over at this hop.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaFallbackRefusalTrigger Trigger { get; set; }

        /// <summary>
        /// Default Value: fallback
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
        /// Initializes a new instance of the <see cref="BetaResponseFallbackBlock" /> class.
        /// </summary>
        /// <param name="from">
        /// The model whose output ends at this point — the model that declined at this hop. When the declining hop is the requested model, its `model` echoes the top-level `model` string the caller sent (alias or canonical); when the declining hop is a fallback model, its `model` is that model's canonical id.
        /// </param>
        /// <param name="to">
        /// The fallback model producing the content that follows this block. Its `model` is always the canonical id.
        /// </param>
        /// <param name="trigger">
        /// What caused the `from` model to hand over at this hop.
        /// </param>
        /// <param name="type">
        /// Default Value: fallback
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseFallbackBlock(
            global::Anthropic.BetaResponseFallbackHopInfo from,
            global::Anthropic.BetaResponseFallbackHopInfo to,
            global::Anthropic.BetaFallbackRefusalTrigger trigger,
            string type = "fallback")
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Trigger = trigger ?? throw new global::System.ArgumentNullException(nameof(trigger));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseFallbackBlock" /> class.
        /// </summary>
        public BetaResponseFallbackBlock()
        {
        }

    }
}