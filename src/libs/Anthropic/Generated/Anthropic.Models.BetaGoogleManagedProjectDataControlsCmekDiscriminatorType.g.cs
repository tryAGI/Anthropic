
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGoogleManagedProjectDataControlsCmekDiscriminatorType
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
    public static class BetaGoogleManagedProjectDataControlsCmekDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGoogleManagedProjectDataControlsCmekDiscriminatorType value)
        {
            return value switch
            {
                BetaGoogleManagedProjectDataControlsCmekDiscriminatorType.Disabled => "disabled",
                BetaGoogleManagedProjectDataControlsCmekDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGoogleManagedProjectDataControlsCmekDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaGoogleManagedProjectDataControlsCmekDiscriminatorType.Disabled,
                "enabled" => BetaGoogleManagedProjectDataControlsCmekDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}