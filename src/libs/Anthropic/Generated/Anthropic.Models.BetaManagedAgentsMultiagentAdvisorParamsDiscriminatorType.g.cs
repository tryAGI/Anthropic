
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType
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
    public static class BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType.Disabled => "disabled",
                BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType.Disabled,
                "enabled" => BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}