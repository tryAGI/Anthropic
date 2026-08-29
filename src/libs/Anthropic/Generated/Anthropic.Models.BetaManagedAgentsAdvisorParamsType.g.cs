
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsAdvisorParamsType
    {
        /// <summary>
        ///
        /// </summary>
        Advisor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAdvisorParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAdvisorParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsAdvisorParamsType.Advisor => "advisor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAdvisorParamsType? ToEnum(string value)
        {
            return value switch
            {
                "advisor" => BetaManagedAgentsAdvisorParamsType.Advisor,
                _ => null,
            };
        }
    }
}