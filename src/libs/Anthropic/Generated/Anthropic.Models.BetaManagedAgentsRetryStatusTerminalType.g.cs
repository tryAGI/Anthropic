
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsRetryStatusTerminalType
    {
        /// <summary>
        /// 
        /// </summary>
        Terminal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsRetryStatusTerminalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsRetryStatusTerminalType value)
        {
            return value switch
            {
                BetaManagedAgentsRetryStatusTerminalType.Terminal => "terminal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsRetryStatusTerminalType? ToEnum(string value)
        {
            return value switch
            {
                "terminal" => BetaManagedAgentsRetryStatusTerminalType.Terminal,
                _ => null,
            };
        }
    }
}