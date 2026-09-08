
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        ClaudeTagCategory,
        /// <summary>
        ///
        /// </summary>
        ClaudeTagUserId,
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
        Product,
        /// <summary>
        ///
        /// </summary>
        RbacGroupId,
        /// <summary>
        ///
        /// </summary>
        SlackChannelId,
        /// <summary>
        ///
        /// </summary>
        Speed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item value)
        {
            return value switch
            {
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.ClaudeTagCategory => "claude_tag_category",
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.ClaudeTagUserId => "claude_tag_user_id",
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.ContextWindow => "context_window",
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.InferenceGeo => "inference_geo",
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.Model => "model",
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.Product => "product",
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.RbacGroupId => "rbac_group_id",
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.SlackChannelId => "slack_channel_id",
                BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.Speed => "speed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "claude_tag_category" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.ClaudeTagCategory,
                "claude_tag_user_id" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.ClaudeTagUserId,
                "context_window" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.ContextWindow,
                "inference_geo" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.InferenceGeo,
                "model" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.Model,
                "product" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.Product,
                "rbac_group_id" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.RbacGroupId,
                "slack_channel_id" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.SlackChannelId,
                "speed" => BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item.Speed,
                _ => null,
            };
        }
    }
}