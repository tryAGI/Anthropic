
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BrowserClickTargetDiscriminatorType
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
    public static class BrowserClickTargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BrowserClickTargetDiscriminatorType value)
        {
            return value switch
            {
                BrowserClickTargetDiscriminatorType.Coordinate => "coordinate",
                BrowserClickTargetDiscriminatorType.Ref => "ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BrowserClickTargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "coordinate" => BrowserClickTargetDiscriminatorType.Coordinate,
                "ref" => BrowserClickTargetDiscriminatorType.Ref,
                _ => null,
            };
        }
    }
}