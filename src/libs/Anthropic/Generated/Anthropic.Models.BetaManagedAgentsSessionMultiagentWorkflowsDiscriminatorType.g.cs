
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsSessionMultiagentWorkflowsDiscriminatorType
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
    public static class BetaManagedAgentsSessionMultiagentWorkflowsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionMultiagentWorkflowsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionMultiagentWorkflowsDiscriminatorType.Disabled => "disabled",
                BetaManagedAgentsSessionMultiagentWorkflowsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionMultiagentWorkflowsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaManagedAgentsSessionMultiagentWorkflowsDiscriminatorType.Disabled,
                "enabled" => BetaManagedAgentsSessionMultiagentWorkflowsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}