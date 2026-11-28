
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Self,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2DiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2DiscriminatorType.Agent => "agent",
                BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2DiscriminatorType.Self => "self",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2DiscriminatorType.Agent,
                "self" => BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2DiscriminatorType.Self,
                _ => null,
            };
        }
    }
}