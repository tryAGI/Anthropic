
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaStopDetailsDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaStopDetailsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaStopDetailsDiscriminatorType value)
        {
            return value switch
            {
                BetaStopDetailsDiscriminatorType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaStopDetailsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => BetaStopDetailsDiscriminatorType.Refusal,
                _ => null,
            };
        }
    }
}