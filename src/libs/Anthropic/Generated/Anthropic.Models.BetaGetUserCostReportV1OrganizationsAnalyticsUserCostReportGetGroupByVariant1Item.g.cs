
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item
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
        CostType,
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
        /// <summary>
        ///
        /// </summary>
        TokenType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item value)
        {
            return value switch
            {
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.ClaudeTagCategory => "claude_tag_category",
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.ClaudeTagUserId => "claude_tag_user_id",
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.ContextWindow => "context_window",
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.CostType => "cost_type",
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.InferenceGeo => "inference_geo",
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.Model => "model",
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.Product => "product",
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.RbacGroupId => "rbac_group_id",
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.SlackChannelId => "slack_channel_id",
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.Speed => "speed",
                BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.TokenType => "token_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "claude_tag_category" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.ClaudeTagCategory,
                "claude_tag_user_id" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.ClaudeTagUserId,
                "context_window" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.ContextWindow,
                "cost_type" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.CostType,
                "inference_geo" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.InferenceGeo,
                "model" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.Model,
                "product" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.Product,
                "rbac_group_id" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.RbacGroupId,
                "slack_channel_id" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.SlackChannelId,
                "speed" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.Speed,
                "token_type" => BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item.TokenType,
                _ => null,
            };
        }
    }
}