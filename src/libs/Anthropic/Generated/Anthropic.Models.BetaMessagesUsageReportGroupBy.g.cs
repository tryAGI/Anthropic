
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaMessagesUsageReportGroupBy
    {
        /// <summary>
        ///
        /// </summary>
        AccountId,
        /// <summary>
        ///
        /// </summary>
        ApiKeyId,
        /// <summary>
        ///
        /// </summary>
        ContextWindow,
        /// <summary>
        ///
        /// </summary>
        InferenceGeo,
        /// <summary>
        ///
        /// </summary>
        Model,
        /// <summary>
        ///
        /// </summary>
        ServiceAccountId,
        /// <summary>
        ///
        /// </summary>
        ServiceTier,
        /// <summary>
        ///
        /// </summary>
        Speed,
        /// <summary>
        ///
        /// </summary>
        WorkspaceId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMessagesUsageReportGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessagesUsageReportGroupBy value)
        {
            return value switch
            {
                BetaMessagesUsageReportGroupBy.AccountId => "account_id",
                BetaMessagesUsageReportGroupBy.ApiKeyId => "api_key_id",
                BetaMessagesUsageReportGroupBy.ContextWindow => "context_window",
                BetaMessagesUsageReportGroupBy.InferenceGeo => "inference_geo",
                BetaMessagesUsageReportGroupBy.Model => "model",
                BetaMessagesUsageReportGroupBy.ServiceAccountId => "service_account_id",
                BetaMessagesUsageReportGroupBy.ServiceTier => "service_tier",
                BetaMessagesUsageReportGroupBy.Speed => "speed",
                BetaMessagesUsageReportGroupBy.WorkspaceId => "workspace_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessagesUsageReportGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "account_id" => BetaMessagesUsageReportGroupBy.AccountId,
                "api_key_id" => BetaMessagesUsageReportGroupBy.ApiKeyId,
                "context_window" => BetaMessagesUsageReportGroupBy.ContextWindow,
                "inference_geo" => BetaMessagesUsageReportGroupBy.InferenceGeo,
                "model" => BetaMessagesUsageReportGroupBy.Model,
                "service_account_id" => BetaMessagesUsageReportGroupBy.ServiceAccountId,
                "service_tier" => BetaMessagesUsageReportGroupBy.ServiceTier,
                "speed" => BetaMessagesUsageReportGroupBy.Speed,
                "workspace_id" => BetaMessagesUsageReportGroupBy.WorkspaceId,
                _ => null,
            };
        }
    }
}