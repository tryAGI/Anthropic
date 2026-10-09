
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsMultiagentParamsDiscriminatorType
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
    public static class BetaManagedAgentsMultiagentParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentParamsDiscriminatorType.Coordinator => "coordinator",
                BetaManagedAgentsMultiagentParamsDiscriminatorType.Multiagent20261001 => "multiagent_20261001",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "coordinator" => BetaManagedAgentsMultiagentParamsDiscriminatorType.Coordinator,
                "multiagent_20261001" => BetaManagedAgentsMultiagentParamsDiscriminatorType.Multiagent20261001,
                _ => null,
            };
        }
    }
}