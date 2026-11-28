
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaWorkspaceChangedConcurrentlyField
    {
        /// <summary>
        ///
        /// </summary>
        InferenceDataPrivacyHumanReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWorkspaceChangedConcurrentlyFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWorkspaceChangedConcurrentlyField value)
        {
            return value switch
            {
                BetaWorkspaceChangedConcurrentlyField.InferenceDataPrivacyHumanReview => "inference_data_privacy.human_review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWorkspaceChangedConcurrentlyField? ToEnum(string value)
        {
            return value switch
            {
                "inference_data_privacy.human_review" => BetaWorkspaceChangedConcurrentlyField.InferenceDataPrivacyHumanReview,
                _ => null,
            };
        }
    }
}