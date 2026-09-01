
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Controls for block binding: what happens when a thinking block this<br/>
    /// request sends back fails the conversation check. Every field is optional;<br/>
    /// an empty object means every default.
    /// </summary>
    public sealed partial class BetaThinkingBlockBinding
    {
        /// <summary>
        /// "error" (default) | "drop_block". What happens when a thinking block in `messages` fails the conversation check (it was created in a different conversation, or the messages before it have changed since). "error" fails the request with a 400 error. "drop_block" removes the failing blocks and the request proceeds; each removal is reported in `input_transformations`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_mismatch_behavior")]
        public global::Anthropic.BetaThinkingPrefixMismatchBehavior? PrefixMismatchBehavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingBlockBinding" /> class.
        /// </summary>
        /// <param name="prefixMismatchBehavior">
        /// "error" (default) | "drop_block". What happens when a thinking block in `messages` fails the conversation check (it was created in a different conversation, or the messages before it have changed since). "error" fails the request with a 400 error. "drop_block" removes the failing blocks and the request proceeds; each removal is reported in `input_transformations`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaThinkingBlockBinding(
            global::Anthropic.BetaThinkingPrefixMismatchBehavior? prefixMismatchBehavior)
        {
            this.PrefixMismatchBehavior = prefixMismatchBehavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingBlockBinding" /> class.
        /// </summary>
        public BetaThinkingBlockBinding()
        {
        }

    }
}