
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsMultiagentAdvisorDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMultiagentAdvisorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentAdvisorDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentAdvisorDiscriminatorType.Disabled => "disabled",
                BetaManagedAgentsMultiagentAdvisorDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentAdvisorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaManagedAgentsMultiagentAdvisorDiscriminatorType.Disabled,
                "enabled" => BetaManagedAgentsMultiagentAdvisorDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}