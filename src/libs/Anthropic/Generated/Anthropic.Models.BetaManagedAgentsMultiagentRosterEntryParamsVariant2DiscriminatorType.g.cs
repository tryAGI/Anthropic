
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMultiagentRosterEntryParamsVariant2DiscriminatorType
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
    public static class BetaManagedAgentsMultiagentRosterEntryParamsVariant2DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentRosterEntryParamsVariant2DiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentRosterEntryParamsVariant2DiscriminatorType.Agent => "agent",
                BetaManagedAgentsMultiagentRosterEntryParamsVariant2DiscriminatorType.Self => "self",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentRosterEntryParamsVariant2DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => BetaManagedAgentsMultiagentRosterEntryParamsVariant2DiscriminatorType.Agent,
                "self" => BetaManagedAgentsMultiagentRosterEntryParamsVariant2DiscriminatorType.Self,
                _ => null,
            };
        }
    }
}