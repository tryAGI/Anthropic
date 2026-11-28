
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaStorageControlEnabledStatusDiscriminatorType
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
    public static class BetaStorageControlEnabledStatusDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaStorageControlEnabledStatusDiscriminatorType value)
        {
            return value switch
            {
                BetaStorageControlEnabledStatusDiscriminatorType.Active => "active",
                BetaStorageControlEnabledStatusDiscriminatorType.Failed => "failed",
                BetaStorageControlEnabledStatusDiscriminatorType.NotConfigured => "not_configured",
                BetaStorageControlEnabledStatusDiscriminatorType.Pending => "pending",
                BetaStorageControlEnabledStatusDiscriminatorType.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaStorageControlEnabledStatusDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaStorageControlEnabledStatusDiscriminatorType.Active,
                "failed" => BetaStorageControlEnabledStatusDiscriminatorType.Failed,
                "not_configured" => BetaStorageControlEnabledStatusDiscriminatorType.NotConfigured,
                "pending" => BetaStorageControlEnabledStatusDiscriminatorType.Pending,
                "suspended" => BetaStorageControlEnabledStatusDiscriminatorType.Suspended,
                _ => null,
            };
        }
    }
}