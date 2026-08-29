
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsMultiagentRosterEntryDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Advisor,
        /// <summary>
        ///
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMultiagentRosterEntryDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentRosterEntryDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentRosterEntryDiscriminatorType.Advisor => "advisor",
                BetaManagedAgentsMultiagentRosterEntryDiscriminatorType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentRosterEntryDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "advisor" => BetaManagedAgentsMultiagentRosterEntryDiscriminatorType.Advisor,
                "agent" => BetaManagedAgentsMultiagentRosterEntryDiscriminatorType.Agent,
                _ => null,
            };
        }
    }
}