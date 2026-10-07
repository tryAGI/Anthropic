
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaBrowserScrollDirection
    {
        /// <summary>
        ///
        /// </summary>
        Down,
        /// <summary>
        ///
        /// </summary>
        Left,
        /// <summary>
        ///
        /// </summary>
        Right,
        /// <summary>
        ///
        /// </summary>
        Up,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBrowserScrollDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBrowserScrollDirection value)
        {
            return value switch
            {
                BetaBrowserScrollDirection.Down => "down",
                BetaBrowserScrollDirection.Left => "left",
                BetaBrowserScrollDirection.Right => "right",
                BetaBrowserScrollDirection.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBrowserScrollDirection? ToEnum(string value)
        {
            return value switch
            {
                "down" => BetaBrowserScrollDirection.Down,
                "left" => BetaBrowserScrollDirection.Left,
                "right" => BetaBrowserScrollDirection.Right,
                "up" => BetaBrowserScrollDirection.Up,
                _ => null,
            };
        }
    }
}