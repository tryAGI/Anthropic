
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionResourceNotFoundRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionResourceNotFoundError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionResourceNotFoundRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionResourceNotFoundRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionResourceNotFoundRunErrorType.SessionResourceNotFoundError => "session_resource_not_found_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionResourceNotFoundRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "session_resource_not_found_error" => BetaManagedAgentsSessionResourceNotFoundRunErrorType.SessionResourceNotFoundError,
                _ => null,
            };
        }
    }
}