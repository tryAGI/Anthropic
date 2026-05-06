
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionThreadType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionThread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionThreadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionThreadType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionThreadType.SessionThread => "session_thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionThreadType? ToEnum(string value)
        {
            return value switch
            {
                "session_thread" => BetaManagedAgentsSessionThreadType.SessionThread,
                _ => null,
            };
        }
    }
}