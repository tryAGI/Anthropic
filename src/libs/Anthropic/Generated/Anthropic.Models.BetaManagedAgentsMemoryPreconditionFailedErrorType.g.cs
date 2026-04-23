
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMemoryPreconditionFailedErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryPreconditionFailedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMemoryPreconditionFailedErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMemoryPreconditionFailedErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsMemoryPreconditionFailedErrorType.MemoryPreconditionFailedError => "memory_precondition_failed_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMemoryPreconditionFailedErrorType? ToEnum(string value)
        {
            return value switch
            {
                "memory_precondition_failed_error" => BetaManagedAgentsMemoryPreconditionFailedErrorType.MemoryPreconditionFailedError,
                _ => null,
            };
        }
    }
}