
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCompactionConfigDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Summarize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCompactionConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCompactionConfigDiscriminatorType value)
        {
            return value switch
            {
                BetaCompactionConfigDiscriminatorType.Summarize => "summarize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCompactionConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "summarize" => BetaCompactionConfigDiscriminatorType.Summarize,
                _ => null,
            };
        }
    }
}