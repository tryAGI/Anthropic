
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsSortOrder
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsSortOrder value)
        {
            return value switch
            {
                BetaAnalyticsSortOrder.Asc => "asc",
                BetaAnalyticsSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BetaAnalyticsSortOrder.Asc,
                "desc" => BetaAnalyticsSortOrder.Desc,
                _ => null,
            };
        }
    }
}