
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaUsageReportServiceTier
    {
        /// <summary>
        ///
        /// </summary>
        Batch,
        /// <summary>
        ///
        /// </summary>
        Flex,
        /// <summary>
        ///
        /// </summary>
        FlexDiscount,
        /// <summary>
        ///
        /// </summary>
        Priority,
        /// <summary>
        ///
        /// </summary>
        PriorityOnDemand,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUsageReportServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUsageReportServiceTier value)
        {
            return value switch
            {
                BetaUsageReportServiceTier.Batch => "batch",
                BetaUsageReportServiceTier.Flex => "flex",
                BetaUsageReportServiceTier.FlexDiscount => "flex_discount",
                BetaUsageReportServiceTier.Priority => "priority",
                BetaUsageReportServiceTier.PriorityOnDemand => "priority_on_demand",
                BetaUsageReportServiceTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUsageReportServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BetaUsageReportServiceTier.Batch,
                "flex" => BetaUsageReportServiceTier.Flex,
                "flex_discount" => BetaUsageReportServiceTier.FlexDiscount,
                "priority" => BetaUsageReportServiceTier.Priority,
                "priority_on_demand" => BetaUsageReportServiceTier.PriorityOnDemand,
                "standard" => BetaUsageReportServiceTier.Standard,
                _ => null,
            };
        }
    }
}