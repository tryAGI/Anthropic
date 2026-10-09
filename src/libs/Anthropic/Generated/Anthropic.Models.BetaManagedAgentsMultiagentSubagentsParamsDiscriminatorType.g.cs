
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType
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
    public static class BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType.Disabled => "disabled",
                BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType.Disabled,
                "enabled" => BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}