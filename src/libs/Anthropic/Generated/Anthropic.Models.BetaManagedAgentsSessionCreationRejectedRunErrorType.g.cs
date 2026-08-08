
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionCreationRejectedRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionCreationRejectedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionCreationRejectedRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionCreationRejectedRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionCreationRejectedRunErrorType.SessionCreationRejectedError => "session_creation_rejected_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionCreationRejectedRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "session_creation_rejected_error" => BetaManagedAgentsSessionCreationRejectedRunErrorType.SessionCreationRejectedError,
                _ => null,
            };
        }
    }
}