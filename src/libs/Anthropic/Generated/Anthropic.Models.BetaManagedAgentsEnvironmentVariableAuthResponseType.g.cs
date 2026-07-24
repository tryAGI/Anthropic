
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEnvironmentVariableAuthResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        EnvironmentVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEnvironmentVariableAuthResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEnvironmentVariableAuthResponseType value)
        {
            return value switch
            {
                BetaManagedAgentsEnvironmentVariableAuthResponseType.EnvironmentVariable => "environment_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEnvironmentVariableAuthResponseType? ToEnum(string value)
        {
            return value switch
            {
                "environment_variable" => BetaManagedAgentsEnvironmentVariableAuthResponseType.EnvironmentVariable,
                _ => null,
            };
        }
    }
}