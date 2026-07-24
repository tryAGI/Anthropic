
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionRateLimitedRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionRateLimitedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionRateLimitedRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionRateLimitedRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionRateLimitedRunErrorType.SessionRateLimitedError => "session_rate_limited_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionRateLimitedRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "session_rate_limited_error" => BetaManagedAgentsSessionRateLimitedRunErrorType.SessionRateLimitedError,
                _ => null,
            };
        }
    }
}