
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ComputerScrollDirection
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
    public static class ComputerScrollDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerScrollDirection value)
        {
            return value switch
            {
                ComputerScrollDirection.Down => "down",
                ComputerScrollDirection.Left => "left",
                ComputerScrollDirection.Right => "right",
                ComputerScrollDirection.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerScrollDirection? ToEnum(string value)
        {
            return value switch
            {
                "down" => ComputerScrollDirection.Down,
                "left" => ComputerScrollDirection.Left,
                "right" => ComputerScrollDirection.Right,
                "up" => ComputerScrollDirection.Up,
                _ => null,
            };
        }
    }
}