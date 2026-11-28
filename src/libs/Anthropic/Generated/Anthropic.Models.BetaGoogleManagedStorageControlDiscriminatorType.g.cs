
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGoogleManagedStorageControlDiscriminatorType
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
    public static class BetaGoogleManagedStorageControlDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGoogleManagedStorageControlDiscriminatorType value)
        {
            return value switch
            {
                BetaGoogleManagedStorageControlDiscriminatorType.Disabled => "disabled",
                BetaGoogleManagedStorageControlDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGoogleManagedStorageControlDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaGoogleManagedStorageControlDiscriminatorType.Disabled,
                "enabled" => BetaGoogleManagedStorageControlDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}