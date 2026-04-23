
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMemoryPathConflictErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryPathConflictError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMemoryPathConflictErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMemoryPathConflictErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsMemoryPathConflictErrorType.MemoryPathConflictError => "memory_path_conflict_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMemoryPathConflictErrorType? ToEnum(string value)
        {
            return value switch
            {
                "memory_path_conflict_error" => BetaManagedAgentsMemoryPathConflictErrorType.MemoryPathConflictError,
                _ => null,
            };
        }
    }
}