
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaComputerScrollDirection
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
    public static class BetaComputerScrollDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerScrollDirection value)
        {
            return value switch
            {
                BetaComputerScrollDirection.Down => "down",
                BetaComputerScrollDirection.Left => "left",
                BetaComputerScrollDirection.Right => "right",
                BetaComputerScrollDirection.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerScrollDirection? ToEnum(string value)
        {
            return value switch
            {
                "down" => BetaComputerScrollDirection.Down,
                "left" => BetaComputerScrollDirection.Left,
                "right" => BetaComputerScrollDirection.Right,
                "up" => BetaComputerScrollDirection.Up,
                _ => null,
            };
        }
    }
}