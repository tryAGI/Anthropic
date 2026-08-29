
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsSessionThreadAgentEntryDiscriminatorType
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
    public static class BetaManagedAgentsSessionThreadAgentEntryDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionThreadAgentEntryDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionThreadAgentEntryDiscriminatorType.Advisor => "advisor",
                BetaManagedAgentsSessionThreadAgentEntryDiscriminatorType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionThreadAgentEntryDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "advisor" => BetaManagedAgentsSessionThreadAgentEntryDiscriminatorType.Advisor,
                "agent" => BetaManagedAgentsSessionThreadAgentEntryDiscriminatorType.Agent,
                _ => null,
            };
        }
    }
}