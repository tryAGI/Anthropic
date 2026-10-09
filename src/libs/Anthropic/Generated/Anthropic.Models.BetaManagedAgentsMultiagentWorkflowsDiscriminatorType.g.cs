
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsMultiagentWorkflowsDiscriminatorType
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
    public static class BetaManagedAgentsMultiagentWorkflowsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentWorkflowsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentWorkflowsDiscriminatorType.Disabled => "disabled",
                BetaManagedAgentsMultiagentWorkflowsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentWorkflowsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaManagedAgentsMultiagentWorkflowsDiscriminatorType.Disabled,
                "enabled" => BetaManagedAgentsMultiagentWorkflowsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}