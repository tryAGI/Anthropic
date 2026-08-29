
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsSessionRosterEntryDiscriminatorType
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
    public static class BetaManagedAgentsSessionRosterEntryDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionRosterEntryDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionRosterEntryDiscriminatorType.Advisor => "advisor",
                BetaManagedAgentsSessionRosterEntryDiscriminatorType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionRosterEntryDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "advisor" => BetaManagedAgentsSessionRosterEntryDiscriminatorType.Advisor,
                "agent" => BetaManagedAgentsSessionRosterEntryDiscriminatorType.Agent,
                _ => null,
            };
        }
    }
}