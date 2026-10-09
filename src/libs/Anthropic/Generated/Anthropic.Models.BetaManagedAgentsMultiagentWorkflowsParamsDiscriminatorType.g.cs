
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType
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
    public static class BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType.Disabled => "disabled",
                BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType.Disabled,
                "enabled" => BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}