
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Sort direction: `asc` or `desc`. Defaults to `asc` for the endpoint's sort column and to `desc` when `order_by` names a metric (a top-N ranking). Applies to `order_by`, or to the endpoint's default sort field when `order_by` is omitted.
    /// </summary>
    public enum BetaAnalyticsOrder
    {
        /// <summary>
        /// `asc` or `desc`. Defaults to `asc` for the endpoint's sort column and to `desc` when `order_by` names a metric (a top-N ranking). Applies to `order_by`, or to the endpoint's default sort field when `order_by` is omitted.
        /// </summary>
        Asc,
        /// <summary>
        /// `asc` or `desc`. Defaults to `asc` for the endpoint's sort column and to `desc` when `order_by` names a metric (a top-N ranking). Applies to `order_by`, or to the endpoint's default sort field when `order_by` is omitted.
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsOrder value)
        {
            return value switch
            {
                BetaAnalyticsOrder.Asc => "asc",
                BetaAnalyticsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BetaAnalyticsOrder.Asc,
                "desc" => BetaAnalyticsOrder.Desc,
                _ => null,
            };
        }
    }
}