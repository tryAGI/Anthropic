
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BrowserReadPageFilter
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
    public static class BrowserReadPageFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BrowserReadPageFilter value)
        {
            return value switch
            {
                BrowserReadPageFilter.All => "all",
                BrowserReadPageFilter.Interactive => "interactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BrowserReadPageFilter? ToEnum(string value)
        {
            return value switch
            {
                "all" => BrowserReadPageFilter.All,
                "interactive" => BrowserReadPageFilter.Interactive,
                _ => null,
            };
        }
    }
}