
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGoogleManagedCmekRegionStatusDiscriminatorType
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
    public static class BetaGoogleManagedCmekRegionStatusDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGoogleManagedCmekRegionStatusDiscriminatorType value)
        {
            return value switch
            {
                BetaGoogleManagedCmekRegionStatusDiscriminatorType.Active => "active",
                BetaGoogleManagedCmekRegionStatusDiscriminatorType.Failed => "failed",
                BetaGoogleManagedCmekRegionStatusDiscriminatorType.NotConfigured => "not_configured",
                BetaGoogleManagedCmekRegionStatusDiscriminatorType.Pending => "pending",
                BetaGoogleManagedCmekRegionStatusDiscriminatorType.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGoogleManagedCmekRegionStatusDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaGoogleManagedCmekRegionStatusDiscriminatorType.Active,
                "failed" => BetaGoogleManagedCmekRegionStatusDiscriminatorType.Failed,
                "not_configured" => BetaGoogleManagedCmekRegionStatusDiscriminatorType.NotConfigured,
                "pending" => BetaGoogleManagedCmekRegionStatusDiscriminatorType.Pending,
                "suspended" => BetaGoogleManagedCmekRegionStatusDiscriminatorType.Suspended,
                _ => null,
            };
        }
    }
}