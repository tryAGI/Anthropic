
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGoogleManagedStorageControlParamsDiscriminatorType
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
    public static class BetaGoogleManagedStorageControlParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGoogleManagedStorageControlParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaGoogleManagedStorageControlParamsDiscriminatorType.Disabled => "disabled",
                BetaGoogleManagedStorageControlParamsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGoogleManagedStorageControlParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaGoogleManagedStorageControlParamsDiscriminatorType.Disabled,
                "enabled" => BetaGoogleManagedStorageControlParamsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}