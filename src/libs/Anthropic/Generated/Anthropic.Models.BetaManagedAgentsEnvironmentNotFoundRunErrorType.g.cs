
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEnvironmentNotFoundRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        EnvironmentNotFoundError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEnvironmentNotFoundRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEnvironmentNotFoundRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsEnvironmentNotFoundRunErrorType.EnvironmentNotFoundError => "environment_not_found_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEnvironmentNotFoundRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "environment_not_found_error" => BetaManagedAgentsEnvironmentNotFoundRunErrorType.EnvironmentNotFoundError,
                _ => null,
            };
        }
    }
}