
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsModelRequestFailedErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        ModelRequestFailedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsModelRequestFailedErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsModelRequestFailedErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsModelRequestFailedErrorType.ModelRequestFailedError => "model_request_failed_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsModelRequestFailedErrorType? ToEnum(string value)
        {
            return value switch
            {
                "model_request_failed_error" => BetaManagedAgentsModelRequestFailedErrorType.ModelRequestFailedError,
                _ => null,
            };
        }
    }
}