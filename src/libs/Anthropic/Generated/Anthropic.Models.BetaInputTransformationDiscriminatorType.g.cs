
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaInputTransformationDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ThinkingDropped,
        /// <summary>
        ///
        /// </summary>
        ThinkingMismatchAllowed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputTransformationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputTransformationDiscriminatorType value)
        {
            return value switch
            {
                BetaInputTransformationDiscriminatorType.ThinkingDropped => "thinking_dropped",
                BetaInputTransformationDiscriminatorType.ThinkingMismatchAllowed => "thinking_mismatch_allowed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputTransformationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "thinking_dropped" => BetaInputTransformationDiscriminatorType.ThinkingDropped,
                "thinking_mismatch_allowed" => BetaInputTransformationDiscriminatorType.ThinkingMismatchAllowed,
                _ => null,
            };
        }
    }
}