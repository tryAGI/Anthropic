
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType
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
    public static class BetaManagedAgentsMultiagentInlineAgentsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType.Disabled => "disabled",
                BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType.Disabled,
                "enabled" => BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}