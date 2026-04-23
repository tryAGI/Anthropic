
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Access mode for an attached memory store.
    /// </summary>
    public enum BetaManagedAgentsMountMode
    {
        /// <summary>
        /// 
        /// </summary>
        ReadOnly,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMountModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMountMode value)
        {
            return value switch
            {
                BetaManagedAgentsMountMode.ReadOnly => "read_only",
                BetaManagedAgentsMountMode.ReadWrite => "read_write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMountMode? ToEnum(string value)
        {
            return value switch
            {
                "read_only" => BetaManagedAgentsMountMode.ReadOnly,
                "read_write" => BetaManagedAgentsMountMode.ReadWrite,
                _ => null,
            };
        }
    }
}