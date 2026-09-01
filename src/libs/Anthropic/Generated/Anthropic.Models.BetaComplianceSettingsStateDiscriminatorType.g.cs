
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaComplianceSettingsStateDiscriminatorType
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
    public static class BetaComplianceSettingsStateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceSettingsStateDiscriminatorType value)
        {
            return value switch
            {
                BetaComplianceSettingsStateDiscriminatorType.Disabled => "disabled",
                BetaComplianceSettingsStateDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceSettingsStateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaComplianceSettingsStateDiscriminatorType.Disabled,
                "enabled" => BetaComplianceSettingsStateDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}