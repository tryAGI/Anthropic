
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGoogleManagedCmekControlParamsDiscriminatorType
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
    public static class BetaGoogleManagedCmekControlParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGoogleManagedCmekControlParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaGoogleManagedCmekControlParamsDiscriminatorType.Disabled => "disabled",
                BetaGoogleManagedCmekControlParamsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGoogleManagedCmekControlParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaGoogleManagedCmekControlParamsDiscriminatorType.Disabled,
                "enabled" => BetaGoogleManagedCmekControlParamsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}