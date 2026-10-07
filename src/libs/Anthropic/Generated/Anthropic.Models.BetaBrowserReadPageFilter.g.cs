
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaBrowserReadPageFilter
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Interactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBrowserReadPageFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBrowserReadPageFilter value)
        {
            return value switch
            {
                BetaBrowserReadPageFilter.All => "all",
                BetaBrowserReadPageFilter.Interactive => "interactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBrowserReadPageFilter? ToEnum(string value)
        {
            return value switch
            {
                "all" => BetaBrowserReadPageFilter.All,
                "interactive" => BetaBrowserReadPageFilter.Interactive,
                _ => null,
            };
        }
    }
}