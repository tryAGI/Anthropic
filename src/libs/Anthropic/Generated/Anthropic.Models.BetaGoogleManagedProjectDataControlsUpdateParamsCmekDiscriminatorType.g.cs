
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGoogleManagedProjectDataControlsUpdateParamsCmekDiscriminatorType
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
    public static class BetaGoogleManagedProjectDataControlsUpdateParamsCmekDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGoogleManagedProjectDataControlsUpdateParamsCmekDiscriminatorType value)
        {
            return value switch
            {
                BetaGoogleManagedProjectDataControlsUpdateParamsCmekDiscriminatorType.Disabled => "disabled",
                BetaGoogleManagedProjectDataControlsUpdateParamsCmekDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGoogleManagedProjectDataControlsUpdateParamsCmekDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaGoogleManagedProjectDataControlsUpdateParamsCmekDiscriminatorType.Disabled,
                "enabled" => BetaGoogleManagedProjectDataControlsUpdateParamsCmekDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}