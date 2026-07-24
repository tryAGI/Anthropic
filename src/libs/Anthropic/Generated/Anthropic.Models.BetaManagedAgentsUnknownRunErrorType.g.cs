
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUnknownRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        UnknownError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUnknownRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUnknownRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsUnknownRunErrorType.UnknownError => "unknown_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUnknownRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "unknown_error" => BetaManagedAgentsUnknownRunErrorType.UnknownError,
                _ => null,
            };
        }
    }
}