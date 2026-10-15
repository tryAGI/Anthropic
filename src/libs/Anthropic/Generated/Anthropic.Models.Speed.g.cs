
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum Speed
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Speed value)
        {
            return value switch
            {
                Speed.Fast => "fast",
                Speed.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Speed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => Speed.Fast,
                "standard" => Speed.Standard,
                _ => null,
            };
        }
    }
}