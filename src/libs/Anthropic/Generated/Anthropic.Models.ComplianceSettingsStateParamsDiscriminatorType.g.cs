
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ComplianceSettingsStateParamsDiscriminatorType
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
    public static class ComplianceSettingsStateParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComplianceSettingsStateParamsDiscriminatorType value)
        {
            return value switch
            {
                ComplianceSettingsStateParamsDiscriminatorType.Disabled => "disabled",
                ComplianceSettingsStateParamsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComplianceSettingsStateParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ComplianceSettingsStateParamsDiscriminatorType.Disabled,
                "enabled" => ComplianceSettingsStateParamsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}