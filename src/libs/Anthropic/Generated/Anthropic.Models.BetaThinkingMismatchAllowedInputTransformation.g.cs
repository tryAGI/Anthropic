
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaThinkingMismatchAllowedInputTransformation
    {
        /// <summary>
        /// Where the block is in your request, as `messages.{i}.content.{j}`:<br/>
        /// `i` indexes the `messages` array you sent and `j` that message's `content`<br/>
        /// array — the same form error messages use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Which binding check the block failed; the block was shown to the model all<br/>
        /// the same. Always `prefix_binding_mismatch` today — the conversation before<br/>
        /// the block differs from the conversation it was created in, or the block<br/>
        /// carries no record of one on a model that requires it. Were the check<br/>
        /// enforced for this request, the block would have been removed or the request<br/>
        /// rejected (`thinking.block_binding.prefix_mismatch_behavior`). A removal also<br/>
        /// takes the rest of that turn's consecutive thinking blocks, whereas here each<br/>
        /// block is checked on its own, so `thinking_mismatch_allowed` entries are a<br/>
        /// lower bound on what enforcement would remove.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaThinkingMismatchAllowedInputTransformationReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaThinkingMismatchAllowedInputTransformationReason Reason { get; set; }

        /// <summary>
        /// Always `thinking_mismatch_allowed` for this entry type.<br/>
        /// Default Value: thinking_mismatch_allowed
        /// </summary>
        /// <default>"thinking_mismatch_allowed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "thinking_mismatch_allowed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingMismatchAllowedInputTransformation" /> class.
        /// </summary>
        /// <param name="path">
        /// Where the block is in your request, as `messages.{i}.content.{j}`:<br/>
        /// `i` indexes the `messages` array you sent and `j` that message's `content`<br/>
        /// array — the same form error messages use.
        /// </param>
        /// <param name="reason">
        /// Which binding check the block failed; the block was shown to the model all<br/>
        /// the same. Always `prefix_binding_mismatch` today — the conversation before<br/>
        /// the block differs from the conversation it was created in, or the block<br/>
        /// carries no record of one on a model that requires it. Were the check<br/>
        /// enforced for this request, the block would have been removed or the request<br/>
        /// rejected (`thinking.block_binding.prefix_mismatch_behavior`). A removal also<br/>
        /// takes the rest of that turn's consecutive thinking blocks, whereas here each<br/>
        /// block is checked on its own, so `thinking_mismatch_allowed` entries are a<br/>
        /// lower bound on what enforcement would remove.
        /// </param>
        /// <param name="type">
        /// Always `thinking_mismatch_allowed` for this entry type.<br/>
        /// Default Value: thinking_mismatch_allowed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaThinkingMismatchAllowedInputTransformation(
            string path,
            global::Anthropic.BetaThinkingMismatchAllowedInputTransformationReason reason,
            string type = "thinking_mismatch_allowed")
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Reason = reason;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingMismatchAllowedInputTransformation" /> class.
        /// </summary>
        public BetaThinkingMismatchAllowedInputTransformation()
        {
        }

    }
}