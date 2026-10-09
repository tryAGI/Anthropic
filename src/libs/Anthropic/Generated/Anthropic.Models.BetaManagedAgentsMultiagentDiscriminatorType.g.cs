
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsMultiagentDiscriminatorType
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
    public static class BetaManagedAgentsMultiagentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentDiscriminatorType.Coordinator => "coordinator",
                BetaManagedAgentsMultiagentDiscriminatorType.Multiagent20261001 => "multiagent_20261001",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "coordinator" => BetaManagedAgentsMultiagentDiscriminatorType.Coordinator,
                "multiagent_20261001" => BetaManagedAgentsMultiagentDiscriminatorType.Multiagent20261001,
                _ => null,
            };
        }
    }
}