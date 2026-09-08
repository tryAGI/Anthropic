
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsCostUsersOrderBy
    {
        /// <summary>
        ///
        /// </summary>
        Amount,
        /// <summary>
        ///
        /// </summary>
        ListAmount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsCostUsersOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsCostUsersOrderBy value)
        {
            return value switch
            {
                BetaAnalyticsCostUsersOrderBy.Amount => "amount",
                BetaAnalyticsCostUsersOrderBy.ListAmount => "list_amount",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsCostUsersOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "amount" => BetaAnalyticsCostUsersOrderBy.Amount,
                "list_amount" => BetaAnalyticsCostUsersOrderBy.ListAmount,
                _ => null,
            };
        }
    }
}