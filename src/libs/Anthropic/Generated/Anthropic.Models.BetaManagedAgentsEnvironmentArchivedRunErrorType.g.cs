
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEnvironmentArchivedRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        EnvironmentArchivedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEnvironmentArchivedRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEnvironmentArchivedRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsEnvironmentArchivedRunErrorType.EnvironmentArchivedError => "environment_archived_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEnvironmentArchivedRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "environment_archived_error" => BetaManagedAgentsEnvironmentArchivedRunErrorType.EnvironmentArchivedError,
                _ => null,
            };
        }
    }
}