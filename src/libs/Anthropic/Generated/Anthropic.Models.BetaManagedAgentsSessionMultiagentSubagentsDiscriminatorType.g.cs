
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType
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
    public static class BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType.Disabled => "disabled",
                BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType.Disabled,
                "enabled" => BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}