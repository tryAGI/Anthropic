
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: ping
    /// </summary>
    public enum PingType
    {
        /// <summary>
        /// 
        /// </summary>
        Ping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PingType value)
        {
            return value switch
            {
                PingType.Ping => "ping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PingType? ToEnum(string value)
        {
            return value switch
            {
                "ping" => PingType.Ping,
                _ => null,
            };
        }
    }
}