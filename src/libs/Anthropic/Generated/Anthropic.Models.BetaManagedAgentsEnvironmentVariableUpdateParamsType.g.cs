
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEnvironmentVariableUpdateParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        EnvironmentVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEnvironmentVariableUpdateParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEnvironmentVariableUpdateParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsEnvironmentVariableUpdateParamsType.EnvironmentVariable => "environment_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEnvironmentVariableUpdateParamsType? ToEnum(string value)
        {
            return value switch
            {
                "environment_variable" => BetaManagedAgentsEnvironmentVariableUpdateParamsType.EnvironmentVariable,
                _ => null,
            };
        }
    }
}