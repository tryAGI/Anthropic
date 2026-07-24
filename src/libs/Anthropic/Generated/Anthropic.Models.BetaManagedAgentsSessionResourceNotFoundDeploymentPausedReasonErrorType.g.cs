
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionResourceNotFoundError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonErrorType.SessionResourceNotFoundError => "session_resource_not_found_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonErrorType? ToEnum(string value)
        {
            return value switch
            {
                "session_resource_not_found_error" => BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonErrorType.SessionResourceNotFoundError,
                _ => null,
            };
        }
    }
}