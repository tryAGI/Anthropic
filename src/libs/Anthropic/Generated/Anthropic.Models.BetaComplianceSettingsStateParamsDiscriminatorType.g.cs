
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaComplianceSettingsStateParamsDiscriminatorType
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
    public static class BetaComplianceSettingsStateParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceSettingsStateParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaComplianceSettingsStateParamsDiscriminatorType.Disabled => "disabled",
                BetaComplianceSettingsStateParamsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceSettingsStateParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaComplianceSettingsStateParamsDiscriminatorType.Disabled,
                "enabled" => BetaComplianceSettingsStateParamsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}