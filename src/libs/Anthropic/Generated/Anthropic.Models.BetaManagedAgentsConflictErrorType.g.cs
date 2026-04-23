
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsConflictErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        ConflictError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsConflictErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsConflictErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsConflictErrorType.ConflictError => "conflict_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsConflictErrorType? ToEnum(string value)
        {
            return value switch
            {
                "conflict_error" => BetaManagedAgentsConflictErrorType.ConflictError,
                _ => null,
            };
        }
    }
}