
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType
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
    public static class BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType.Disabled => "disabled",
                BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType.Disabled,
                "enabled" => BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}