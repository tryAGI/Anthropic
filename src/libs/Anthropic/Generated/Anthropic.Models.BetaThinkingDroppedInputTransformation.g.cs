
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaThinkingDroppedInputTransformation
    {
        /// <summary>
        /// Where the removed block was in your request, as `messages.{i}.content.{j}`:<br/>
        /// `i` indexes the `messages` array you sent and `j` that message's `content`<br/>
        /// array — the same form error messages use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Which binding check removed the block: `model_binding_mismatch` — it was<br/>
        /// created by a model whose reasoning the requested model may not read;<br/>
        /// `prefix_binding_mismatch` — the conversation before it differs from the<br/>
        /// conversation it was created in (the rest of that turn's consecutive thinking<br/>
        /// blocks are removed with it, each with this reason);<br/>
        /// `organization_binding_mismatch` — it was created under a different<br/>
        /// organization (an Anthropic organization, AWS account or Google Cloud project)<br/>
        /// and this organization is not one of its additional organizations;<br/>
        /// `end_user_binding_mismatch` — it was created for a different end user, or<br/>
        /// was removed by the consumer-organization binding. A block that would fail<br/>
        /// several checks reports one reason, in this order of precedence:<br/>
        /// `organization_binding_mismatch`, `end_user_binding_mismatch`,<br/>
        /// `model_binding_mismatch`, `prefix_binding_mismatch`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaThinkingDroppedInputTransformationReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaThinkingDroppedInputTransformationReason Reason { get; set; }

        /// <summary>
        /// Always `thinking_dropped` for this entry type.<br/>
        /// Default Value: thinking_dropped
        /// </summary>
        /// <default>"thinking_dropped"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "thinking_dropped";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingDroppedInputTransformation" /> class.
        /// </summary>
        /// <param name="path">
        /// Where the removed block was in your request, as `messages.{i}.content.{j}`:<br/>
        /// `i` indexes the `messages` array you sent and `j` that message's `content`<br/>
        /// array — the same form error messages use.
        /// </param>
        /// <param name="reason">
        /// Which binding check removed the block: `model_binding_mismatch` — it was<br/>
        /// created by a model whose reasoning the requested model may not read;<br/>
        /// `prefix_binding_mismatch` — the conversation before it differs from the<br/>
        /// conversation it was created in (the rest of that turn's consecutive thinking<br/>
        /// blocks are removed with it, each with this reason);<br/>
        /// `organization_binding_mismatch` — it was created under a different<br/>
        /// organization (an Anthropic organization, AWS account or Google Cloud project)<br/>
        /// and this organization is not one of its additional organizations;<br/>
        /// `end_user_binding_mismatch` — it was created for a different end user, or<br/>
        /// was removed by the consumer-organization binding. A block that would fail<br/>
        /// several checks reports one reason, in this order of precedence:<br/>
        /// `organization_binding_mismatch`, `end_user_binding_mismatch`,<br/>
        /// `model_binding_mismatch`, `prefix_binding_mismatch`.
        /// </param>
        /// <param name="type">
        /// Always `thinking_dropped` for this entry type.<br/>
        /// Default Value: thinking_dropped
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaThinkingDroppedInputTransformation(
            string path,
            global::Anthropic.BetaThinkingDroppedInputTransformationReason reason,
            string type = "thinking_dropped")
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Reason = reason;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingDroppedInputTransformation" /> class.
        /// </summary>
        public BetaThinkingDroppedInputTransformation()
        {
        }

    }
}