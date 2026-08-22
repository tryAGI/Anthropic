
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEnvironmentVariableCreateParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        EnvironmentVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEnvironmentVariableCreateParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEnvironmentVariableCreateParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsEnvironmentVariableCreateParamsType.EnvironmentVariable => "environment_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEnvironmentVariableCreateParamsType? ToEnum(string value)
        {
            return value switch
            {
                "environment_variable" => BetaManagedAgentsEnvironmentVariableCreateParamsType.EnvironmentVariable,
                _ => null,
            };
        }
    }
}