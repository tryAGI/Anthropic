
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaOutputBehaviorDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        CreateNew,
        /// <summary>
        ///
        /// </summary>
        UpdateExisting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaOutputBehaviorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOutputBehaviorDiscriminatorType value)
        {
            return value switch
            {
                BetaOutputBehaviorDiscriminatorType.CreateNew => "create_new",
                BetaOutputBehaviorDiscriminatorType.UpdateExisting => "update_existing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOutputBehaviorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "create_new" => BetaOutputBehaviorDiscriminatorType.CreateNew,
                "update_existing" => BetaOutputBehaviorDiscriminatorType.UpdateExisting,
                _ => null,
            };
        }
    }
}