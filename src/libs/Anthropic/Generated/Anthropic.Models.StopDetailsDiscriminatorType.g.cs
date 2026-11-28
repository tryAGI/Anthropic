
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum StopDetailsDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopDetailsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopDetailsDiscriminatorType value)
        {
            return value switch
            {
                StopDetailsDiscriminatorType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopDetailsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => StopDetailsDiscriminatorType.Refusal,
                _ => null,
            };
        }
    }
}