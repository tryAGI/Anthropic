
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPluginMarketplaceSyncStatus
    {
        /// <summary>
        ///
        /// </summary>
        FailedAuth,
        /// <summary>
        ///
        /// </summary>
        FailedContent,
        /// <summary>
        ///
        /// </summary>
        FailedLimits,
        /// <summary>
        ///
        /// </summary>
        FailedTransient,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPluginMarketplaceSyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginMarketplaceSyncStatus value)
        {
            return value switch
            {
                BetaPluginMarketplaceSyncStatus.FailedAuth => "failed_auth",
                BetaPluginMarketplaceSyncStatus.FailedContent => "failed_content",
                BetaPluginMarketplaceSyncStatus.FailedLimits => "failed_limits",
                BetaPluginMarketplaceSyncStatus.FailedTransient => "failed_transient",
                BetaPluginMarketplaceSyncStatus.InProgress => "in_progress",
                BetaPluginMarketplaceSyncStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginMarketplaceSyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed_auth" => BetaPluginMarketplaceSyncStatus.FailedAuth,
                "failed_content" => BetaPluginMarketplaceSyncStatus.FailedContent,
                "failed_limits" => BetaPluginMarketplaceSyncStatus.FailedLimits,
                "failed_transient" => BetaPluginMarketplaceSyncStatus.FailedTransient,
                "in_progress" => BetaPluginMarketplaceSyncStatus.InProgress,
                "success" => BetaPluginMarketplaceSyncStatus.Success,
                _ => null,
            };
        }
    }
}