
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMultiagentCoordinatorParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        Coordinator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMultiagentCoordinatorParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentCoordinatorParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentCoordinatorParamsType.Coordinator => "coordinator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentCoordinatorParamsType? ToEnum(string value)
        {
            return value switch
            {
                "coordinator" => BetaManagedAgentsMultiagentCoordinatorParamsType.Coordinator,
                _ => null,
            };
        }
    }
}