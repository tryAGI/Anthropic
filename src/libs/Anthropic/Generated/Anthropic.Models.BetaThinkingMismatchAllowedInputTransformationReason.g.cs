
#nullable enable

namespace Anthropic
{
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
    public enum BetaThinkingMismatchAllowedInputTransformationReason
    {
        /// <summary>
        ///
        /// </summary>
        EndUserBindingMismatch,
        /// <summary>
        ///
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
    public static class BetaThinkingMismatchAllowedInputTransformationReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaThinkingMismatchAllowedInputTransformationReason value)
        {
            return value switch
            {
                BetaThinkingMismatchAllowedInputTransformationReason.EndUserBindingMismatch => "end_user_binding_mismatch",
                BetaThinkingMismatchAllowedInputTransformationReason.ModelBindingMismatch => "model_binding_mismatch",
                BetaThinkingMismatchAllowedInputTransformationReason.OrganizationBindingMismatch => "organization_binding_mismatch",
                BetaThinkingMismatchAllowedInputTransformationReason.PrefixBindingMismatch => "prefix_binding_mismatch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaThinkingMismatchAllowedInputTransformationReason? ToEnum(string value)
        {
            return value switch
            {
                "end_user_binding_mismatch" => BetaThinkingMismatchAllowedInputTransformationReason.EndUserBindingMismatch,
                "model_binding_mismatch" => BetaThinkingMismatchAllowedInputTransformationReason.ModelBindingMismatch,
                "organization_binding_mismatch" => BetaThinkingMismatchAllowedInputTransformationReason.OrganizationBindingMismatch,
                "prefix_binding_mismatch" => BetaThinkingMismatchAllowedInputTransformationReason.PrefixBindingMismatch,
                _ => null,
            };
        }
    }
}