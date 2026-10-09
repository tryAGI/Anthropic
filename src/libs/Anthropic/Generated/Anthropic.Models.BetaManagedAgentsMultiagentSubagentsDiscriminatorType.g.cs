
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsMultiagentSubagentsDiscriminatorType
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
    public static class BetaManagedAgentsMultiagentSubagentsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentSubagentsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentSubagentsDiscriminatorType.Disabled => "disabled",
                BetaManagedAgentsMultiagentSubagentsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentSubagentsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaManagedAgentsMultiagentSubagentsDiscriminatorType.Disabled,
                "enabled" => BetaManagedAgentsMultiagentSubagentsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}