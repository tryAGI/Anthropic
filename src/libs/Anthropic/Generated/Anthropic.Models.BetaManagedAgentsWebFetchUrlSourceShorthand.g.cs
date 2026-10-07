
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// String form of a url_sources value that has no field other than its type: "all" means {"type": "all"} and "none" means {"type": "none"}.
    /// </summary>
    public enum BetaManagedAgentsWebFetchUrlSourceShorthand
    {
        /// <summary>
        /// "all" means {"type": "all"} and "none" means {"type": "none"}.
        /// </summary>
        All,
        /// <summary>
        /// "all" means {"type": "all"} and "none" means {"type": "none"}.
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsWebFetchUrlSourceShorthandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsWebFetchUrlSourceShorthand value)
        {
            return value switch
            {
                BetaManagedAgentsWebFetchUrlSourceShorthand.All => "all",
                BetaManagedAgentsWebFetchUrlSourceShorthand.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceShorthand? ToEnum(string value)
        {
            return value switch
            {
                "all" => BetaManagedAgentsWebFetchUrlSourceShorthand.All,
                "none" => BetaManagedAgentsWebFetchUrlSourceShorthand.None,
                _ => null,
            };
        }
    }
}