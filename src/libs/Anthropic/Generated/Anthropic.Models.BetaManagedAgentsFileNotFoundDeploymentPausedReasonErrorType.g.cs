
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsFileNotFoundDeploymentPausedReasonErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        FileNotFoundError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsFileNotFoundDeploymentPausedReasonErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsFileNotFoundDeploymentPausedReasonErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsFileNotFoundDeploymentPausedReasonErrorType.FileNotFoundError => "file_not_found_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsFileNotFoundDeploymentPausedReasonErrorType? ToEnum(string value)
        {
            return value switch
            {
                "file_not_found_error" => BetaManagedAgentsFileNotFoundDeploymentPausedReasonErrorType.FileNotFoundError,
                _ => null,
            };
        }
    }
}