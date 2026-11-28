
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGoogleManagedStorageRegionStatusDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        NotConfigured,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Suspended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGoogleManagedStorageRegionStatusDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGoogleManagedStorageRegionStatusDiscriminatorType value)
        {
            return value switch
            {
                BetaGoogleManagedStorageRegionStatusDiscriminatorType.Active => "active",
                BetaGoogleManagedStorageRegionStatusDiscriminatorType.Failed => "failed",
                BetaGoogleManagedStorageRegionStatusDiscriminatorType.NotConfigured => "not_configured",
                BetaGoogleManagedStorageRegionStatusDiscriminatorType.Pending => "pending",
                BetaGoogleManagedStorageRegionStatusDiscriminatorType.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGoogleManagedStorageRegionStatusDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaGoogleManagedStorageRegionStatusDiscriminatorType.Active,
                "failed" => BetaGoogleManagedStorageRegionStatusDiscriminatorType.Failed,
                "not_configured" => BetaGoogleManagedStorageRegionStatusDiscriminatorType.NotConfigured,
                "pending" => BetaGoogleManagedStorageRegionStatusDiscriminatorType.Pending,
                "suspended" => BetaGoogleManagedStorageRegionStatusDiscriminatorType.Suspended,
                _ => null,
            };
        }
    }
}