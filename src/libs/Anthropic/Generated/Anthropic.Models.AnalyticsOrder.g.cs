
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Sort direction: `asc` or `desc`. Defaults to `asc` for the endpoint's sort column and to `desc` when `order_by` names a metric (a top-N ranking). Applies to `order_by`, or to the endpoint's default sort field when `order_by` is omitted.
    /// </summary>
    public enum AnalyticsOrder
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
    public static class AnalyticsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsOrder value)
        {
            return value switch
            {
                AnalyticsOrder.Asc => "asc",
                AnalyticsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AnalyticsOrder.Asc,
                "desc" => AnalyticsOrder.Desc,
                _ => null,
            };
        }
    }
}