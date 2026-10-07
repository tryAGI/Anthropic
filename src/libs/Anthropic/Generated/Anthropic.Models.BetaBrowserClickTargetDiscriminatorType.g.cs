
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaBrowserClickTargetDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Coordinate,
        /// <summary>
        ///
        /// </summary>
        Ref,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBrowserClickTargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBrowserClickTargetDiscriminatorType value)
        {
            return value switch
            {
                BetaBrowserClickTargetDiscriminatorType.Coordinate => "coordinate",
                BetaBrowserClickTargetDiscriminatorType.Ref => "ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBrowserClickTargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "coordinate" => BetaBrowserClickTargetDiscriminatorType.Coordinate,
                "ref" => BetaBrowserClickTargetDiscriminatorType.Ref,
                _ => null,
            };
        }
    }
}