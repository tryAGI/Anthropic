
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCmekControlEnabledStatusDiscriminatorType
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
    public static class BetaCmekControlEnabledStatusDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCmekControlEnabledStatusDiscriminatorType value)
        {
            return value switch
            {
                BetaCmekControlEnabledStatusDiscriminatorType.Active => "active",
                BetaCmekControlEnabledStatusDiscriminatorType.Failed => "failed",
                BetaCmekControlEnabledStatusDiscriminatorType.NotConfigured => "not_configured",
                BetaCmekControlEnabledStatusDiscriminatorType.Pending => "pending",
                BetaCmekControlEnabledStatusDiscriminatorType.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCmekControlEnabledStatusDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaCmekControlEnabledStatusDiscriminatorType.Active,
                "failed" => BetaCmekControlEnabledStatusDiscriminatorType.Failed,
                "not_configured" => BetaCmekControlEnabledStatusDiscriminatorType.NotConfigured,
                "pending" => BetaCmekControlEnabledStatusDiscriminatorType.Pending,
                "suspended" => BetaCmekControlEnabledStatusDiscriminatorType.Suspended,
                _ => null,
            };
        }
    }
}