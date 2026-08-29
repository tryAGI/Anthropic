
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaMessagesUsageReportContextWindow
    {
        /// <summary>
        ///
        /// </summary>
        x0200k,
        /// <summary>
        ///
        /// </summary>
        x200k1m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMessagesUsageReportContextWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessagesUsageReportContextWindow value)
        {
            return value switch
            {
                BetaMessagesUsageReportContextWindow.x0200k => "0-200k",
                BetaMessagesUsageReportContextWindow.x200k1m => "200k-1M",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessagesUsageReportContextWindow? ToEnum(string value)
        {
            return value switch
            {
                "0-200k" => BetaMessagesUsageReportContextWindow.x0200k,
                "200k-1M" => BetaMessagesUsageReportContextWindow.x200k1m,
                _ => null,
            };
        }
    }
}