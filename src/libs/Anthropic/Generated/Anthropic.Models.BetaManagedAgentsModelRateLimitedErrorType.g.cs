
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsModelRateLimitedErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        ModelRateLimitedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsModelRateLimitedErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsModelRateLimitedErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsModelRateLimitedErrorType.ModelRateLimitedError => "model_rate_limited_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsModelRateLimitedErrorType? ToEnum(string value)
        {
            return value switch
            {
                "model_rate_limited_error" => BetaManagedAgentsModelRateLimitedErrorType.ModelRateLimitedError,
                _ => null,
            };
        }
    }
}