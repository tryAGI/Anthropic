
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaOutputBehaviorUpdateExistingType
    {
        /// <summary>
        ///
        /// </summary>
        UpdateExisting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaOutputBehaviorUpdateExistingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOutputBehaviorUpdateExistingType value)
        {
            return value switch
            {
                BetaOutputBehaviorUpdateExistingType.UpdateExisting => "update_existing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOutputBehaviorUpdateExistingType? ToEnum(string value)
        {
            return value switch
            {
                "update_existing" => BetaOutputBehaviorUpdateExistingType.UpdateExisting,
                _ => null,
            };
        }
    }
}