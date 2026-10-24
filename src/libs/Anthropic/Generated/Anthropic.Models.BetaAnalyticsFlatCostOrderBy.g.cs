
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsFlatCostOrderBy
    {
        /// <summary>
        ///
        /// </summary>
        Amount,
        /// <summary>
        ///
        /// </summary>
        ListAmount,
        /// <summary>
        ///
        /// </summary>
        Time,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsFlatCostOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsFlatCostOrderBy value)
        {
            return value switch
            {
                BetaAnalyticsFlatCostOrderBy.Amount => "amount",
                BetaAnalyticsFlatCostOrderBy.ListAmount => "list_amount",
                BetaAnalyticsFlatCostOrderBy.Time => "time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsFlatCostOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "amount" => BetaAnalyticsFlatCostOrderBy.Amount,
                "list_amount" => BetaAnalyticsFlatCostOrderBy.ListAmount,
                "time" => BetaAnalyticsFlatCostOrderBy.Time,
                _ => null,
            };
        }
    }
}