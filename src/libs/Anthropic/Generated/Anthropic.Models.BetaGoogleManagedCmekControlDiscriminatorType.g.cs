
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGoogleManagedCmekControlDiscriminatorType
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
    public static class BetaGoogleManagedCmekControlDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGoogleManagedCmekControlDiscriminatorType value)
        {
            return value switch
            {
                BetaGoogleManagedCmekControlDiscriminatorType.Disabled => "disabled",
                BetaGoogleManagedCmekControlDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGoogleManagedCmekControlDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaGoogleManagedCmekControlDiscriminatorType.Disabled,
                "enabled" => BetaGoogleManagedCmekControlDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}