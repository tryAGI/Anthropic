
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsSessionMultiagentDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Coordinator,
        /// <summary>
        ///
        /// </summary>
        Multiagent20261001,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionMultiagentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionMultiagentDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionMultiagentDiscriminatorType.Coordinator => "coordinator",
                BetaManagedAgentsSessionMultiagentDiscriminatorType.Multiagent20261001 => "multiagent_20261001",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionMultiagentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "coordinator" => BetaManagedAgentsSessionMultiagentDiscriminatorType.Coordinator,
                "multiagent_20261001" => BetaManagedAgentsSessionMultiagentDiscriminatorType.Multiagent20261001,
                _ => null,
            };
        }
    }
}