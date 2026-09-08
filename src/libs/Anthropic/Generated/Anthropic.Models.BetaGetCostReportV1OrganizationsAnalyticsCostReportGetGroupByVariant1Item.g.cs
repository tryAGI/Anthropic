
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item
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
    public static class BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item value)
        {
            return value switch
            {
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.ClaudeTagCategory => "claude_tag_category",
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.ClaudeTagUserId => "claude_tag_user_id",
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.ContextWindow => "context_window",
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.CostType => "cost_type",
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.InferenceGeo => "inference_geo",
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.Model => "model",
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.Product => "product",
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.RbacGroupId => "rbac_group_id",
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.SlackChannelId => "slack_channel_id",
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.Speed => "speed",
                BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.TokenType => "token_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "claude_tag_category" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.ClaudeTagCategory,
                "claude_tag_user_id" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.ClaudeTagUserId,
                "context_window" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.ContextWindow,
                "cost_type" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.CostType,
                "inference_geo" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.InferenceGeo,
                "model" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.Model,
                "product" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.Product,
                "rbac_group_id" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.RbacGroupId,
                "slack_channel_id" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.SlackChannelId,
                "speed" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.Speed,
                "token_type" => BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item.TokenType,
                _ => null,
            };
        }
    }
}