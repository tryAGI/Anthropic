
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionMultiagentCoordinatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Coordinator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionMultiagentCoordinatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionMultiagentCoordinatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionMultiagentCoordinatorType.Coordinator => "coordinator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionMultiagentCoordinatorType? ToEnum(string value)
        {
            return value switch
            {
                "coordinator" => BetaManagedAgentsSessionMultiagentCoordinatorType.Coordinator,
                _ => null,
            };
        }
    }
}