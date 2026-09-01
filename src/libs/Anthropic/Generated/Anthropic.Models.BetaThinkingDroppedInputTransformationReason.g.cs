
#nullable enable

namespace Anthropic
{
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
    public enum BetaThinkingDroppedInputTransformationReason
    {
        /// <summary>
        ///
        /// </summary>
        EndUserBindingMismatch,
        /// <summary>
        /// `model_binding_mismatch` — it was
        /// </summary>
        ModelBindingMismatch,
        /// <summary>
        ///
        /// </summary>
        OrganizationBindingMismatch,
        /// <summary>
        ///
        /// </summary>
        PrefixBindingMismatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaThinkingDroppedInputTransformationReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaThinkingDroppedInputTransformationReason value)
        {
            return value switch
            {
                BetaThinkingDroppedInputTransformationReason.EndUserBindingMismatch => "end_user_binding_mismatch",
                BetaThinkingDroppedInputTransformationReason.ModelBindingMismatch => "model_binding_mismatch",
                BetaThinkingDroppedInputTransformationReason.OrganizationBindingMismatch => "organization_binding_mismatch",
                BetaThinkingDroppedInputTransformationReason.PrefixBindingMismatch => "prefix_binding_mismatch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaThinkingDroppedInputTransformationReason? ToEnum(string value)
        {
            return value switch
            {
                "end_user_binding_mismatch" => BetaThinkingDroppedInputTransformationReason.EndUserBindingMismatch,
                "model_binding_mismatch" => BetaThinkingDroppedInputTransformationReason.ModelBindingMismatch,
                "organization_binding_mismatch" => BetaThinkingDroppedInputTransformationReason.OrganizationBindingMismatch,
                "prefix_binding_mismatch" => BetaThinkingDroppedInputTransformationReason.PrefixBindingMismatch,
                _ => null,
            };
        }
    }
}