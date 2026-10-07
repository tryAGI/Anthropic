
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BrowserScrollDirection
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
    public static class BrowserScrollDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BrowserScrollDirection value)
        {
            return value switch
            {
                BrowserScrollDirection.Down => "down",
                BrowserScrollDirection.Left => "left",
                BrowserScrollDirection.Right => "right",
                BrowserScrollDirection.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BrowserScrollDirection? ToEnum(string value)
        {
            return value switch
            {
                "down" => BrowserScrollDirection.Down,
                "left" => BrowserScrollDirection.Left,
                "right" => BrowserScrollDirection.Right,
                "up" => BrowserScrollDirection.Up,
                _ => null,
            };
        }
    }
}